using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Db.Services;
using Jobbie.Web.Extensions;
using Jobbie.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace Jobbie.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;
        private readonly ICompanyTypeService _companyTypeService;
        private readonly IProfessionDisciplineService _professionDisciplineService;
        private readonly IStateService _stateService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsController"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="accountService"></param>
        public AccountsController(IMapper mapper, 
            IAccountService accountService, 
            ICompanyTypeService companyTypeService,
            IProfessionDisciplineService professionDisciplineService, 
            IStateService stateService)
        {
            _mapper = mapper;
            _accountService = accountService;
            _companyTypeService = companyTypeService;
            _professionDisciplineService = professionDisciplineService;
            _stateService = stateService;
        }

        /// <summary>
        /// Indexes the specified page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public IActionResult Index(int? page)
        {
            IEnumerable<Account> accounts = _accountService.List();

            IPagedList<AccountViewModel> accountViewModels = accounts
                .ToPagedList(page ?? 1, Constants.Constants.PageSize)
                .Map<Account, AccountViewModel>(_mapper);

            AccountIndexViewModel model = new AccountIndexViewModel
            {
                Accounts = accountViewModels
            };

            return View(model);
        }

        /// <summary>
        /// Edits the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IActionResult Edit(int? id)
        {
            Account? account = id.HasValue
                ? _accountService.Get(x => x.Id == id.Value)
                : new Account();

            if (account == null)
            {
                return RedirectToAction("Index");
            }

            AccountEditViewModel model = _mapper.Map<AccountEditViewModel>(account);
            InstantiateRelatedModels(model);
            InstantiateSelectLists(model);

            return View(model);
        }

        /// <summary>
        /// Edits the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(AccountEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                InstantiateRelatedModels(model);
                InstantiateSelectLists(model);
                return View(model);
            }

            if (model.IsSolicitor && model.SolicitorId == null)
            {
                model.Solicitor = new();
            }

            if (model.Id != 0)
            {
                Account? account = _accountService.Get(x => x.Id == model.Id);
                _mapper.Map(model, account);
                _accountService.Update(account);
            }
            else
            {
                Account account = _mapper.Map<Account>(model);
                _accountService.Create(account);
            }

            return RedirectToAction("Index");
        }

        public JsonResult Delete(int id)
        {
            Account? account = _accountService.Get(x => x.Id == id);

            if (account == null)
            {
                return Json(false);
            }

            _accountService.Delete(account);

            return Json(true);
        }

        public JsonResult Verify(int id)
        {
            Account? account = _accountService.Get(x => x.Id == id);

            if (account == null)
            {
                return Json(false);
            }

            _accountService.Verify(account);

            return Json(true);
        }

        private void InstantiateRelatedModels(AccountEditViewModel model)
        {
            model.Address = model.Address ?? new();
            model.BankAccount = model.BankAccount ?? new();
            model.Contractor = model.Contractor ?? new();
            //model.Solicitor = model.Solicitor ?? new();
        }

        private void InstantiateSelectLists(AccountEditViewModel model)
        {
            model.Address.States = new SelectList(_stateService.List(), "Id", "Name", model.Address.StateId);
            model.Contractor.ProfessionDisciplines = new SelectList(
                _professionDisciplineService
                    .List()
                    .OrderBy(x => x.Profession.Name)
                    .ThenBy(x => x.Discipline.Name),
                "Id",
                "Name",
                model.Contractor.ProfessionDisciplineId
            );
            model.CompanyTypes = new SelectList(_companyTypeService.List(), "Id", "Name", model.CompanyTypeId);
        }
    }
}

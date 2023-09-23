using AutoMapper;
using Jobbie.Db.Models;
using Jobbie.Db.Services;
using Jobbie.Web.Extensions;
using Jobbie.Web.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Jobbie.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsController"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="accountService"></param>
        public AccountsController(IMapper mapper, IAccountService accountService)
        {
            _mapper = mapper;
            _accountService = accountService;
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
            //InstantiateSelectLists(model);

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
                //InstantiateSelectLists(model);
                return View(model);
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
    }
}

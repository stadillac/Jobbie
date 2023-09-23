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
    public class ContractorsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IContractorService _contractorService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractorsController"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="contractorService"></param>
        public ContractorsController(IMapper mapper, IContractorService contractorService)
        {
            _mapper = mapper;
            _contractorService = contractorService;
        }

        /// <summary>
        /// Indexes the specified page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public IActionResult Index(int? page)
        {
            IEnumerable<Contractor> contractors = _contractorService.List();

            IPagedList<ContractorViewModel> contractorViewModels = contractors
                .ToPagedList(page ?? 1, Constants.Constants.PageSize)
                .Map<Contractor, ContractorViewModel>(_mapper);

            ContractorIndexViewModel model = new ContractorIndexViewModel
            {
                Contractors = contractorViewModels
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
            Contractor? contractor = id.HasValue
                ? _contractorService.Get(x => x.Id == id.Value)
                : new Contractor();

            if (contractor == null)
            {
                return RedirectToAction("Index");
            }

            ContractorEditViewModel model = _mapper.Map<ContractorEditViewModel>(contractor);

            return View(model);
        }

        /// <summary>
        /// Edits the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(ContractorEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //InstantiateSelectLists(model);
                return View(model);
            }

            if (model.Id != 0)
            {
                Contractor? contractor = _contractorService.Get(x => x.Id == model.Id);
                _mapper.Map(model, contractor);
                _contractorService.Update(contractor);
            }
            else
            {
                Contractor contractor = _mapper.Map<Contractor>(model);
                _contractorService.Create(contractor);
            }

            return RedirectToAction("Index");
        }

        public JsonResult Delete(int id)
        {
            Contractor? contractor = _contractorService.Get(x => x.Id == id);

            if (contractor == null)
            {
                return Json(false);
            }

            _contractorService.Delete(contractor);

            return Json(true);
        }
    }
}

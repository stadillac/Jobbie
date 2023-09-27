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
    public class LicensesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILicenseService _licenseService;

        /// <summary>
        /// Initializes a new instance of the <see cref="LicensesController"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="service"></param>
        public LicensesController(IMapper mapper, ILicenseService service)
        {
            _mapper = mapper;
            _licenseService = service;
        }

        /// <summary>
        /// Indexes the specified page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public IActionResult Index(int? page)
        {
            IEnumerable<License> licenses = _licenseService.List();

            IPagedList<LicenseViewModel> licenseViewModels = licenses
                .ToPagedList(page ?? 1, Constants.Constants.PageSize)
                .Map<License, LicenseViewModel>(_mapper);

            LicenseIndexViewModel model = new LicenseIndexViewModel
            {
                Licenses = licenseViewModels
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
            License? license = id.HasValue
                ? _licenseService.Get(x => x.Id == id.Value)
                : new License();

            if (license == null)
            {
                return RedirectToAction("Index");
            }

            LicenseEditViewModel model = _mapper.Map<LicenseEditViewModel>(license);

            return View(model);
        }

        /// <summary>
        /// Edits the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(LicenseEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Id != 0)
            {
                License? license = _licenseService.Get(x => x.Id == model.Id);
                _mapper.Map(model, license);
                _licenseService.Update(license);
            }
            else
            {
                License license = _mapper.Map<License>(model);
                _licenseService.Create(license);
            }

            return RedirectToAction("Index");
        }

        public JsonResult Delete(int id)
        {
            License? license = _licenseService.Get(x => x.Id == id);

            if (license == null)
            {
                return Json(false);
            }

            _licenseService.Delete(license);

            return Json(true);
        }

        public JsonResult Verify(int id)
        {
            License? license = _licenseService.Get(x => x.Id == id);

            if (license == null)
            {
                return Json(false);
            }

            _licenseService.Verify(license);

            return Json(true);
        }
    }
}

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
    public class SpecialtiesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISpecialtyService _specialtyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialtiesController"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="service"></param>
        public SpecialtiesController(IMapper mapper, ISpecialtyService service)
        {
            _mapper = mapper;
            _specialtyService = service;
        }

        /// <summary>
        /// Indexes the specified page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public IActionResult Index(int? page)
        {
            IEnumerable<Specialty> specialtys = _specialtyService.List();

            IPagedList<SpecialtyViewModel> specialtyViewModels = specialtys
                .ToPagedList(page ?? 1, Constants.Constants.PageSize)
                .Map<Specialty, SpecialtyViewModel>(_mapper);

            SpecialtyIndexViewModel model = new SpecialtyIndexViewModel
            {
                Specialties = specialtyViewModels
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
            Specialty? specialty = id.HasValue
                ? _specialtyService.Get(x => x.Id == id.Value)
                : new Specialty();

            if (specialty == null)
            {
                return RedirectToAction("Index");
            }

            SpecialtyEditViewModel model = _mapper.Map<SpecialtyEditViewModel>(specialty);

            return View(model);
        }

        /// <summary>
        /// Edits the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(SpecialtyEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //InstantiateSelectLists(model);
                return View(model);
            }

            if (model.Id != 0)
            {
                Specialty? specialty = _specialtyService.Get(x => x.Id == model.Id);
                _mapper.Map(model, specialty);
                _specialtyService.Update(specialty);
            }
            else
            {
                Specialty specialty = _mapper.Map<Specialty>(model);
                _specialtyService.Create(specialty);
            }

            return RedirectToAction("Index");
        }

        public JsonResult Delete(int id)
        {
            Specialty? specialty = _specialtyService.Get(x => x.Id == id);

            if (specialty == null)
            {
                return Json(false);
            }

            _specialtyService.Delete(specialty);

            return Json(true);
        }
    }
}

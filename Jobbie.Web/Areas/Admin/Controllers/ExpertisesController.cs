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
    public class ExpertisesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IExpertiseService _expertiseService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpertisesController"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="service"></param>
        public ExpertisesController(IMapper mapper, IExpertiseService service)
        {
            _mapper = mapper;
            _expertiseService = service;
        }

        /// <summary>
        /// Indexes the specified page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public IActionResult Index(int? page)
        {
            IEnumerable<Expertise> expertises = _expertiseService.List();

            IPagedList<ExpertiseViewModel> expertiseViewModels = expertises
                .ToPagedList(page ?? 1, Constants.Constants.PageSize)
                .Map<Expertise, ExpertiseViewModel>(_mapper);

            ExpertiseIndexViewModel model = new ExpertiseIndexViewModel
            {
                Expertises = expertiseViewModels
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
            Expertise? expertise = id.HasValue
                ? _expertiseService.Get(x => x.Id == id.Value)
                : new Expertise();

            if (expertise == null)
            {
                return RedirectToAction("Index");
            }

            ExpertiseEditViewModel model = _mapper.Map<ExpertiseEditViewModel>(expertise);

            return View(model);
        }

        /// <summary>
        /// Edits the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(ExpertiseEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //InstantiateSelectLists(model);
                return View(model);
            }

            if (model.Id != 0)
            {
                Expertise? expertise = _expertiseService.Get(x => x.Id == model.Id);
                _mapper.Map(model, expertise);
                _expertiseService.Update(expertise);
            }
            else
            {
                Expertise expertise = _mapper.Map<Expertise>(model);
                _expertiseService.Create(expertise);
            }

            return RedirectToAction("Index");
        }

        public JsonResult Delete(int id)
        {
            Expertise? expertise = _expertiseService.Get(x => x.Id == id);

            if (expertise == null)
            {
                return Json(false);
            }

            _expertiseService.Delete(expertise);

            return Json(true);
        }
    }
}

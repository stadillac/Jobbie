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
    public class FocusesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFocusService _focusService;

        /// <summary>
        /// Initializes a new instance of the <see cref="FocussController"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="service"></param>
        public FocusesController(IMapper mapper, IFocusService service)
        {
            _mapper = mapper;
            _focusService = service;
        }

        /// <summary>
        /// Indexes the specified page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public IActionResult Index(int? page)
        {
            IEnumerable<Focus> focuses = _focusService.List();

            IPagedList<FocusViewModel> focusViewModels = focuses
                .ToPagedList(page ?? 1, Constants.Constants.PageSize)
                .Map<Focus, FocusViewModel>(_mapper);

            FocusIndexViewModel model = new FocusIndexViewModel
            {
                Focuses = focusViewModels
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
            Focus? focus = id.HasValue
                ? _focusService.Get(x => x.Id == id.Value)
                : new Focus();

            if (focus == null)
            {
                return RedirectToAction("Index");
            }

            FocusEditViewModel model = _mapper.Map<FocusEditViewModel>(focus);

            return View(model);
        }

        /// <summary>
        /// Edits the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(FocusEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //InstantiateSelectLists(model);
                return View(model);
            }

            if (model.Id != 0)
            {
                Focus? focus = _focusService.Get(x => x.Id == model.Id);
                _mapper.Map(model, focus);
                _focusService.Update(focus);
            }
            else
            {
                Focus focus = _mapper.Map<Focus>(model);
                _focusService.Create(focus);
            }

            return RedirectToAction("Index");
        }

        public JsonResult Delete(int id)
        {
            Focus? focus = _focusService.Get(x => x.Id == id);

            if (focus == null)
            {
                return Json(false);
            }

            _focusService.Delete(focus);

            return Json(true);
        }
    }
}

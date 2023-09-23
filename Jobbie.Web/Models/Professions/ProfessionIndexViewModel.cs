using X.PagedList;

namespace Jobbie.Web.Models
{
    public class ProfessionIndexViewModel
    {
        public IPagedList<ProfessionViewModel> Professions { get; set; }
    }
}

using X.PagedList;

namespace Jobbie.Web.Models
{
    public class DisciplineIndexViewModel
    {
        public IPagedList<DisciplineViewModel> Disciplines { get; set; }
    }
}

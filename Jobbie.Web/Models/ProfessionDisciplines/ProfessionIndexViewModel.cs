using X.PagedList;

namespace Jobbie.Web.Models
{
    public class ProfessionDisciplineIndexViewModel
    {
        public IPagedList<ProfessionDisciplineViewModel> ProfessionDisciplines { get; set; }
    }
}

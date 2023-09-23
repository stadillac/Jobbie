using X.PagedList;

namespace Jobbie.Web.Models
{
    public class ExpertiseIndexViewModel
    {
        public IPagedList<ExpertiseViewModel> Expertises { get; set; }
    }
}

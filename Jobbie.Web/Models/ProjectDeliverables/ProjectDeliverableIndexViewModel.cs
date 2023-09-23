using X.PagedList;

namespace Jobbie.Web.Models
{
    public class ProjectDeliverableIndexViewModel
    {
        public IPagedList<ProjectDeliverableViewModel> ProjectDeliverables { get; set; }
    }
}

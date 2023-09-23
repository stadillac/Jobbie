using X.PagedList;

namespace Jobbie.Web.Models
{
    public class StatusUpdateIndexViewModel
    {
        public IPagedList<StatusUpdateViewModel> StatusUpdates { get; set; }
    }
}

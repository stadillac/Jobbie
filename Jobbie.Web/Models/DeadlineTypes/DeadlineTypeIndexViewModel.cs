using X.PagedList;

namespace Jobbie.Web.Models
{
    public class DeadlineTypeIndexViewModel
    {
        public IPagedList<DeadlineTypeViewModel> DeadlineTypes { get; set; }
    }
}

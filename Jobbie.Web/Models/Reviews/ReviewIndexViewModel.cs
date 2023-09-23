using X.PagedList;

namespace Jobbie.Web.Models
{
    public class ReviewIndexViewModel
    {
        public IPagedList<ReviewViewModel> Reviews { get; set; }
    }
}

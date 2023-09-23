using X.PagedList;

namespace Jobbie.Web.Models
{
    public class FocusIndexViewModel
    {
        public IPagedList<FocusViewModel> Focuses { get; set; }
    }
}

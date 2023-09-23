using X.PagedList;

namespace Jobbie.Web.Models
{
    public class StateIndexViewModel
    {
        public IPagedList<StateViewModel> States { get; set; }
    }
}

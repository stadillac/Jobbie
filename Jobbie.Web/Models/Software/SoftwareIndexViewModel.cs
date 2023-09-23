using X.PagedList;

namespace Jobbie.Web.Models
{
    public class SoftwareIndexViewModel
    {
        public IPagedList<SoftwareViewModel> Software { get; set; }
    }
}

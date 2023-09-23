using X.PagedList;

namespace Jobbie.Web.Models
{
    public class LicenseIndexViewModel
    {
        public IPagedList<LicenseViewModel> Licenses { get; set; }
    }
}

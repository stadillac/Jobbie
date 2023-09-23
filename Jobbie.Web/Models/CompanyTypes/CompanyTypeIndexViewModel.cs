using X.PagedList;

namespace Jobbie.Web.Models
{
    public class CompanyTypeIndexViewModel
    {
        public IPagedList<CompanyTypeViewModel> CompanyTypes { get; set; }
    }
}

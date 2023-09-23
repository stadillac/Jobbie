using X.PagedList;

namespace Jobbie.Web.Models
{
    public class ContractorIndexViewModel
    {
        public IPagedList<ContractorViewModel> Contractors { get; set; }
    }
}

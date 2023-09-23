using X.PagedList;

namespace Jobbie.Web.Models
{
    public class AddressIndexViewModel
    {
        public IPagedList<AddressViewModel> Addresses { get; set; }
    }
}

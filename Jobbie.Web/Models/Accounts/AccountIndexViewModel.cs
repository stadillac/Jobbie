using X.PagedList;

namespace Jobbie.Web.Models
{
    public class AccountIndexViewModel
    {
        public IPagedList<AccountViewModel> Accounts { get; set; }
    }
}

using X.PagedList;

namespace Jobbie.Web.Models
{
    public class BankAccountIndexViewModel
    {
        public IPagedList<BankAccountViewModel> BankAccounts { get; set; }
    }
}

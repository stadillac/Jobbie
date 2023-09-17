using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class BankAccountService : BaseService<BankAccount>, IBankAccountService
    {
        public BankAccountService(ApplicationContext context) : base(context)
        {
        }
    }
}

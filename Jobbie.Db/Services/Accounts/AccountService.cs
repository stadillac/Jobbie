using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class AccountService : BaseService<Account>, IAccountService
    {
        public AccountService(ApplicationContext context) : base(context)
        {
        }
    }
}

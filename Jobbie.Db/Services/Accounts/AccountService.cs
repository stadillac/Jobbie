using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class AccountService : BaseService<Account>, IAccountService
    {
        public AccountService(ApplicationContext context) : base(context)
        {
        }
    }
}

using Operations.Entity.EntityModels;

namespace Jobbie.Db.Services
{
    public class BankAccountService : BaseService<BankAccount>, IBankAccountService
    {
        public BankAccountService(ApplicationContext context) : base(context)
        {
        }
    }
}

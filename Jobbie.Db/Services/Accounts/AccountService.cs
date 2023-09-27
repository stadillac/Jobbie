using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class AccountService : BaseService<Account>, IAccountService
    {
        public AccountService(ApplicationContext context) : base(context)
        {
        }

        /// <inheritdoc />
        public Account Verify(Account entity)
        {
            entity.IsVerified = true;
            _context.Accounts.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}

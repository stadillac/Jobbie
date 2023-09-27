using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class BankAccountService : BaseService<BankAccount>, IBankAccountService
    {
        public BankAccountService(ApplicationContext context) : base(context)
        {
        }

        /// <inheritdoc />
        public BankAccount Verify(BankAccount bankAccount)
        {
            bankAccount.IsVerified = true;
            _context.BankAccounts.Update(bankAccount);
            _context.SaveChanges();
            return bankAccount;
        }
    }
}

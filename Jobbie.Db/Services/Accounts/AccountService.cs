using Jobbie.Db.Models;
using Jobbie.Db.Extensions;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class AccountService : BaseService<Account>, IAccountService
    {
        public AccountService(ApplicationContext context) : base(context)
        {
        }

        public override Account Create(Account entity)
        {
            var userName = $"{entity.FirstName.Substring(0, 1)}{entity.LastName}";

            var possibleDuplicateUsernames = _context.Accounts.Where(x => x.Username.Contains(userName)).ToList();

            // if we have an account with the generated username
            if (possibleDuplicateUsernames.Any(x => x.Username.RemoveDigits().Equals(userName)))
            {
                // get a count of how many accounts have the same user name
                int count = _context.Accounts.Count(x => x.Username.RemoveDigits().Equals(userName));

                // append the count + 1 to the username
                userName += count + 1;
            }

            return base.Create(entity);
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

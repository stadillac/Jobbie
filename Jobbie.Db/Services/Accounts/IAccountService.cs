using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public interface IAccountService : IBaseService<Account>
    {
        /// <summary>
        /// Verifies the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public Account Verify(Account entity);
    }
}

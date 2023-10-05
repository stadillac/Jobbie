using Jobbie.Db.Models;
using Jobbie.Db.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class AccountService : IAccountService
    {
        //private readonly ApplicationContext _context;
        //public AccountService(ApplicationContext context)
        //{
        //    _context = context;
        //}

        //public Account Create(Account entity)
        //{
        //    var userName = $"{entity.FirstName.Substring(0, 1)}{entity.LastName}";

        //    var possibleDuplicateUsernames = _context.Accounts.Where(x => x.Username.Contains(userName)).ToList();

        //    // if we have an account with the generated username
        //    if (possibleDuplicateUsernames.Any(x => x.Username.RemoveDigits().Equals(userName)))
        //    {
        //        // get a count of how many accounts have the same user name
        //        int count = _context.Accounts.Count(x => x.Username.RemoveDigits().Equals(userName));

        //        // append the count + 1 to the username
        //        userName += count + 1;
        //    }

        //    _context.Accounts.Add(entity);
        //    _context.SaveChanges();
        //    return entity;
        //}

        //public Account Delete(Account account)
        //{
        //    account.IsDeleted = true;
        //    _context.Accounts.Update(account);
        //    _context.SaveChanges();
        //    return account;
        //}

        //public Account? Get(Expression<Func<Account, bool>> predicate)
        //{
        //    return _context.Accounts.Where(predicate).FirstOrDefault();
        //}

        //public ICollection<Account> List()
        //{
        //    return _context.Accounts.ToList();
        //}

        //public ICollection<Account> List(Expression<Func<Account, bool>> predicate)
        //{
        //    return _context.Accounts.Where(predicate).ToList();
        //}

        //public Account Update(Account account)
        //{
        //    _context.Accounts.Update(account);
        //    _context.SaveChanges();
        //    return account;
        //}

        ///// <inheritdoc />
        //public Account Verify(Account account)
        //{
        //    account.IsVerified = true;
        //    _context.Accounts.Update(account);
        //    _context.SaveChanges();
        //    return account;
        //}
    }
}

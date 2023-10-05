using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jobbie.Db
{
    public class UserContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public UserContext() { }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Set up connection string in appsettings
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=JobbieDb;Integrated Security=True;TrustServerCertificate=Yes");
        }
    }
}

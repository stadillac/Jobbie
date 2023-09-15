using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Operations.Entity.EntityModels;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection.Emit;
using System.Threading;
using System.Transactions;
using System;
using Microsoft.AspNetCore.Http;

namespace Jobbie.Db
{
    public class ApplicationContext : DbContext
    {
        private IHttpContextAccessor _httpContextAccessor;

        public ApplicationContext()
        {

        }

        public ApplicationContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<DeadlineType> DeadlineTypes { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<JobSubtype> JobSubtypes { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<JobTypeJobSubtype> JobTypeJobSubtypes { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Solicitation> Solicitations { get; set; }
        public DbSet<SolicitationContractor> SolicitationContractors { get; set; }
        public DbSet<SolicitationDeadline> SolicitationDeadlines { get; set; }
        public DbSet<Solicitor> Solicitors { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<State> States { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=ElliottBlair.tech;Database=OperationsDev;Trusted_Connection=False;UID=MicrosoftSucks;Password=Whydoesmicrosoftalwaystortureme?!?!?9766");
            //optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OperationsDev;Trusted_Connection=True;");
            //Local connection string for Elliott
            //optionsBuilder.UseSqlServer(@"Server=192.168.0.239,8765;Database=OperationsDev;Trusted_Connection=False;UID=MicrosoftSucks;Password=Whydoesmicrosoftalwaystortureme?!?!?9766");

            //optionsBuilder.UseSqlServer(@"Server=tcp:sql-devqa-dev.database.windows.net,1433;Initial Catalog=sql-db-devqa-dev-db-project-aurora;Persist Security Info=False;User ID=ssadmin@leaffilter.com;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication=""Active Directory Integrated"";");
            //optionsBuilder.UseSqlServer(@"Server=tcp:sql-devqa-dev.database.windows.net,1433;Initial Catalog=sql-db-devqa-dev-db-project-aurora;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication=""Active Directory Interactive"";");
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=JobbieDb;Integrated Security=True;TrustServerCertificate=Yes");
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return (await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken));
        }

        private void OnBeforeSaving()
        {
            IEnumerable<EntityEntry> entries = ChangeTracker.Entries();
            string userName = _httpContextAccessor.HttpContext.User.Identity.Name;

            foreach (var entry in entries)
            {
                // for entities that inherit from AuditEntity,
                // set fields appropriately
                if (entry.Entity is AuditEntity trackable)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:

                            trackable.ModifiedDate = DateTime.Now;
                            trackable.ModifiedBy = userName;

                            // mark property as "don't touch"
                            // we don't want to update on a Modify operation
                            entry.Property("CreatedDate").IsModified = false;
                            entry.Property("CreatedBy").IsModified = false;
                            break;

                        case EntityState.Added:

                            trackable.CreatedDate = DateTime.Now;
                            trackable.CreatedBy = userName;
                            trackable.ModifiedDate = DateTime.Now;
                            trackable.ModifiedBy = userName;
                            break;
                    }
                }
            }
        }
    }
}
using Jobbie.Db.Extensions;
using Jobbie.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Jobbie.Db
{
    public class ApplicationContext : DbContext
    {
        private readonly IHttpContextAccessor? _httpContextAccessor;

        public ApplicationContext() { }

        public ApplicationContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ContractorSoftware> ContractorSoftware { get; set; }
        public DbSet<DeadlineType> DeadlineTypes { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<JobSubtype> JobSubtypes { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<JobTypeJobSubtype> JobTypeJobSubtypes { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<ProjectDeliverable> ProjectDeliverables { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Software> Software { get; set; }
        public DbSet<Solicitation> Solicitations { get; set; }
        public DbSet<SolicitationContractor> SolicitationContractors { get; set; }
        public DbSet<SolicitationDeadline> SolicitationDeadlines { get; set; }
        public DbSet<SolicitationRole> SolicitationRoles { get; set; }
        public DbSet<SolicitationRoleProvidedSoftware> SolicitationRoleProvidedSoftware { get; set; }
        public DbSet<SolicitationRoleRequiredSoftware> SolicitationRoleRequiredSoftware { get; set; }
        public DbSet<Solicitor> Solicitors { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<State> States { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Set up connection string in appsettings
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=JobbieDb;Integrated Security=True;TrustServerCertificate=Yes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.DefineRelationships();
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
            string userName = _httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "admin";

            foreach (var entry in entries)
            {
                // for entities that inherit from Audit,
                // set fields appropriately
                if (entry.Entity is Audit trackable)
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
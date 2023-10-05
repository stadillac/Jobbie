using Jobbie.Db.Extensions;
using Jobbie.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Jobbie.Db
{
    public class ApplicationContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        private readonly IHttpContextAccessor? _httpContextAccessor;

        public ApplicationContext() { }

        public ApplicationContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        #region dbsets

        public DbSet<Address> Addresses { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ContractorSoftware> ContractorSoftware { get; set; }
        public DbSet<DeadlineType> DeadlineTypes { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Expertise> Expertises { get; set; }
        public DbSet<Focus> Focuses { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<ProfessionDiscipline> ProfessionDisciplines { get; set; }
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
        public DbSet<StatusUpdate> StatusUpdates { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Set up connection string in appsettings
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=JobbieDb;Integrated Security=True;TrustServerCertificate=Yes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.DefineRelationships();
            modelBuilder.CustomizeUserTableNames();
            base.OnModelCreating(modelBuilder);
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
                if (entry.Entity is BaseEntity trackable)
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
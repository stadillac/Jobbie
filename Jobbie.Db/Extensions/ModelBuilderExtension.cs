using Jobbie.Db.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Jobbie.Db.Extensions
{
    internal static class ModelBuilderExtension
    {
        public static void CustomizeUserTableNames(this ModelBuilder modelBuilder) 
        {
            //this isnt working and its pissing me off. So leaving it for now.
            // its just to change the default table names for identity models, so not super
            // important. come back to this when you get a chance.

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });

            modelBuilder.Entity<IdentityRole<int>>(entity =>
            {
                entity.ToTable(name: "Role");
            });

            modelBuilder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<int>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<int>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityRoleClaim<int>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserToken<int>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }

        public static void DefineRelationships(this ModelBuilder modelBuilder)
        {
            #region User
            modelBuilder.Entity<User>()
                .HasOne(x => x.Address)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(x => x.Contractor)
                .WithOne(x => x.User)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasOne(x => x.Solicitor)
                .WithOne(x => x.User)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(x => x.BankAccount)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(x => x.CompanyType)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(x => x.ContractorReviews)
                .WithOne(x => x.ContractorUser)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(x => x.SolicitorReviews)
                .WithOne(x => x.SolicitorUser)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Address

            modelBuilder.Entity<Address>()
                .HasOne(x => x.State)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Contractor

            modelBuilder.Entity<Contractor>()
                .HasOne(x => x.ProfessionDiscipline)
                .WithMany(x => x.Contractors)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Contractor>()
                .HasMany(x => x.Licenses)
                .WithOne(x => x.Contractor)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region ContractorSoftware

            modelBuilder.Entity<ContractorSoftware>()
                .HasOne(x => x.Contractor)
                .WithMany(x => x.AvailableSoftware)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ContractorSoftware>()
                .HasOne(x => x.Software)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Document

            modelBuilder.Entity<Document>()
                .HasOne(x => x.User)
                .WithMany(x => x.Documents)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Discipline

            modelBuilder.Entity<Discipline>()
                .HasMany(x => x.ProfessionDisciplines)
                .WithOne(x => x.Discipline)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Profession

            modelBuilder.Entity<Profession>()
                .HasMany(x => x.ProfessionDisciplines)
                .WithOne(x => x.Profession)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region License

            modelBuilder.Entity<License>()
                .HasOne(x => x.State)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Review 

            modelBuilder.Entity<Review>()
                .HasOne(x => x.ContractorUser) 
                .WithMany(x => x.ContractorReviews)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Review>()
                .HasOne(x => x.SolicitorUser) 
                .WithMany(x => x.SolicitorReviews)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Solicitation

            modelBuilder.Entity<Solicitation>()
                .HasOne(x => x.Solicitor)
                .WithMany(x => x.Solicitations)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Solicitation>()
                .HasOne(x => x.Deadline)
                .WithOne(x => x.Solicitation)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Solicitation>()
                .HasMany(x => x.Contractors)
                .WithOne(x => x.Solicitation)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region SolicitationContractor

            modelBuilder.Entity<SolicitationContractor>()
                .HasOne(x => x.Contractor)
                .WithMany(x => x.Solicitations)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SolicitationContractor>()
                .HasMany(x => x.StatusUpdates)
                .WithOne(x => x.Contractor)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region SolicitationDeadline

            modelBuilder.Entity<SolicitationDeadline>()
                .HasOne(x => x.DeadlineType)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region SolicitationRole

            modelBuilder.Entity<SolicitationRole>()
                .HasMany(x => x.ProvidedSoftware)
                .WithOne(x => x.SolicitationRole)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SolicitationRole>()
                .HasMany(x => x.RequiredSoftware)
                .WithOne(x => x.SolicitationRole)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Solicitor

            modelBuilder.Entity<Solicitor>()
                .HasMany(x => x.StatusUpdates)
                .WithOne(x => x.Solicitor)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region Specialty

            modelBuilder.Entity<Expertise>()
                .HasOne(x => x.Focus)
                .WithMany(x => x.Expertises)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion
        }
    }
}

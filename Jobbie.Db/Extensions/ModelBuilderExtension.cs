using Jobbie.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Jobbie.Db.Extensions
{
    internal static class ModelBuilderExtension
    {
        public static void DefineRelationships(this ModelBuilder modelBuilder)
        {
            #region Account
            modelBuilder.Entity<Account>()
                .HasOne(x => x.Address)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Account>()
                .HasOne(x => x.Contractor)
                .WithOne(x => x.Account)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .HasOne(x => x.Solicitor)
                .WithOne(x => x.Account)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Account>()
                .HasOne(x => x.BankAccount)
                .WithOne()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Account>()
                .HasOne(x => x.CompanyType)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Account>()
                .HasMany(x => x.ContractorReviews)
                .WithOne(x => x.ContractorAccount)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Account>()
                .HasMany(x => x.SolicitorReviews)
                .WithOne(x => x.SolicitorAccount)
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
                .HasOne(x => x.JobTypeJobSubtype)
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
                .HasOne(x => x.Account)
                .WithMany(x => x.Documents)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region JobSubtype

            modelBuilder.Entity<JobSubtype>()
                .HasMany(x => x.JobTypeJobSubtypes)
                .WithOne(x => x.JobSubtype)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #region JobType

            modelBuilder.Entity<JobType>()
                .HasMany(x => x.JobTypeJobSubtypes)
                .WithOne(x => x.JobType)
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
                .HasOne(x => x.ContractorAccount) 
                .WithMany(x => x.ContractorReviews)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Review>()
                .HasOne(x => x.SolicitorAccount) 
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

            modelBuilder.Entity<Specialty>()
                .HasOne(x => x.JobSubtype)
                .WithMany(x => x.Specialties)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion
        }
    }
}

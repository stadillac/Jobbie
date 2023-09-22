namespace Jobbie.Web.Models
{
    public class AccountViewModel
    {
        public int Id { get; set; }

        public int ContractorId { get; set; }

        public int? SolicitorId { get; set; }

        public int BankAccountId { get; set; }

        public int AddressId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string AboutMe { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public int? CompanyTypeId { get; set; }

        public string EmployerIdentificationNumber { get; set; } = string.Empty;

        public string SocialSecurityNumber { get; set; } = string.Empty;

        public bool IsVerified { get; set; }

        public int HoursAvailablePerWeek { get; set; }

        public int CurrentWorkload { get; set; }

        //public double ContractorRating
        //{
        //    get
        //    {
        //        return ContractorReviews.Average(x => x.Rating);
        //    }
        //}

        //public double SolicitorRating
        //{
        //    get
        //    {
        //        return SolicitorReviews.Average(x => x.Rating);
        //    }
        //}

        //public virtual CompanyType CompanyType { get; set; } = new();

        //public virtual Contractor Contractor { get; set; } = new();

        //public virtual Solicitor? Solicitor { get; set; }

        //public virtual BankAccount BankAccount { get; set; } = new();

        //public virtual Address Address { get; set; } = new();

        //public virtual ICollection<Document> Documents { get; set; } = new Collection<Document>();

        //public virtual ICollection<Review> ContractorReviews { get; set; } = new Collection<Review>();

        //public virtual ICollection<Review> SolicitorReviews { get; set; } = new Collection<Review>();
    }
}

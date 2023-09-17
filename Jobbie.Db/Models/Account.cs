namespace Jobbie.Db.Models
{
    public class Account : Audit
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

        public virtual Contractor Contractor { get; set; } = new();
        public virtual Solicitor? Solicitor { get; set; }
        public virtual BankAccount BankAccount { get; set;} = new();
        public virtual Address Address { get; set; } = new();
    }
}

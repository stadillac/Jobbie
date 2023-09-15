namespace Operations.Entity.EntityModels
{
    public class Account : Audit
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int? SolicitorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public int BankAccountId { get; set; }
        public string AboutMe { get; set; }
    }
}

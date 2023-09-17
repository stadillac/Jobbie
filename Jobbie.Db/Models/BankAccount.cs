namespace Jobbie.Db.Models
{
    public class BankAccount : Audit
    {
        public int Id { get; set; }
        public string BankName { get; set; } = string.Empty;
        public string RoutingNumber { get; set; } = string.Empty;
        public string AccountType { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
    }
}

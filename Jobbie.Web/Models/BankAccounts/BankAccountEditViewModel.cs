namespace Jobbie.Web.Models
{
    public class BankAccountEditViewModel
    {
        public int Id { get; set; }
        public string BankName { get; set; } = string.Empty;
        public string RoutingNumber { get; set; } = string.Empty;
        public string AccountType { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
    }
}

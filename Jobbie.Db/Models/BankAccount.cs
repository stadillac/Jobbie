namespace Operations.Entity.EntityModels
{
    public class BankAccount : Audit
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
    }
}

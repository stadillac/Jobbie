namespace Jobbie.Web.Models
{
    public class SoftwareEditViewModel
    {
        public int Id { get; set; }
        public bool IsSubscription { get; set; }
        public double SubscriptionMonthlyCost { get; set; }
        public double InitialPurchaseCost { get; set; }
    }
}

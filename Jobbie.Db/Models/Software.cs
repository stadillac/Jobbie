namespace Jobbie.Db.Models
{
    public class Software : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is subscription.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is subscription; otherwise, <c>false</c>.
        /// </value>
        public bool IsSubscription { get; set; }

        /// <summary>
        /// Gets or sets the subscription monthly cost.
        /// </summary>
        /// <value>
        /// The subscription montly cost.
        /// </value>
        public double SubscriptionMonthlyCost { get; set; }

        /// <summary>
        /// Gets or sets the initial purchase cost.
        /// </summary>
        /// <value>
        /// The initial purchase cost.
        /// </value>
        /// <remarks>Cost of purchasing software outright</remarks>
        public double InitialPurchaseCost { get; set; }
    }
}

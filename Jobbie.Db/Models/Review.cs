namespace Jobbie.Db.Models
{
    /// <summary>
    /// The review model. 
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class Review : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the contractor account identifier.
        /// </summary>
        /// <value>
        /// The account identifier.
        /// </value>
        /// <remarks>This relates to the account the review is for.</remarks>
        public int? ContractorAccountId { get; set; }

        /// <summary>
        /// Gets or sets the solicitor account identifier.
        /// </summary>
        /// <value>
        /// The solicitor account identifier.
        /// </value>
        public int? SolicitorAccountId { get; set; }

        /// <summary>
        /// Gets or sets the reviewer identifier.
        /// </summary>
        /// <value>
        /// The reviewer identifier.
        /// </value>
        /// <remarks>This relates to the account that created the review.</remarks>
        public int ReviewerId { get; set; }

        /// <summary>
        /// Gets or sets the solicitation role identifier.
        /// </summary>
        /// <value>
        /// The solicitation role identifier.
        /// </value>
        public int SolicitationRoleId { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        /// <remarks>The number rating given to the account for the review. I.E. 1-5 stars, etc.</remarks>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the review.
        /// </summary>
        /// <value>
        /// The review.
        /// </value>
        /// <remarks>The descriptive review left for the account</remarks>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property. Gets or sets the contractor account.
        /// </summary>
        /// <value>
        /// The account.
        /// </value>
        public virtual Account? ContractorAccount { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the solicitor account.
        /// </summary>
        /// <value>
        /// The solicitor account.
        /// </value>
        public virtual Account? SolicitorAccount { get; set; }
    }
}

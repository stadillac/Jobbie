namespace Jobbie.Db.Models
{
    /// <summary>
    /// The status update model. Represents any update
    /// for a solicitation. Can be made by contractor or solicitor.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class StatusUpdate : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the solicitation contractor identifier.
        /// </summary>
        /// <value>
        /// The solicitation contractor identifier.
        /// </value>
        public int? SolicitationContractorId { get; set; }

        /// <summary>
        /// Gets or sets the solicitor identifier.
        /// </summary>
        /// <value>
        /// The solicitor identifier.
        /// </value>
        public int? SolicitorId { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property. Gets or sets the contractor.
        /// </summary>
        /// <value>
        /// The contractor.
        /// </value>
        public virtual SolicitationContractor Contractor { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the solicitor.
        /// </summary>
        /// <value>
        /// The solicitor.
        /// </value>
        public virtual Solicitor Solicitor { get; set; } = new();
    }
}

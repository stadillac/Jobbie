namespace Jobbie.Db.Models
{
    /// <summary>
    /// The solicitation deadline model. 
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class SolicitationDeadline : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the solicitation identifier.
        /// </summary>
        /// <value>
        /// The solicitation identifier.
        /// </value>
        public int SolicitationId { get; set; }

        /// <summary>
        /// Gets or sets the deadline type identifier.
        /// </summary>
        /// <value>
        /// The deadline type identifier.
        /// </value>
        public int DeadlineTypeId { get; set; }

        /// <summary>
        /// Gets or sets the deadline date.
        /// </summary>
        /// <value>
        /// The deadline date.
        /// </value>
        public DateTime DeadlineDate { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the solicitation.
        /// </summary>
        /// <value>
        /// The solicitation.
        /// </value>
        public virtual Solicitation Solicitation { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the type of the deadline.
        /// </summary>
        /// <value>
        /// The type of the deadline.
        /// </value>
        public virtual DeadlineType DeadlineType { get; set; } = new();
    }
}

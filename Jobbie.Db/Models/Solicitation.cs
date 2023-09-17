using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The solicitation model. Represents a job.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class Solicitation : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the solicitor identifier.
        /// </summary>
        /// <value>
        /// The solicitor identifier.
        /// </value>
        public int SolicitorId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the lump sum.
        /// </summary>
        /// <value>
        /// The lump sum.
        /// </value>
        public decimal LumpSum { get; set; }

        /// <summary>
        /// Gets or sets the hourly rate.
        /// </summary>
        /// <value>
        /// The hourly rate.
        /// </value>
        public decimal HourlyRate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is complete.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is complete; otherwise, <c>false</c>.
        /// </value>
        public bool IsComplete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is approved; otherwise, <c>false</c>.
        /// </value>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is cancelled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is cancelled; otherwise, <c>false</c>.
        /// </value>
        public bool IsCancelled { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the solicitor.
        /// </summary>
        /// <value>
        /// The solicitor.
        /// </value>
        public virtual Solicitor Solicitor { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the deadline.
        /// </summary>
        /// <value>
        /// The deadline.
        /// </value>
        public virtual SolicitationDeadline Deadline { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the contractors.
        /// </summary>
        /// <value>
        /// The contractors.
        /// </value>
        public virtual ICollection<SolicitationContractor> Contractors { get; set; } = new Collection<SolicitationContractor>();
    }
}

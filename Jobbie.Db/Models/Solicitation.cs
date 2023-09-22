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
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        /// <remarks>This is true when a project has filled the required Roles needed,
        /// and all Contractors and the Solicitor have accepted the StartDate</remarks>
        public bool IsActive { get; set; }

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
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        public string County { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the shared drive URL.
        /// </summary>
        /// <value>
        /// The shared drive URL.
        /// </value>
        public string SharedDriveUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the estimated end date.
        /// </summary>
        /// <value>
        /// The estimated end date.
        /// </value>
        public DateTime EstimatedEndDate { get; set; }

        /// <summary>
        /// Gets or sets the team meeting time.
        /// </summary>
        /// <value>
        /// The team meeting time.
        /// </value>
        public DateTime TeamMeetingTime { get; set; }

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

        /// <summary>
        /// Navigational property. Gets or sets the roles.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        /// <remarks>The required roles for the solicitation.</remarks>
        public virtual ICollection<SolicitationRole> Roles { get; set; } = new Collection<SolicitationRole>();
    }
}

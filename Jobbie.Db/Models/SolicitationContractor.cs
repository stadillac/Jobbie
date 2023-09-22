using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The solicitation contractor model. Represents relationship
    /// between contractor and soliciation.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class SolicitationContractor : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the contractor identifier.
        /// </summary>
        /// <value>
        /// The contractor identifier.
        /// </value>
        public int ContractorId { get; set; }

        /// <summary>
        /// Gets or sets the solicitation identifier.
        /// </summary>
        /// <value>
        /// The solicitation identifier.
        /// </value>
        public int SolicitationId { get; set; }

        /// <summary>
        /// Gets or sets the solicitation role identifier.
        /// </summary>
        /// <value>
        /// The solicitation role identifier.
        /// </value>
        public int SolicitationRoleId { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the contractor.
        /// </summary>
        /// <value>
        /// The contractor.
        /// </value>
        public virtual Contractor? Contractor { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the solicitation.
        /// </summary>
        /// <value>
        /// The solicitation.
        /// </value>
        public virtual Solicitation? Solicitation { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the solicitation role.
        /// </summary>
        /// <value>
        /// The solicitation role.
        /// </value>
        public virtual SolicitationRole? SolicitationRole { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the status updates.
        /// </summary>
        /// <value>
        /// The status updates.
        /// </value>
        public virtual ICollection<StatusUpdate> StatusUpdates { get; set; } = new Collection<StatusUpdate>();
    }
}

using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The contractor model.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class Contractor : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the job type job subtype identifier.
        /// </summary>
        /// <value>
        /// The job type job subtype identifier.
        /// </value>
        public int JobTypeJobSubtypeId { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the job type job subtype.
        /// </summary>
        /// <value>
        /// The job type job subtype.
        /// </value>
        public virtual JobTypeJobSubtype? JobTypeJobSubtype { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the account.
        /// </summary>
        /// <value>
        /// The account.
        /// </value>
        public virtual Account? Account { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the licenses.
        /// </summary>
        /// <value>
        /// The licenses.
        /// </value>
        public virtual ICollection<License> Licenses { get; set; } = new Collection<License>();

        /// <summary>
        /// Navigational property. Gets or sets the solicitations.
        /// </summary>
        /// <value>
        /// The solicitations.
        /// </value>
        public virtual ICollection<SolicitationContractor> Solicitations { get; set; } = new Collection<SolicitationContractor>();

        /// <summary>
        /// Gets or sets the available software the contractor can use.
        /// </summary>
        /// <value>
        /// The available software.
        /// </value>
        public virtual ICollection<ContractorSoftware> AvailableSoftware { get; set; } = new Collection<ContractorSoftware>();
    }
}

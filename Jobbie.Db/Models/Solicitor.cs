using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The solicitor model. Represents anyone posting a job.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.BaseEntity" />
    public class Solicitor : BaseEntity
    {
        /// <summary>
        /// Navigational property. Gets or sets the account.
        /// </summary>
        /// <value>
        /// The account.
        /// </value>
        public virtual User? User { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the solicitations.
        /// </summary>
        /// <value>
        /// The solicitations.
        /// </value>
        public virtual ICollection<Solicitation> Solicitations { get; set;} = new Collection<Solicitation>();

        /// <summary>
        /// Navigational property. Gets or sets the status updates.
        /// </summary>
        /// <value>
        /// The status updates.
        /// </value>
        public virtual ICollection<StatusUpdate> StatusUpdates { get; set; } = new Collection<StatusUpdate>();
    }
}

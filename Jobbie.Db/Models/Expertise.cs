using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The specialty model. Represents any specialty
    /// that a job sub type may have.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class Expertise : Audit
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
        /// Gets or sets the job subtype identifier.
        /// </summary>
        /// <value>
        /// The job subtype identifier.
        /// </value>
        public int FocusId { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the job subtype.
        /// </summary>
        /// <value>
        /// The job subtype.
        /// </value>
        public virtual Focus? Focus { get; set; }

        public virtual ICollection<Specialty> Specialties { get; set; } = new Collection<Specialty>();
    }
}

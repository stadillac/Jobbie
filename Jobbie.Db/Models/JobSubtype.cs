using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The job sub type model.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class JobSubtype : Audit
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
        /// Gets or sets a value indicating whether this instance has specialty.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has specialty; otherwise, <c>false</c>.
        /// </value>
        public bool HasSpecialty { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the job type job subtypes.
        /// </summary>
        /// <value>
        /// The job type job subtypes.
        /// </value>
        public virtual ICollection<JobTypeJobSubtype> JobTypeJobSubtypes { get; set; } = new Collection<JobTypeJobSubtype>();

        /// <summary>
        /// Navigational property. Gets or sets the specialties.
        /// </summary>
        /// <value>
        /// The specialties.
        /// </value>
        public virtual ICollection<Specialty> Specialties { get; set; } = new Collection<Specialty>();
    }
}

using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The job type job sub type model. Represents relationship between
    /// job type and job sub type.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class ProfessionDiscipline : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the job type identifier.
        /// </summary>
        /// <value>
        /// The job type identifier.
        /// </value>
        public int ProfessionId { get; set; }

        /// <summary>
        /// Gets or sets the job subtype identifier.
        /// </summary>
        /// <value>
        /// The job subtype identifier.
        /// </value>
        public int DisciplineId { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the type of the job.
        /// </summary>
        /// <value>
        /// The type of the job.
        /// </value>
        public virtual Profession? Profession { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the job subtype.
        /// </summary>
        /// <value>
        /// The job subtype.
        /// </value>
        public virtual Discipline? Discipline { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the contractors.
        /// </summary>
        /// <value>
        /// The contractors.
        /// </value>
        public virtual ICollection<Contractor> Contractors { get; set; } = new Collection<Contractor>();
    }
}

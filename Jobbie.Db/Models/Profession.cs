using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The profession model.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class Profession : Audit
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
        /// Gets or sets a value indicating whether this instance has subtype.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has subtype; otherwise, <c>false</c>.
        /// </value>
        public bool HasSubtype { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has license.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has license; otherwise, <c>false</c>.
        /// </value>
        public bool HasLicense { get; set; }

        public virtual ProfessionDiscipline? ProfessionDiscipline { get; set; }
    }
}

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
    }
}

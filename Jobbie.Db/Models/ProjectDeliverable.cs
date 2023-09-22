namespace Jobbie.Db.Models
{
    /// <summary>
    /// The project deliverable. Represents the expected
    /// result for a solicitation role.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class ProjectDeliverable : Audit
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
        /// Gets or sets the file format.
        /// </summary>
        /// <value>
        /// The file format.
        /// </value>
        public string FileFormat { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; } = string.Empty;
    }
}

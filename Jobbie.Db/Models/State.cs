namespace Jobbie.Db.Models
{
    /// <summary>
    /// The state model.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class State : Audit
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
        /// Gets or sets the abbreviation.
        /// </summary>
        /// <value>
        /// The abbreviation.
        /// </value>
        public string Abbreviation { get; set; } = string.Empty;
    }
}

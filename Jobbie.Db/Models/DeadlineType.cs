namespace Jobbie.Db.Models
{
    /// <summary>
    /// The deadline type model.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.BaseEntity" />
    public class DeadlineType : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;
    }
}

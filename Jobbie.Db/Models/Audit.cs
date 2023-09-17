namespace Jobbie.Db.Models
{
    /// <summary>
    /// The audit model. Used to keep track of record
    /// creation and modification.
    /// </summary>
    public class Audit
    {
        /// <summary>
        /// Gets or sets who created the record.
        /// </summary>
        /// <value>
        /// The user who created the record.
        /// </value>
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets who modified the record.
        /// </summary>
        /// <value>
        /// The user who last modified the record.
        /// </value>
        public string ModifiedBy { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
        /// </value>
        public bool IsDeleted { get; set; }
    }
}

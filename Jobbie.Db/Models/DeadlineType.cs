﻿namespace Jobbie.Db.Models
{
    /// <summary>
    /// The deadline type model.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class DeadlineType : Audit
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
    }
}

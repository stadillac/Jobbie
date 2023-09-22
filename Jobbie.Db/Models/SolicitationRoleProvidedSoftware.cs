﻿namespace Jobbie.Db.Models
{
    /// <summary>
    /// The solicitation role provided software. Represents
    /// the software that will be provided for use for a specific
    /// solicitation role.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class SolicitationRoleProvidedSoftware : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the solicitation role identifier.
        /// </summary>
        /// <value>
        /// The solicitation role identifier.
        /// </value>
        public int SolicitationRoleId { get; set; }

        /// <summary>
        /// Gets or sets the software identifier.
        /// </summary>
        /// <value>
        /// The software identifier.
        /// </value>
        public int SoftwareId { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the solicitation role.
        /// </summary>
        /// <value>
        /// The solicitation role.
        /// </value>
        public virtual SolicitationRole SolicitationRole { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the software.
        /// </summary>
        /// <value>
        /// The software.
        /// </value>
        public virtual Software Software { get; set; } = new();
    }
}

﻿using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The discipline model. Think "I am a CIVIL engineer" or
    /// "I am a SOFTWARE engineer"
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.BaseEntity" />
    public class Discipline : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property. Gets or sets the Focus.
        /// </summary>
        /// <value>
        /// The Focus.
        /// </value>
        public virtual Focus? Focus { get; set; }

        /// <summary>
        /// Navgiational property. Gets or sets the profession disciplines.
        /// </summary>
        /// <value>
        /// The profession disciplines.
        /// </value>
        public virtual ICollection<ProfessionDiscipline> ProfessionDisciplines { get; set; } = new Collection<ProfessionDiscipline>();
    }
}

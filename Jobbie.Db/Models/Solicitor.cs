using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The solicitor model. Represents anyone posting a job.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class Solicitor : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the company type identifier.
        /// </summary>
        /// <value>
        /// The company type identifier.
        /// </value>
        public int CompanyTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property. Gets or sets the account.
        /// </summary>
        /// <value>
        /// The account.
        /// </value>
        public virtual Account Account { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the type of the company.
        /// </summary>
        /// <value>
        /// The type of the company.
        /// </value>
        public virtual CompanyType CompanyType { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the solicitations.
        /// </summary>
        /// <value>
        /// The solicitations.
        /// </value>
        public virtual ICollection<Solicitation> Solicitations { get; set;} = new Collection<Solicitation>();
    }
}

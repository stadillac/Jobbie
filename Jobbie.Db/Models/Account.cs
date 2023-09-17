using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    /// <summary>
    /// The account model. An account must have a contractor related to it,
    /// but can also have a solicitor record. I.E a user must be a contractor,
    /// but can also hire/create jobs.
    /// </summary>
    /// <seealso cref="Jobbie.Db.Models.Audit" />
    public class Account : Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the contractor identifier.
        /// </summary>
        /// <value>
        /// The contractor identifier.
        /// </value>
        public int ContractorId { get; set; }

        /// <summary>
        /// Gets or sets the solicitor identifier.
        /// </summary>
        /// <value>
        /// The solicitor identifier.
        /// </value>
        public int? SolicitorId { get; set; }

        /// <summary>
        /// Gets or sets the bank account identifier.
        /// </summary>
        /// <value>
        /// The bank account identifier.
        /// </value>
        public int BankAccountId { get; set; }

        /// <summary>
        /// Gets or sets the address identifier.
        /// </summary>
        /// <value>
        /// The address identifier.
        /// </value>
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the about me.
        /// </summary>
        /// <value>
        /// The about me.
        /// </value>
        public string AboutMe { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property. Gets or sets the contractor.
        /// </summary>
        /// <value>
        /// The contractor.
        /// </value>
        public virtual Contractor Contractor { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the solicitor.
        /// </summary>
        /// <value>
        /// The solicitor.
        /// </value>
        public virtual Solicitor? Solicitor { get; set; }

        /// <summary>
        /// Navigational property. Gets or sets the bank account.
        /// </summary>
        /// <value>
        /// The bank account.
        /// </value>
        public virtual BankAccount BankAccount { get; set;} = new();

        /// <summary>
        /// Navigational property. Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public virtual Address Address { get; set; } = new();

        /// <summary>
        /// Navigational property. Gets or sets the documents.
        /// </summary>
        /// <value>
        /// The documents.
        /// </value>
        public virtual ICollection<Document> Documents { get; set; } = new Collection<Document>();
    }
}

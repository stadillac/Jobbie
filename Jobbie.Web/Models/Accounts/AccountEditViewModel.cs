using Jobbie.Db.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jobbie.Web.Models
{
    public class AccountEditViewModel
    {
        public int Id { get; set; }


        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;


        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DisplayName("About Me")]
        public string AboutMe { get; set; } = string.Empty;

        [Required]
        [DisplayName("Phone")]
        public string PhoneNumber { get; set; } = string.Empty;

        // todo requires dropdown
        public int ContractorId { get; set; }

        // todo requires dropdown
        public int? SolicitorId { get; set; }

        
        public string Username { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public int? CompanyTypeId { get; set; }
        public string EmployerIdentificationNumber { get; set; } = string.Empty;
        public string SocialSecurityNumber { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
        public int HoursAvailablePerWeek { get; set; }
        public int CurrentWorkload { get; set; }

        // todo these will essentially be sub forms that appear on the edit form
        // we will have to implement special logic when saving
        public BankAccountEditViewModel BankAccount { get; set; } = new();
        public AddressEditViewModel Address { get; set; } = new();
    }
}

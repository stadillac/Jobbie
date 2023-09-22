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

        // TODO Add other properties that need to be editable
    }
}

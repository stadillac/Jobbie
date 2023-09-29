using Jobbie.Db.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;

namespace Jobbie.Web.Models
{
    public class AddressEditViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Address1 { get; set; } = string.Empty;

        [Required]
        public string Address2 { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string ZipCode { get; set; } = string.Empty;

        [Required]
        public string? Country { get; set; }

        [Required]
        public int StateId { get; set; }
        public SelectList? States { get; set; }
    }
}

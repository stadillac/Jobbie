using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Jobbie.Web.Models
{
    public class SpecialtyEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [DisplayName("Expertise")]
        public int ExpertiseId { get; set; }
        public SelectList? Expertises { get; set; }
    }
}

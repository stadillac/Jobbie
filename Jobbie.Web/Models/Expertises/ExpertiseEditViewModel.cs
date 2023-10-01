using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Jobbie.Web.Models
{
    public class ExpertiseEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [DisplayName("Focus")]
        public int FocusId { get; set; }
        public SelectList? Focuses { get; set; }

    }
}

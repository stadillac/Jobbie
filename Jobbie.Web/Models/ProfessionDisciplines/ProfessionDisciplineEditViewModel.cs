using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Jobbie.Web.Models
{
    public class ProfessionDisciplineEditViewModel
    {
        public int Id { get; set; }
        public int ProfessionId { get; set; }
        public int DisciplineId { get; set; }

        [DisplayName("Profession")]
        public SelectList? Professions { get; set; }

        [DisplayName("Discipline")]
        public SelectList? Disciplines { get; set; }
    }
}

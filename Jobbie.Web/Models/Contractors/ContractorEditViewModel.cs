using Jobbie.Db.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Jobbie.Web.Models
{
    public class ContractorEditViewModel
    {
        public int Id { get; set; }

        //public int ProfessionDisciplineId { get; set; }
        //public ProfessionDiscipline? ProfessionDiscipline { get; set; }
        public int ProfessionId { get; set; }
        public int DisciplineId { get; set; }
        public ProfessionDisciplineEditViewModel ProfessionDiscipline { get; set; } = new();
        public AccountEditViewModel? Account { get; set; }
        //public List<LicenseEditViewModel> Licenses { get; set; } = new List<LicenseEditViewModel>(); // TODO
        //public List<SolicitationContractorViewModel> Solicitations { get; set; } = new List<SolicitationContractorViewModel>(); // TODO
        public List<SoftwareViewModel> AvailableSoftware { get; set; } = new List<SoftwareViewModel>();

        [DisplayName("Profession")]
        public SelectList? Professions { get; set; }

        [DisplayName("Discipline")]
        public SelectList? Disciplines { get; set; }
    }
}

using Jobbie.Db.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Jobbie.Web.Models
{
    public class ContractorEditViewModel
    {
        public int Id { get; set; }

        public int ProfessionDisciplineId { get; set; }
        public AccountEditViewModel? Account { get; set; }

        [DisplayName("Profession")]
        public SelectList? ProfessionDisciplines { get; set; }

        public List<LicenseEditViewModel> Licenses { get; set; } = new List<LicenseEditViewModel>(); // TODO
        public List<SolicitationContractorViewModel> Solicitations { get; set; } = new List<SolicitationContractorViewModel>(); // TODO
        public List<SoftwareViewModel> AvailableSoftware { get; set; } = new List<SoftwareViewModel>();
    }
}

using System.Collections.ObjectModel;

namespace Jobbie.Web.Models
{
    public class ContractorViewModel
    {
        public int Id { get; set; }
        public int JobTypeJobSubtypeId { get; set; }
        //public JobTypeJobSubtypeViewModel? JobTypeJobSubtype { get; set; } // TODO
        public AccountViewModel? Account { get; set; }
        public ICollection<LicenseViewModel> Licenses { get; set; } = new Collection<LicenseViewModel>();
        public ICollection<SolicitationContractorViewModel> Solicitations { get; set; } = new Collection<SolicitationContractorViewModel>();

        // todo flatten this so we dont have a view model for contractorSoftware
        public ICollection<SoftwareViewModel> AvailableSoftware { get; set; } = new Collection<SoftwareViewModel>();
    }
}

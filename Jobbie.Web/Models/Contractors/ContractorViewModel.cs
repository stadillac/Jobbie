using System.Collections.ObjectModel;

namespace Jobbie.Web.Models
{
    public class ContractorViewModel
    {
        public int Id { get; set; }
        public int JobTypeJobSubtypeId { get; set; }
        public AccountViewModel? Account { get; set; }
        public ICollection<LicenseViewModel> Licenses { get; set; } = new Collection<LicenseViewModel>();
        public ICollection<SolicitationContractorViewModel> Solicitations { get; set; } = new Collection<SolicitationContractorViewModel>();
        public ICollection<SoftwareViewModel> AvailableSoftware { get; set; } = new Collection<SoftwareViewModel>();
    }
}

using System.Collections.ObjectModel;

namespace Jobbie.Web.Models
{
    public class SolicitationContractorViewModel
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int SolicitationId { get; set; }
        public int SolicitationRoleId { get; set; }
        public ContractorViewModel? Contractor { get; set; }
        public SolicitationViewModel? Solicitation { get; set; }
        public SolicitationRoleViewModel? SolicitationRole { get; set; }
        public ICollection<StatusUpdateViewModel> StatusUpdates { get; set; } = new Collection<StatusUpdateViewModel>();
    }
}

using System.Collections.ObjectModel;

namespace Jobbie.Web.Models
{
    public class SolicitorViewModel
    {
        public int Id { get; set; }
        public AccountViewModel? Account { get; set; }
        public ICollection<SolicitationViewModel> Solicitations { get; set; } = new Collection<SolicitationViewModel>();
        public ICollection<StatusUpdateViewModel> StatusUpdates { get; set; } = new Collection<StatusUpdateViewModel>();
    }
}

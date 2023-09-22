using Jobbie.Db.Models;

namespace Jobbie.Web.Models
{
    public class StatusUpdateViewModel
    {
        public int Id { get; set; }
        public int? SolicitationContractorId { get; set; }
        public int? SolicitorId { get; set; }
        public string Status { get; set; } = string.Empty;
        public virtual SolicitationContractorViewModel? Contractor { get; set; }
        public virtual SolicitorViewModel? Solicitor { get; set; }
    }
}

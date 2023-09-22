using Jobbie.Db.Models;
using System.Collections.ObjectModel;

namespace Jobbie.Web.Models
{
    public class SolicitationViewModel
    {
        public int Id { get; set; }
        public int SolicitorId { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public bool IsComplete { get; set; }
        public bool IsApproved { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; } = string.Empty;
        public string County { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string SharedDriveUrl { get; set; } = string.Empty;
        public DateTime EstimatedEndDate { get; set; }
        public DateTime TeamMeetingTime { get; set; }
        public SolicitorViewModel? Solicitor { get; set; }
        public virtual ICollection<SolicitationContractor> Contractors { get; set; } = new Collection<SolicitationContractor>();
        public virtual ICollection<SolicitationRole> Roles { get; set; } = new Collection<SolicitationRole>();
        public DeadlineTypeViewModel? DeadlineType { get; set; } // flatten with automapper profile
    }
}

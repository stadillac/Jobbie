﻿using Jobbie.Db.Models;
using System.Collections.ObjectModel;

namespace Jobbie.Web.Models
{
    public class SolicitationRoleViewModel
    {
        public int Id { get; set; }
        public int SolicitationId { get; set; }
        public int ProjectDeliverableId { get; set; }
        public bool HasContractor { get; set; }
        public bool IsComplete { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
        public double LumpSum { get; set; }
        public double HourlyRate { get; set; }
        public double SignBonus { get; set; }
        public double Workload { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DeliverableDeadline { get; set; }
        public bool ContractorTerminated { get; set; }
        public bool ContractorPaid { get; set; }
        public SolicitationViewModel? Solicitation { get; set; }
        public ProjectDeliverableViewModel? ProjectDeliverable { get; set; }
        public virtual ICollection<ReviewViewModel> Reviews { get; set; } = new Collection<ReviewViewModel>();
        public virtual ICollection<SoftwareViewModel> RequiredSoftware { get; set; } = new Collection<SoftwareViewModel>();
        public virtual ICollection<SoftwareViewModel> ProvidedSoftware { get; set; } = new Collection<SoftwareViewModel>();
    }
}

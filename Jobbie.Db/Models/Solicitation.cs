using System;
using System.Collections.ObjectModel;

namespace Jobbie.Db.Models
{
    public class Solicitation : Audit
    {
        public int Id { get; set; }
        public int SolicitorId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal LumpSum { get; set; }
        public decimal HourlyRate { get; set; }
        public bool IsComplete { get; set; }
        public bool IsApproved { get; set; }
        public bool IsCancelled { get; set; }

        public virtual Solicitor Solicitor { get; set; } = new();
        public virtual SolicitationDeadline Deadline { get; set; } = new();
        public virtual ICollection<SolicitationContractor> Contractors { get; set; } = new Collection<SolicitationContractor>();
    }
}

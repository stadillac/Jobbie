namespace Jobbie.Web.Models
{
    public class SolicitationRoleEditViewModel
    {
        public int Id { get; set; }
        public double LumpSum { get; set; }
        public double HourlyRate { get; set; }
        public double SignBonus { get; set; }
        public double Workload { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DeliverableDeadline { get; set; }
        public bool ContractorTerminated { get; set; }
        public bool ContractorPaid { get; set; }
    }
}

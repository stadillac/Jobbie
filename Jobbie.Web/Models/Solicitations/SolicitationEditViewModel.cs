namespace Jobbie.Web.Models
{
    public class SolicitationEditViewModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; } = string.Empty;
        public string County { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string SharedDriveUrl { get; set; } = string.Empty;
        public DateTime EstimatedEndDate { get; set; }
        public DateTime TeamMeetingTime { get; set; }
    }
}

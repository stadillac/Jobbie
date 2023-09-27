namespace Jobbie.Web.Models
{
    public class ProjectDeliverableEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FileFormat { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}

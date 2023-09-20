namespace Jobbie.Db.Models
{
    public class ProjectDeliverable
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FileFormat { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}

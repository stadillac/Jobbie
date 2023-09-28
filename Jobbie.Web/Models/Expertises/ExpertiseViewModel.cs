namespace Jobbie.Web.Models
{
    public class ExpertiseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int FocusId { get; set; }
        public FocusViewModel? Focus { get; set; }
    }
}

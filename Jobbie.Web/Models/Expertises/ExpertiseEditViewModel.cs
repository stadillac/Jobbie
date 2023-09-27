namespace Jobbie.Web.Models
{
    public class ExpertiseEditViewModel
    {
        public int Id { get; set; }
        // todo will need a dropdown
        public int FocusId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}

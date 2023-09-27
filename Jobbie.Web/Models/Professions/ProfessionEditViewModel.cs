namespace Jobbie.Web.Models
{
    public class ProfessionEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool HasLicense { get; set; }
    }
}

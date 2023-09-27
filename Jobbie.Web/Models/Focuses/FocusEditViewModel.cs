namespace Jobbie.Web.Models
{
    public class FocusEditViewModel
    {
        public int Id { get; set; }
        //todo will need a dropdown
        public int DisciplineId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}

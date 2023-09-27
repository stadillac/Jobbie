namespace Jobbie.Web.Models
{
    public class LicenseEditViewModel
    {
        public int Id { get; set; }

        // todo this will need a dropdown
        public int StateId { get; set; }

        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public bool IsVerified { get; set; }
        public string LicenseNumber { get; set; } = string.Empty;
    }
}

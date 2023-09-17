namespace Jobbie.Db.Models
{
    public class JobType : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool HasSubtype { get; set; }
        public bool HasLicense { get; set; }
    }
}

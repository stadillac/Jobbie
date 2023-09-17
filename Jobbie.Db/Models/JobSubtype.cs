namespace Jobbie.Db.Models
{
    public class JobSubtype : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool HasSpecialty { get; set; }
    }
}

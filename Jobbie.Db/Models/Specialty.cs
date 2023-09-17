namespace Jobbie.Db.Models
{
    public class Specialty : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int JobSubtypeId { get; set; }

        public virtual JobSubtype JobSubtype { get; set; } = new();
    }
}

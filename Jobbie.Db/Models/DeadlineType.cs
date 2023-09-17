namespace Jobbie.Db.Models
{
    public class DeadlineType : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}

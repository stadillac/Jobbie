namespace Jobbie.Db.Models
{
    public class Solicitor : Audit
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;

        public virtual Account Account { get; set; } = new();
    }
}

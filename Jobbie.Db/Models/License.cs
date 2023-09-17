namespace Jobbie.Db.Models
{
    public class License : Audit
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int StateId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public string GovernmentId { get; set; } = string.Empty;

        public virtual Contractor Contractor { get; set; } = new();
        public virtual State State { get; set; } = new();
    }
}

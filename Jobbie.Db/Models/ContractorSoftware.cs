namespace Jobbie.Db.Models
{
    public class ContractorSoftware : Audit
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int SoftwareId { get; set; }

        public virtual Contractor Contractor { get; set; } = new Contractor();
        public virtual Software Software { get; set; } = new Software();
    }
}

namespace Jobbie.Db.Models
{
    public class Audit
    {
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}

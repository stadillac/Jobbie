namespace Jobbie.Db.Models
{
    public class Address : Audit
    {
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int StateId { get; set; }
        public string ZipCode { get; set; } = string.Empty;

        public virtual State State { get; set; } = new();
    }
}

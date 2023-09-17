namespace Jobbie.Db.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int AccountId {get;set;}

        public virtual Account Account { get; set; } = new();
    }
}

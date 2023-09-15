namespace Operations.Entity.EntityModels
{
    public class JobType : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasSubtype { get; set; }
        public bool HasLicense { get; set; }
    }
}

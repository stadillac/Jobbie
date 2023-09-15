namespace Operations.Entity.EntityModels
{
    public class License : Audit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public int Level { get; set; }
        public string GovernmentId { get; set; }
        public int ContractorId { get; set; }
    }
}

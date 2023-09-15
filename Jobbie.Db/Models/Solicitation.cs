using System;

namespace Operations.Entity.EntityModels
{
    public class Solicitation : Audit
    {
        public int Id { get; set; }
        public int SolicitorId { get; set; }
        public string Description { get; set; }
        public decimal LumpSum { get; set; }
        public decimal HourlyRate { get; set; }
        public bool IsComplete { get; set; }
        public bool IsApproved { get; set; }
    }
}

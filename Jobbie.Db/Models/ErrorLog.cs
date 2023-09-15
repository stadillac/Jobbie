using System;

namespace Operations.Entity.EntityModels
{
    public class ErrorLog
    {
        public Guid ErrorLogId { get; set; }
        public string ErrorLocation { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime ErrorDate { get; set; }
    }
}

using System;

namespace Jobbie.Db.Models
{
    public class ErrorLog
    {
        public Guid ErrorLogId { get; set; }
        public string ErrorLocation { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;
        public DateTime ErrorDate { get; set; }
    }
}

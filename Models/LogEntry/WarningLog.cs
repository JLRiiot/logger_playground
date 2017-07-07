using System;

namespace ImBack.Models
{
    public class WarningLog : LogEntry
    {
        public override string Type
        {
            get => "WARNING";
        }

        public WarningLog(string message, string details, DateTime logDate) : base(message, details, logDate)
        {
            
        }

        public WarningLog(string message, DateTime logDate) : base(message, logDate)
        {
        }
    }
}

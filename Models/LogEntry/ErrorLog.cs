using System;

namespace ImBack.Models
{
    public class ErrorLog : LogEntry
    {
        public override string Type
        {
            get => "ERROR";
        }

        public ErrorLog(string message, string details, DateTime logdate) : base(message, details, logdate)
        {
        }
    }
}

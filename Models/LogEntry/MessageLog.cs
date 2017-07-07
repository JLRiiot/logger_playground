using System;

namespace ImBack.Models
{
    public class MessageLog : LogEntry
    {
        public override string Type
        {
            get => "MESSAGE";
        }

        public MessageLog(string message, string details, DateTime logdate) : base(message, details, logdate)
        {
        }

        public MessageLog(string message, DateTime logDate) : base(message, logDate)
        {
        }
    }
}

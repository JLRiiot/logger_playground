using System;
using Newtonsoft.Json;

namespace ImBack.Models
{
    public class LogEntry
    {
        private DateTime _date;
        private String _message;
        private LogType _type;

        public String Date
        {
            get => _date.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public String Type
        {
            get => _type.ToString();
        }
        public string Message 
        {
            get => _message;
        }

        public LogEntry(String message, LogType type)
        {
            this._message = message;
            this._type = type;
            this._date = DateTime.Now;
        }

        public String Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

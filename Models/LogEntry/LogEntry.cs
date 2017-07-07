﻿using System;
using Newtonsoft.Json;

namespace ImBack.Models
{
    public abstract class LogEntry
    {
        protected DateTime _date;
		protected String _message;
        protected String _details;

        public String Date
        {
            get => _date.ToString("yyyy-MM-dd hh:mm:ss");
		}

		public abstract String Type { get; }

        public string Message 
        {
            get => _message;
        }

        public string Details
        {
            get => _details;
        }

        protected LogEntry(string message, DateTime logDate)
        {
            this._message = message;
            this._date = logDate;
        }

        protected LogEntry(String message, String details, DateTime logDate)
        {
            this._message = message;
            this._date = logDate;
            this._details = details;
        }

        public String ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

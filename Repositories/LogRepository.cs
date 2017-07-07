using System;
using System.Collections.Generic;

using ImBack.Models;

namespace ImBack.Repositories
{
    public abstract class LogRepository
    {
        protected HashSet<String> _vervosity;

        protected LogRepository(HashSet<String> verbosity)
        {
            this._vervosity = verbosity;
        }

        public String WriteLog(LogEntry logEntry)
        {
            String line = String.Empty;
            if (this._vervosity.Contains(logEntry.Type) 
                && !String.IsNullOrEmpty(logEntry.Message))
            {
                line = this.Log(logEntry);
            }

            return line;
        }

        protected abstract String Log(LogEntry logEntry);
    }
}
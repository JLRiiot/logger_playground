using System;
using System.Collections.Generic;

using ImBack.Models;

namespace ImBack.Repositories
{
    public class DatabaseLog : LogRepository
    {
        public DatabaseLog(HashSet<string> verbosity) : base(verbosity)
        {
        }

        protected override string Log(LogEntry logEntry)
        {
            throw new NotImplementedException();
        }
    }
}

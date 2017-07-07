using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

using ImBack.Models;

namespace ImBack.Repositories
{
    public class FileSystemLog : LogRepository
    {
        private System.PlatformID _platform;
        private String _logPath = String.Empty;

        public FileSystemLog(HashSet<string> verbosity) : base(verbosity)
        {
			this._platform = Environment.OSVersion.Platform;
			this._logPath = System.Reflection.Assembly.GetExecutingAssembly().Location + ".log";
        }

        protected override string Log(LogEntry logEntry)
        {
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(this._logPath, true))
            {
                String line = logEntry.ToJSON();
                file.WriteLine(line);

                return line;
            }
        }
    }
}

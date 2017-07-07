using System;
using System.Configuration;
using System.Text;

using ImBack.Contracts;
using ImBack.Models;

namespace ImBack.Repositories
{
    public class FileSystem : ILogPersistable
    {
        private System.PlatformID _platform;
        private String _logPath = String.Empty;

        public FileSystem()
        {
            this._platform = Environment.OSVersion.Platform;
            this._logPath = System.Reflection.Assembly.GetExecutingAssembly().Location + ".log";
        }

        private void WriteLine(String line)
        {
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(this._logPath, true))
            {
                file.WriteLine(line);
            }
        }

        public void WirteWarning(string warning)
        {
			LogEntry entry = new LogEntry(warning, LogType.Warning);
            this.WriteLine(entry.Serialize());
        }

        public void WriteError(string error)
		{
			LogEntry entry = new LogEntry(error, LogType.Error);
			this.WriteLine(entry.Serialize());
        }

        public void WriteMessage(string message)
		{
            LogEntry entry = new LogEntry(message, LogType.Info);
			this.WriteLine(entry.Serialize());
        }
    }
}

using System;
using System.Configuration;
using System.Text;

using ImBack.Contracts;

namespace ImBack.Repositories
{
    public class FileSystem : ILogPersistable
    {
        private System.PlatformID _platform;
        private String _logPath = String.Empty;
        private StringBuilder _sb;

        public FileSystem()
        {
            this._platform = Environment.OSVersion.Platform;
            this._logPath = System.Reflection.Assembly.GetExecutingAssembly().Location + ".log";
            this._sb = new StringBuilder();
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
            this._sb.Clear();
            this._sb.AppendFormat("{0:u} WARNING {1}", DateTime.Now, warning);
            this.WriteLine(this._sb.ToString());
        }

        public void WriteError(string error)
		{
			this._sb.Clear();
			this._sb.AppendFormat("{0:u} ERROR {1}", DateTime.Now, error);
			this.WriteLine(this._sb.ToString());
        }

        public void WriteMessage(string message)
		{
			this._sb.Clear();
			this._sb.AppendFormat("{0:u} INFO {1}", DateTime.Now, message);
			this.WriteLine(this._sb.ToString());
        }
    }
}

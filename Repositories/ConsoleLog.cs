using System;
using System.Collections.Generic;

using ImBack.Models;

namespace ImBack.Repositories
{
    public class ConsoleLog : LogRepository
    {
        private Dictionary<String, ConsoleColor> _colorCodes = new Dictionary<string, ConsoleColor>();

        public ConsoleLog(HashSet<string> verbosity) : base(verbosity)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this._colorCodes.Add("ERROR", ConsoleColor.Red);
            this._colorCodes.Add("WARNING", ConsoleColor.Yellow);
            this._colorCodes.Add("MESSAGE", ConsoleColor.Blue);
        }

        protected override string Log(LogEntry logEntry)
        {
            this.SetConsoleForegroundColor(logEntry.Type);
            String line = logEntry.ToJSON();
            Console.WriteLine(line);

            return line;
        }

        private void SetConsoleForegroundColor(string type)
        {
            Console.ForegroundColor = this._colorCodes[type];
        }
    }
}

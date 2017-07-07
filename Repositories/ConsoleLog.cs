using System;
using ImBack.Contracts;
using ImBack.Models;

namespace ImBack.Repositories
{
    public class ConsoleLog : ILogPersistable
    {
        public ConsoleLog()
        {
        }

        public void WirteWarning(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            LogEntry entry = new LogEntry(warning, LogType.Warning);
            Console.WriteLine(entry.Serialize());
        }

        public void WriteError(string error)
        {
			Console.ForegroundColor = ConsoleColor.Red;
			LogEntry entry = new LogEntry(error, LogType.Error);
            Console.WriteLine(entry.Serialize());
        }

        public void WriteMessage(string message)
        {
			Console.ForegroundColor = ConsoleColor.Green;
			LogEntry entry = new LogEntry(message, LogType.Info);
            Console.WriteLine(entry.Serialize());
        }
    }
}

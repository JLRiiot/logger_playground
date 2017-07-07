using System;
using ImBack.Contracts;

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
            Console.WriteLine(warning);
        }

        public void WriteError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
        }

        public void WriteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}

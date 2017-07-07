using System;
using System.Configuration;
using System.Collections.Generic;

using ImBack.Repositories;
using ImBack.Models;

namespace ImBack.Facades
{
    public static class Log
    {
        static readonly List<LogRepository> _loggers;

        static Log()
        {
            RepositoryFactory factory = new RepositoryFactory(ConfigurationManager.AppSettings["LogPersistence"]
                                                              , ConfigurationManager.AppSettings["LogVerbosity"]);
            _loggers = factory.CreateRepositories();
        }

        private static void WriteLog(LogEntry logEntry)
        {
            foreach (var logger in _loggers)
            {
                logger.WriteLog(logEntry);
            }
        }

        public static void Error(String error, String details)
        {
            WriteLog(new ErrorLog(error, details, DateTime.Now));
        }

        public static void Message(String message)
		{
			WriteLog(new MessageLog(message, DateTime.Now));
        }

        public static void Warning(String warning)
		{
			WriteLog(new WarningLog(warning, DateTime.Now));
        }
    }
}

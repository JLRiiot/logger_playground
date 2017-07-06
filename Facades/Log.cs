using System;
using System.Configuration;
using ImBack.Contracts;
using ImBack.Repositories;

namespace ImBack.Facades
{
    public static class Log
    {
        static readonly ILogPersistable _repository;

        static Log()
        {
            RepositoryFactory factory = new RepositoryFactory(ConfigurationManager.AppSettings["LogPersistence"]);
            _repository = factory.CreateRepository();
        }

        public static void WriteError(String error)
        {
            _repository.WriteError(error);
        }

        public static void WriteMessage(String message)
        {
            _repository.WriteMessage(message);
        }

        public static void WriteWarning(String warning)
        {
            _repository.WirteWarning(warning);
        }
    }
}

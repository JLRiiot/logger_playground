using System;
using System.Collections.Generic;

namespace ImBack.Repositories
{
    public class RepositoryFactory
    {
		const String FILE_SYSTEM_PERSISTENCE = "file_system";
		const String DATABASE_PERSISTENCE = "database";
		const String CONSOLE_PERSISTENCE = "console";

        private HashSet<String> _persistenceTypes;
        private HashSet<String> _verbosity;

        public RepositoryFactory(String persistenceTypes, String verbosity)
        {
            this._persistenceTypes = new HashSet<String>(persistenceTypes.Split('|'));
            this._verbosity = new HashSet<String>(verbosity.Split('|'));
        }

        public List<LogRepository> CreateRepositories()
        {
            List<LogRepository> repositories = new List<LogRepository>();

            foreach (var persistenceType in _persistenceTypes)
            {
                repositories.Add(CreateRepository(persistenceType));
            }

            return repositories;
        }

        private LogRepository CreateRepository(String persistenceType)
        {
            switch (persistenceType)
            {
                case FILE_SYSTEM_PERSISTENCE:
                    return new FileSystemLog(this._verbosity);
                case DATABASE_PERSISTENCE:
                    return new DatabaseLog(this._verbosity);
                default:
                    return new ConsoleLog(this._verbosity);
            }
        }
    }
}

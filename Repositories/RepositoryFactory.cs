using System;
using ImBack.Contracts;

namespace ImBack.Repositories
{
    public class RepositoryFactory
    {
		const String FILE_SYSTEM_PERSISTENCE = "file_system";
		const String DATABASE_PERSISTENCE = "database";
		const String CONSOLE_PERSISTENCE = "console";

        private String _persistenceType = String.Empty;

        public RepositoryFactory(String persistenceType)
        {
            this._persistenceType = persistenceType;
        }

        public ILogPersistable CreateRepository()
        {
            switch (this._persistenceType)
            {
                case FILE_SYSTEM_PERSISTENCE:
                    return null;
                default:
                    return null;
            }
        }
    }
}

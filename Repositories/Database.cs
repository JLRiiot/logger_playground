using System;
using ImBack.Contracts;
namespace ImBack.Repositories
{
    public class Database : ILogPersistable
    {
        public Database()
        {
        }

        public void WirteWarning(string warning)
        {
            throw new NotImplementedException();
        }

        public void WriteError(string error)
        {
            throw new NotImplementedException();
        }

        public void WriteMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace ImBack.Contracts
{
    public interface ILogPersistable
    {
        void WriteMessage(String message);
        void WriteError(String error);
        void WirteWarning(String warning);
    }
}

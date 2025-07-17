using System.Data.Common;

namespace eshift.database
{
    internal interface IDBConnectionManager : IDisposable
    {
        DbConnection GetConnection();
        void OpenConnection();
        void CloseConnection();
    }
}

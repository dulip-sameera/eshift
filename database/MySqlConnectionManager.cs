using eshift.exception;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace eshift.database
{
    internal class MySqlConnectionManager : IDBConnectionManager, IDisposable
    {
        private readonly string _connectionString;
        private MySqlConnection _connection;
        private bool _disposed = false;

        public MySqlConnectionManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EshiftDb"]?.ConnectionString
                ?? throw new InvalidOperationException("Connection string 'EshiftDb' not found in configuration.");

            _connection = new MySqlConnection(_connectionString);
        }

        public DbConnection GetConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                OpenConnection();
            }
            return _connection;
        }


        public void OpenConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new ConnectionErrorException(ex.Message);
            }
        }

        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }
        
    }
}

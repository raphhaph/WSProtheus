using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Infrastructure.Database.DataAccess
{
    public class DataContext
    {
        #region Private Members
        private readonly Microsoft.Practices.EnterpriseLibrary.Data.Database _database;
        #endregion

        #region Constructors
        static DataContext()
        {
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
        }
        public DataContext(string connectionName)
        {
            _database = new DatabaseProviderFactory().Create(connectionName);
        }
        #endregion

        #region IDataContext Members
        public object ExecuteScalar(string query,CommandType commandType ,List<IDbDataParameter> parameters)
        {
            DbConnection _connection;
            _connection = _database.CreateConnection();
            _connection.Open();
            var cmd = commandType == CommandType.StoredProcedure ? _database.GetStoredProcCommand(query) : _database.GetSqlStringCommand(query);
            cmd.CommandTimeout = 300;
            cmd.Connection = _connection;
            using (cmd)
            {
                if (parameters != null && parameters.Count > 0)
                    cmd.Parameters.AddRange(parameters.ToArray());
                return _database.ExecuteScalar(cmd);
            }
        }
        public int ExecuteNonQuery(string query,CommandType commandType ,List<IDbDataParameter> parameters)
        {
            DbConnection _connection;
            _connection = _database.CreateConnection();

            var cmd = commandType == CommandType.StoredProcedure ? _database.GetStoredProcCommand(query) : _database.GetSqlStringCommand(query);
            cmd.CommandTimeout = 300;
            cmd.Connection = _connection;
            _connection.Open();

            using (cmd)
            {
                if (parameters != null && parameters.Count > 0)
                cmd.Parameters.AddRange(parameters.ToArray());
                return _database.ExecuteNonQuery(cmd);
            }
        }
        public DataSet ExecuteDataSet(string query,CommandType commandType ,List<IDbDataParameter> parameters)
        {
            DbConnection _connection;
            _connection = _database.CreateConnection();

            var cmd = commandType == CommandType.StoredProcedure ? _database.GetStoredProcCommand(query) : _database.GetSqlStringCommand(query);
            cmd.CommandTimeout = 300;
            cmd.Connection = _connection;
            if (parameters != null && parameters.Count > 0)
                cmd.Parameters.AddRange(parameters.ToArray());
            return _database.ExecuteDataSet(cmd);
        }
        public IDataReader ExecuteReader(string query,CommandType commandType ,List<IDbDataParameter> parameters)
        {
            DbConnection _connection;
            _connection = _database.CreateConnection();

            var cmd = commandType == CommandType.StoredProcedure ? _database.GetStoredProcCommand(query) : _database.GetSqlStringCommand(query);
            cmd.CommandTimeout = 300;
            cmd.Connection = _connection;
            _connection.Open();
            if (parameters != null && parameters.Count > 0)
                cmd.Parameters.AddRange(parameters.ToArray());
            return _database.ExecuteReader(cmd);
        }
        #endregion
    }
}

using MySqlConnector;

namespace BHMS.Database
{
    public class DatabaseConnection
    {
        private MySqlConnection connection;

        public DatabaseConnection(string server, string database, string uid, string password)
        {
            var connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password};";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}

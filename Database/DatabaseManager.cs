namespace dotnet_web_mvc_project_template.Database;

public class DatabaseManager
{
    private DatabaseConnection _dbConnection;

    public DatabaseManager()
    {
        string host = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
        string database = Environment.GetEnvironmentVariable("DB_DATABASE") ?? "northwind";
        string user = Environment.GetEnvironmentVariable("DB_USER") ?? "user";
        string password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "user";
        _dbConnection = new DatabaseConnection(host, database, user, password);
        // _dbConnection = new DatabaseConnection("localhost", "northwind", "user", "user");
    }

    public List<string> GetCustomerNamesFromProductsTable()
    {
        List<string> customerNames = new List<string>();

        try
        {
            using (var db = _dbConnection.GetConnection())
            {
                db.Open();
                var cmd = db.CreateCommand();
                cmd.CommandText = "SELECT * FROM products;";
                cmd.Prepare();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        customerNames.Add(rdr.GetString(1));
                    }
                }
                db.Close();
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("An error occurred while fetching data: " + ex.Message);
        }
        return customerNames;
    }

    public void InsertCustomerNameIntoProductsTable(string customerName)
    {
        try
        {
            using (var db = _dbConnection.GetConnection())
            {
                db.Open();
                var cmd = db.CreateCommand();
                cmd.CommandText = "INSERT INTO products (ProductName) VALUES (@customerName);";
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                db.Close();
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("An error occurred while inserting data: " + ex.Message);
        }
    }

    public void UpdateCustomerNameInProductsTable(string oldCustomerName, string newCustomerName)
    {
        try
        {
            using (var db = _dbConnection.GetConnection())
            {
                db.Open();
                var cmd = db.CreateCommand();
                cmd.CommandText =
                    "UPDATE products SET ProductName = @newCustomerName WHERE ProductName = @oldCustomerName;";
                cmd.Parameters.AddWithValue("@newCustomerName", newCustomerName);
                cmd.Parameters.AddWithValue("@oldCustomerName", oldCustomerName);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                db.Close();
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("An error occurred while update data: " + ex.Message);
        }
    }

    public void DeleteCustomerNameFromProductsTable(string customerName)
    {
        try
        {
            using (var db = _dbConnection.GetConnection())
            {
                db.Open();
                var cmd = db.CreateCommand();
                cmd.CommandText = "DELETE FROM products WHERE ProductName = @customerName;";
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                db.Close();
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("An error occurred while deleting data: " + ex.Message);
        }
    }
}


using MySql.Data.MySqlClient;

namespace SMD_Water_Station.Classes
{
    public class Database
    {
        public static MySqlConnection Connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='smd';username=root;password=;SslMode=None;Convert Zero Datetime=True");

        public static void OpenConnection()
        {
            Connection.Open();
        }

        public static void CloseConnection()
        {
            Connection.Close();
        }

        public static MySqlCommand ExecuteQuery(string Query)
        {
            MySqlCommand Command = new MySqlCommand(Query, Connection);
            return Command;
        }

        public static MySqlDataReader Data_Reader(string Query)
        {
            MySqlCommand Command = new MySqlCommand(Query, Connection);
            MySqlDataReader Reader = Command.ExecuteReader();
            return Reader;
        }

        public static MySqlDataAdapter Data_Adapter(string Query)
        {
            MySqlDataAdapter Adapter = new MySqlDataAdapter(Query, Connection);
            CloseConnection();
            return Adapter;
        }
    }
}

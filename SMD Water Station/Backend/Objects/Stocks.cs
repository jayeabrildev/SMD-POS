using MySql.Data.MySqlClient;
using SMD_Water_Station.Classes;
using System;

namespace SMD_Water_Station.Backend.Objects
{
    class Stocks
    {
        //Methods
        public void DeductStocks(int deduct, string productID)
        {
            int updatedStocks = GetStocks(Product.selectedProductID) - deduct;

            string query = "UPDATE `stocks` SET `quantity` = '" + updatedStocks + "' WHERE `productid` = '" + productID + "'";
            MySqlCommand deductCommand = new MySqlCommand(query, Database.Connection);

            Database.OpenConnection();
            deductCommand.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void AddStocks(int stocksToAdd, string productID)
        {
            int updatedStocks = GetStocks(productID) + stocksToAdd;

            string query = "UPDATE `stocks` SET `quantity` = '" + updatedStocks + "' WHERE `productid` = '" + productID + "'";
            MySqlCommand deductCommand = Database.ExecuteQuery(query);

            Database.OpenConnection();
            deductCommand.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public int GetStocks(string productID)
        {
            int Stocks = 0;
            string query = "SELECT `quantity` FROM stocks WHERE `productid` = '" + productID + "'";
            Database.OpenConnection();
            MySqlDataReader reader = Database.Data_Reader(query);
            if (reader.Read())
            {
                Stocks = reader.GetInt32(0);
            }
            Database.CloseConnection();
            return Stocks;
        }

        public void LogRecord(string productid, string log, int quantity)
        {
            string query = "INSERT INTO `log_stocks`(productid, quantity, user, log,date) VALUES (@productid, @quantity, @user, @log, @date)";

            Database.OpenConnection();
            MySqlCommand command = Database.ExecuteQuery(query);

            command.Parameters.AddWithValue("@productid", productid);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@user", User.userID);
            command.Parameters.AddWithValue("@log", log);
            command.Parameters.AddWithValue("@date", DateTime.Now);

            command.ExecuteNonQuery();
            Database.CloseConnection();
        }
    }
}

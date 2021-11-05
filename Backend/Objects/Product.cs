using MySql.Data.MySqlClient;
using SMD_Water_Station.Backend.Objects;
using System;
using System.Data;
using System.Windows.Forms;

namespace SMD_Water_Station.Classes
{
    class Product
    {
        //Fields
        public static string selectedProductID;
        public static string selectedProductName;
        public static double selectedProductPrice;
        public static int selectedProductQuantity;
        public static int totalItems = 0;

        //Methods
        public DataTable ListProducts(bool displayLowStocks)
        {
            Database database = new Database();
            string Query;

            if (displayLowStocks == true)
            {
                Query = "SELECT products.productid as 'Product ID', products.description, stocks.quantity, products.price FROM products INNER JOIN `stocks` " +
                "ON stocks.productid = products.productid";
            }
            else
            {
                Query = "SELECT products.productid as 'Product ID', products.description, stocks.quantity, products.price FROM products INNER JOIN `stocks` " +
                "ON stocks.productid = products.productid WHERE stocks.quantity >= 20";
            }

            DataTable dataTable = new DataTable();

            try
            {
                Database.OpenConnection();
                MySqlDataAdapter adapter = Database.Data_Adapter(Query);
                adapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            Database.CloseConnection();

            return dataTable;
        }

        public DataTable ListStockHistory()
        {
            string Query = "SELECT productid, quantity, user, log, date FROM log_stocks";

            DataTable dataTable = new DataTable();

            try
            {
                Database.OpenConnection();
                MySqlDataAdapter adapter = Database.Data_Adapter(Query);
                adapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            Database.CloseConnection();

            return dataTable;
        }

        public DataTable Search(string searchValue, bool displayLowStocks)
        {
            string Query;
            if (displayLowStocks == true)
            {
                Query = "SELECT products.productid, products.description, stocks.quantity, products.price FROM products INNER JOIN `stocks` " +
                "ON stocks.productid = products.productid WHERE products.productid LIKE '%" + searchValue + "%' OR products.description LIKE '%" + searchValue + "%'";
            }
            else
            {
                Query = "SELECT products.productid, products.description, stocks.quantity, products.price FROM products INNER JOIN `stocks` " +
                "ON stocks.productid = products.productid WHERE products.productid LIKE '%" + searchValue + "%' AND stocks.quantity >= 20 OR products.description LIKE '%" + searchValue + "%' AND stocks.quantity >= 20";
            }

            DataTable dataTable = new DataTable();

            try
            {
                Database.OpenConnection();
                MySqlDataAdapter adapter = Database.Data_Adapter(Query);
                adapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }
            Database.CloseConnection();

            return dataTable;
        }

        public static void SetDatagridProperties(DataGridView items)
        {
            try
            {
                //Set Column Widths
                items.Columns[0].Width = 100;
                items.Columns[1].Width = 210;
                items.Columns[2].Width = 60;
                items.Columns[3].Width = 60;

                //Set Column Header Texts
                items.Columns[0].HeaderText = "Product ID";
                items.Columns[1].HeaderText = "Description";
                items.Columns[2].HeaderText = "Stocks";
                items.Columns[3].HeaderText = "Price";
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }

        }

        public static void SetDatagridProperties2(DataGridView items)
        {
            try
            {
                //Set Column Widths
                items.Columns[0].Width = 90;
                items.Columns[1].Width = 30;
                items.Columns[2].Width = 80;
                items.Columns[3].Width = 80;
                items.Columns[4].Width = 80;

                //Set Column Header Texts
                items.Columns[0].HeaderText = "Product ID";
                items.Columns[1].HeaderText = "QTY";
                items.Columns[2].HeaderText = "User";
                items.Columns[3].HeaderText = "Detail";
                items.Columns[4].HeaderText = "Date";
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }

        }

        public static Tuple<int, int> CountItems()
        {
            string query1 = "SELECT COUNT(*) FROM stocks WHERE quantity >= 20";
            int displayedItems = 0;
            int hiddenItems = 0;

            Database.OpenConnection();

            MySqlDataReader reader1 = Database.Data_Reader(query1);

            if (reader1.Read())
            {
                displayedItems = reader1.GetInt32(0);
                PageHandler._homePage.Label_DisplayedItems.Text = displayedItems.ToString();
            }

            Database.CloseConnection();

            string query2 = "SELECT COUNT(*) FROM stocks WHERE `quantity` <= 19";

            Database.OpenConnection();
            MySqlDataReader reader2 = Database.Data_Reader(query2);
            if (reader2.Read())
            {
                hiddenItems = reader2.GetInt32(0);
                PageHandler._homePage.Label_HiddenItems.Text = hiddenItems.ToString();
            }

            totalItems = displayedItems + hiddenItems;

            Database.CloseConnection();

            return Tuple.Create(displayedItems, hiddenItems);
        }

        public void UpdateProductInformation(string UpdatedInformation, double UpdatedPrice)
        {
            Database database = new Database();

            string query = "UPDATE products SET description = @newDescription, price = @newPrice WHERE productid = '" + Product.selectedProductID + "'";
            MySqlCommand command = Database.ExecuteQuery(query);

            command.Parameters.AddWithValue("@newDescription", UpdatedInformation);
            command.Parameters.AddWithValue("@newPrice", UpdatedPrice);

            Database.OpenConnection();
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void DeleteProduct(string productid)
        {
            Database database = new Database();

            string query = "DELETE products, stocks FROM products INNER JOIN stocks WHERE products.productid = stocks.productid " +
                "AND products.productid = '" + productid + "'";
            MySqlCommand command = Database.ExecuteQuery(query);
            Database.OpenConnection();
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void AddNewProduct(string productId, string description, double price, int quantity)
        {
            Database database = new Database();
            string query = "INSERT INTO products(productid, description, price) VALUES (@productId, @description, @price);" +
                "INSERT INTO stocks(productid, quantity) VALUES (@productId2, @quantity)";

            Database.OpenConnection();
            MySqlCommand command = Database.ExecuteQuery(query);

            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@productId2", productId);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@quantity", quantity);

            command.ExecuteNonQuery();

            Database.CloseConnection();

            Stocks stocks = new Stocks();
            stocks.LogRecord(productId, "New product", quantity);

        }

        public bool DuplicateCheck(string productid)
        {
            Database database = new Database();
            string query = "SELECT COUNT(`productid`) FROM products WHERE productid = '" + productid + "' ";

            Database.OpenConnection();
            MySqlCommand command = Database.ExecuteQuery(query);

            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());

            if (temp > 0)
            {
                //Duplicate found
                Database.CloseConnection();
                return true;
            }
            else
            {
                Database.CloseConnection();
                return false;
            }

        }

    }
}

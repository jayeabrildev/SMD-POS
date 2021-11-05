using MySql.Data.MySqlClient;
using SMD_Water_Station.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SMD_Water_Station.Backend.Objects
{
    public class Sales
    {
        //Fields
        public static int selectedTransaction;
        public static string transactionItems;
        public static string itemQuantity;
        public static double transactionTotal;
        public static DateTime transactionDate;
        public static string transactionIssuer;

        public static string products;
        public static string quantities;


        //Methods
        public void NewSales()
        {
            List<string> items = new List<string>();
            List<string> quantity = new List<string>();

            foreach (DataGridViewRow item in PageHandler._homePage.Datagrid_cart.Rows)
            {
                items.Add(item.Cells[0].Value.ToString());
            }

            string itemsList = string.Join(Environment.NewLine, items.ToArray());

            foreach (DataGridViewRow qty in PageHandler._homePage.Datagrid_cart.Rows)
            {
                quantity.Add(qty.Cells[2].Value.ToString());
            }

            string qtyList = string.Join(Environment.NewLine, quantity.ToArray());

            string query = "INSERT INTO `sales`(`items`, `quantity`, `amount`, `dateoftransaction`, `timeoftransaction`, `issuedby`)" +
                "VALUES (@items, @qty, @total, @dateNow, @timenow, @user)";

            MySqlCommand command = Database.ExecuteQuery(query);

            command.Parameters.AddWithValue("@items", itemsList);
            command.Parameters.AddWithValue("@qty", qtyList);
            command.Parameters.AddWithValue("@total", Cart.grossTotal);
            command.Parameters.AddWithValue("@dateNow", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@timenow", DateTime.Now.ToString("hh:mm tt"));
            command.Parameters.AddWithValue("@user", User.userID);

            Database.OpenConnection();

            command.ExecuteNonQuery();
            Database.CloseConnection();

        }

        public DataTable LoadSales()
        {
            string Query = "SELECT salesid, items, quantity, amount, dateoftransaction, issuedby FROM sales";

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
                items.Columns[0].Width = 80;
                items.Columns[1].Width = 150;
                items.Columns[2].Width = 50;
                items.Columns[3].Width = 70;
                items.Columns[4].Width = 80;

                //Set Column Header Texts
                items.Columns[0].HeaderText = "Sales ID";
                items.Columns[1].HeaderText = "Items";
                items.Columns[2].HeaderText = "QTY";
                items.Columns[3].HeaderText = "Total";
                items.Columns[4].HeaderText = "Date";
                items.Columns[5].Visible = false;


            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }

        }

        public void DeleteTransaction(string productid, int quantity)
        {
            Stocks stocks = new Stocks();
            stocks.AddStocks(quantity, productid);
            stocks.LogRecord(productid, "Return item", quantity);

            string query = "DELETE FROM `sales` WHERE `salesid` = '" + selectedTransaction + "'";

            Database.OpenConnection();
            MySqlCommand command = Database.ExecuteQuery(query);
            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void PlotToday()
        {
            PageHandler._salesPage.Chart_Today.Series["Gross Sales"].Points.Clear();

            string query = "SELECT `timeoftransaction`, `amount` FROM `sales` WHERE dateoftransaction = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";

            Database.OpenConnection();
            MySqlDataReader reader = Database.Data_Reader(query);

            while (reader.Read())
            {
                DateTime time = DateTime.Parse(reader.GetString(0));
                PageHandler._salesPage.Chart_Today.Series["Gross Sales"].Points.AddXY(time.ToString("hh:mm: tt"), reader.GetDouble(1));

            }
            Database.CloseConnection();
        }

        public Tuple<int, double> Today()
        {
            string query = "SELECT `timeoftransaction`, `amount` FROM `sales` WHERE dateoftransaction = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";

            Database.OpenConnection();
            MySqlDataReader reader = Database.Data_Reader(query);

            int itemCount = 0;
            double gross = 0;
            while (reader.Read())
            {
                gross = gross + reader.GetDouble(1);
                itemCount++;
            }

            Database.CloseConnection();

            return Tuple.Create(itemCount, gross);
        }

        public double GrossTotal()
        {
            string query = "SELECT `amount` FROM `sales`";

            Database.OpenConnection();
            MySqlDataReader reader = Database.Data_Reader(query);

            double grossTotal = 0;
            while (reader.Read())
            {
                grossTotal += reader.GetDouble(0);
            }
            Database.CloseConnection();
            return grossTotal;
        }

    }
}

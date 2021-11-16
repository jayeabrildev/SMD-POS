using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Models;
namespace SMD_Water_Station.Views.Forms
{
    public partial class Form_ProductStocksReports : Form
    {
        DataTable reportsTable = new DataTable();
        BindingSource reportsBindingSource = new BindingSource();

        StockReport stockReport = new StockReport();

        public Form_ProductStocksReports()
        {
            InitializeComponent();
        }

        private void Form_ProductStocksReports_Load(object sender, EventArgs e)
        {
            LoadStocks();
        }

        private async Task LoadStocks()
        {
            reportsTable = await Task.Run(() => stockReport.ViewReports());

            reportsBindingSource.DataSource = reportsTable;
            datagrid_stockReports.DataSource = reportsBindingSource;

            datagrid_stockReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_stockReports.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_stockReports, new object[] { true });

            
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = reportsTable.DefaultView;
            dataView.RowFilter = string.Format("Item like '%{0}%'", textbox_search.Text);
            datagrid_stockReports.DataSource = dataView.ToTable();
        }
    }
}

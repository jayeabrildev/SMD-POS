using ClosedXML.Excel;
using LiveCharts;
using LiveCharts.Wpf;
using Models;
using MySql.Data.MySqlClient;
using SMD_Water_Station.Views.Modals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_Water_Station.Views
{
    public partial class SalesView : UserControl
    {
        public static string selectedTransaction;

        BindingSource salesBindingSource = new BindingSource();
        DataTable salesTable = new DataTable();

        DateTime startDate;
        DateTime endDate;

        Sales sales = new Sales();

        public SalesView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void SalesView_Load(object sender, EventArgs e)
        {
            Sales sales = new Sales();

            PlotMonthly();
            DisplayTodaySales();
            DisplayTotalSales();

            if(sales.CountTotalTransactions() >= 1)
            {
                dtp_start.MaxDate = sales.SetMaxDate();
                dtp_end.MaxDate = sales.SetMaxDate();
                dtp_start.MinDate = sales.SetMinimumDate();
                dtp_end.MinDate = sales.SetMinimumDate();

                dtp_start.Value = dtp_start.MinDate;
            }

            
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            FilterTableByDate();
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            FilterTableByDate();
        }

        private void button_editProduct_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        //Methods
        private async Task FillTable(DateTime startDate, DateTime endDate)
        {
            datagrid_sales.Columns.Clear();
            datagrid_sales.DataSource = null;

            Sales sales = new Sales();
            salesTable = await Task.Run(() => sales.ListSales(startDate, endDate));
            salesBindingSource.DataSource = salesTable;
            datagrid_sales.DataSource = salesBindingSource;


            if (datagrid_sales.Columns.Count <= 6)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                datagrid_sales.Columns.Add(deleteButton);

                deleteButton.HeaderText = "Options";
                deleteButton.Text = "Delete";
                deleteButton.Name = "deleteButton";
                deleteButton.FlatStyle = FlatStyle.Flat;
                deleteButton.UseColumnTextForButtonValue = true;
            }
            datagrid_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_sales.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_sales, new object[] { true });
        }

        private void DisplayTodaySales()
        {
            Sales sales = new Sales();
            double salesToday = sales.ComputeTodaySales(DateTime.Today);
            label_todaysales.Text = salesToday.ToString("C", CultureInfo.GetCultureInfo("en-PH"));

            double average = sales.ComputeDailyAverage(DateTime.Today);
            label_average.Text = average.ToString("C", CultureInfo.GetCultureInfo("en-PH")) + " / Day";
        }

        private void DisplayTotalSales()
        {
            Sales sales = new Sales();
            double totalSales = sales.ComputeTotalSales();
            label_totalsales.Text = totalSales.ToString("C", CultureInfo.GetCultureInfo("en-PH"));

        }

        private void FilterTableByDate()
        {
            this.startDate = dtp_start.Value;
            this.endDate = dtp_end.Value;

            FillTable(this.startDate, this.endDate);
        }

        private void PlotMonthly()
        {
            DateTime a = Convert.ToDateTime(DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-01");
            DateTime b = Convert.ToDateTime(DateTime.Today.Month.ToString() + "-" + DateTime.Today.Month.ToString() + "-31");
            Sales sales = new Sales();
            List<double> revenues = new List<double>();
            var dates = new List<string>();
            DataTable salesTable = sales.ListSales(a, b);

            foreach (DataRow row in salesTable.Rows)
            {
                revenues.Add(Convert.ToDouble(row["amount"]));
                DateTime dateOfTransaction = Convert.ToDateTime(row["date"]);
                var format = "dd-MMM-yyyy";
                var formattedDate = dateOfTransaction.ToString(format);
                dates.Add(formattedDate);
            }

            var revenueArray = revenues.ToArray();

            cartesian_sales.Series.Clear();

            Axis AxisX = new Axis();
            AxisX.Labels = dates;
            cartesian_sales.AxisX.Add(AxisX);

            cartesian_sales.Series.Add(new LineSeries
            {
                Title = "Revenue",
                Values = new ChartValues<double>(revenueArray),

            });
        }

        private void ExportToExcel()
        {
            using (SaveFileDialog dialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(salesTable, "Sales");
                            workbook.SaveAs(dialog.FileName);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        private void datagrid_sales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid_sales.Columns[e.ColumnIndex].Name == "deleteButton")
            {
                Modal_Delete delete = new Modal_Delete();
                delete.deleteMode = 2;
                delete.ShowDialog();
                FillTable(this.startDate, this.endDate);
            }
        }

        private void datagrid_sales_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Set current row
                DataGridViewRow currentRow = datagrid_sales.Rows[e.RowIndex];

                //Fill the properties
                selectedTransaction = datagrid_sales.Rows[e.RowIndex].Cells[1].Value.ToString();
                sales.refnumber = datagrid_sales.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = salesTable.DefaultView;
            dataView.RowFilter = string.Format("Reference like '%{0}%'", textbox_search.Text.TrimEnd());
            datagrid_sales.DataSource = dataView.ToTable();
        }

    }
}

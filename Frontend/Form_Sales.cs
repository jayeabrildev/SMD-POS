using SMD_Water_Station.Backend.Objects;
using SMD_Water_Station.Frontend.DialogBoxes;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station.Views
{
    public partial class SalesView : Form
    {

        public SalesView()
        {
            InitializeComponent();
        }

        Sales sales = new Sales();

        //Methods
        public void LoadSales()
        {

            Sales.transactionItems = null;
            Sales.itemQuantity = null;

            Datagrid_Items.DataSource = null;
            Datagrid_Sales.DataSource = null;

            Datagrid_Sales.DataSource = sales.LoadSales();
            sales.PlotToday();

            if (Datagrid_Sales.Rows.Count >= 1)
            {
                Sales.SetDatagridProperties(Datagrid_Sales);

            }
            else
            {

            }

            Label_Today_GrossSales.Text = sales.Today().Item2.ToString("0.00");
            Label_Today_ItemsSold.Text = sales.Today().Item1.ToString();
            Label_TotalGross.Text = sales.GrossTotal().ToString("0.00");
        }

        private void DisplayInformation()
        {
            Label_SalesID.Text = Sales.selectedTransaction.ToString();
            Label_IssuedBy.Text = Sales.transactionIssuer.ToString();
            Label_DateIssued.Text = Sales.transactionDate.ToString("MMM dd yyyy");

            Datagrid_Items.Rows.Clear();
            Datagrid_Items.Rows.Add(Sales.transactionItems, Sales.itemQuantity);
            Datagrid_Items.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        //Events
        private void SalesView_Load(object sender, System.EventArgs e)
        {
            LoadSales();
            Datagrid_Sales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Textbox_search_Enter(object sender, System.EventArgs e)
        {
            Textbox_search.Clear();
        }

        private void Datagrid_Sales_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Datagrid_Sales.Rows[e.RowIndex];
                Sales.selectedTransaction = Convert.ToInt32(Datagrid_Sales.Rows[e.RowIndex].Cells[0].Value.ToString());
                Sales.transactionItems = Datagrid_Sales.Rows[e.RowIndex].Cells[1].Value.ToString();
                Sales.itemQuantity = Datagrid_Sales.Rows[e.RowIndex].Cells[2].Value.ToString();
                Sales.transactionTotal = Convert.ToDouble(Datagrid_Sales.Rows[e.RowIndex].Cells[3].Value.ToString());
                Sales.transactionDate = Convert.ToDateTime(Datagrid_Sales.Rows[e.RowIndex].Cells[4].Value.ToString());
                Sales.transactionIssuer = Datagrid_Sales.Rows[e.RowIndex].Cells[5].Value.ToString();


                DisplayInformation();
            }
        }

        private void Link_DeleteTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteTransactionDialog delete = new DeleteTransactionDialog();
            delete.ShowDialog(this);
        }


    }
}

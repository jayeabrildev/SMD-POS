using SMD_Water_Station.Backend.Objects;
using SMD_Water_Station.Classes;
using SMD_Water_Station.Frontend.DialogBoxes;
using System;
using System.Data;
using System.Windows.Forms;

namespace SMD_Water_Station.Views
{
    public partial class ProductsView : Form
    {
        public ProductsView()
        {
            InitializeComponent();
        }
        //Fields
        public static string searchKeyword;


        //Methods

        public void LoadProducts()
        {

            Datagrid_items.DataSource = null;

            //Load items to Datagridview
            Product product = new Product();
            Datagrid_items.DataSource = product.ListProducts(true);

            if (Datagrid_items.Rows.Count >= 1)
            {
                Product.SetDatagridProperties(Datagrid_items);

            }
            else
            {

            }

            Label_LowStocksItems.Text = Product.CountItems().Item2.ToString();
            Label_TotalItems.Text = Product.totalItems.ToString();
        }

        public void LoadStockHistory()
        {
            Datagrid_StockHistory.DataSource = null;

            //Load items to Datagridview
            Product product = new Product();
            Datagrid_StockHistory.DataSource = product.ListStockHistory();

            if (Datagrid_items.Rows.Count >= 1)
            {
                Product.SetDatagridProperties2(Datagrid_StockHistory);

            }
            else
            {

            }

            Label_LowStocksItems.Text = Product.CountItems().Item2.ToString();
            Label_TotalItems.Text = Product.totalItems.ToString();
        }

        private void DisplayInformation()
        {
            Label_ProductID.Text = Product.selectedProductID;
            Label_ProductDescription.Text = Product.selectedProductName;
            Label_Price.Text = "PHP " + Product.selectedProductPrice.ToString("0.00");
            Stocks stocks = new Stocks();
            Label_CurrentStocks.Text = stocks.GetStocks(Product.selectedProductID).ToString();
        }

        //Events
        private void ProductsView_Load(object sender, System.EventArgs e)
        {
            LoadProducts();
            LoadStockHistory();
        }

        private void Datagrid_items_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Datagrid_items.Rows[e.RowIndex];
                Product.selectedProductID = Datagrid_items.Rows[e.RowIndex].Cells[0].Value.ToString();
                Product.selectedProductName = Datagrid_items.Rows[e.RowIndex].Cells[1].Value.ToString();
                Product.selectedProductPrice = Convert.ToDouble(Datagrid_items.Rows[e.RowIndex].Cells[3].Value.ToString());
                DisplayInformation();
            }
        }

        private void Link_Edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditProductInformationDialog edit = new EditProductInformationDialog();
            edit.ShowDialog(this);
        }

        private void Textbox_search_TextChanged(object sender, EventArgs e)
        {
            searchKeyword = Textbox_search.Text.Trim();
            if (searchKeyword == "")
            {
                Product product = new Product();
                Datagrid_items.DataSource = product.ListProducts(true);
            }
            else
            {
                Product product = new Product();
                DataTable dataTable = null;
                dataTable = product.Search(searchKeyword, true);
                Datagrid_items.DataSource = dataTable;
            }

            if (Datagrid_items.Rows.Count >= 1)
            {
                Product.SetDatagridProperties(Datagrid_items);
            }
        }

        private void Link_UpdateStocks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditStocksDialog editStocks = new EditStocksDialog();
            editStocks.ShowDialog(this);
        }

        private void Link_Delete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult Delete = MessageBox.Show("Product deletion is permanent, Do you wish to proceed?", "SMD Water Station", MessageBoxButtons.YesNo);

            if (Delete == DialogResult.No)
            {

            }
            else
            {
                Product product = new Product();
                product.DeleteProduct(Product.selectedProductID);
                LoadProducts();
            }
        }

        private void Link_Add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewProductDialog addNew = new AddNewProductDialog();
            addNew.ShowDialog(this);
        }
    }
}

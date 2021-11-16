using SMD_Water_Station.Helpers;
using SMD_Water_Station.Views.Modals;
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
using SMD_Water_Station.Views.Forms;
using ClosedXML.Excel;

namespace SMD_Water_Station.Views
{
    public partial class ProductsView : UserControl
    {
        BindingSource productdBindingSource = new BindingSource();
        DataTable productsTable = new DataTable();

        Product product = new Product();
        Stocks stocks = new Stocks();

        public static string selectedProduct;

        public ProductsView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private async Task FillTable()
        {
            textbox_search.Clear();
            Product product = new Product();
            productsTable = await Task.Run(() => product.ListProducts(2));

            productdBindingSource.DataSource = productsTable;
            datagrid_products.DataSource = productdBindingSource;

            datagrid_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_products.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_products, new object[] { true });

            label_lowStocks.Text = product.CountLowStockProducts().ToString();
        }

        private void DisplayLowStocks()
        {
            DataView dv = new DataView(productsTable);
            dv.RowFilter = "Stocks <= 10"; // query example = "id = 10"
            datagrid_products.DataSource = dv.ToTable();

            switch (datagrid_products.Rows.Count)
            {
                case 0:
                    button_editProduct.Enabled = false;
                    button_deleteProduct.Enabled = false;
                    button_updateStocks.Enabled = false;

                    product.productID = null;

                    label_sku.Text = "----------";
                    label_description.Text = "----------";
                    label_price.Text = "PHP 0.00";
                    label_stocks.Text = "0";

                    break;
                default:
                    button_editProduct.Enabled = true;
                    button_deleteProduct.Enabled = true;
                    button_updateStocks.Enabled = true;
                    break;
            }

        }

        private void datagrid_products_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Set current row
                DataGridViewRow currentRow = datagrid_products.Rows[e.RowIndex];

                //Fill the properties
                product.productID = datagrid_products.Rows[e.RowIndex].Cells[0].Value.ToString();
                product.description = datagrid_products.Rows[e.RowIndex].Cells[1].Value.ToString();

                stocks.productID = datagrid_products.Rows[e.RowIndex].Cells[0].Value.ToString();
                stocks.quantity = Convert.ToInt32(datagrid_products.Rows[e.RowIndex].Cells[2].Value.ToString());

                product.price = Convert.ToDouble(datagrid_products.Rows[e.RowIndex].Cells[3].Value.ToString());

                selectedProduct = product.productID;

                //Change label values
                label_sku.Text = product.productID;
                label_description.Text = product.description;
                label_stocks.Text = stocks.quantity.ToString();
                label_price.Text = "PHP " + product.price.ToString();

                button_editProduct.Enabled = true;
                button_deleteProduct.Enabled = true;
                button_updateStocks.Enabled = true;
            }
            else
            {
                button_editProduct.Enabled = false;
                button_deleteProduct.Enabled = false;
                button_updateStocks.Enabled = false;
            }
            
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = productsTable.DefaultView;
            dataView.RowFilter = string.Format("description like '%{0}%'", textbox_search.Text);
            datagrid_products.DataSource = dataView.ToTable();

            switch (datagrid_products.Rows.Count){
                case 0:
                    button_editProduct.Enabled = false;
                    button_deleteProduct.Enabled = false;
                    button_updateStocks.Enabled = false;

                    product.productID = null;

                    label_sku.Text = "----------";
                    label_description.Text = "----------";
                    label_price.Text = "PHP 0.00";
                    label_stocks.Text = "0";

                    break;
                default:
                    button_editProduct.Enabled = true;
                    button_deleteProduct.Enabled = true;
                    button_updateStocks.Enabled = true;
                    break;
            }
        }

        private void button_newProduct_Click(object sender, EventArgs e)
        {
            Modal_NewProduct newProduct_modal = new Modal_NewProduct();
            newProduct_modal.ShowDialog(this);
            FillTable();
        }

        private void button_manageSuppliers_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button_editProduct_Click(object sender, EventArgs e)
        {
            Modal_EditProduct editProduct = new Modal_EditProduct();
            editProduct.ShowDialog();
            FillTable();
        }

        private void button_updateStocks_Click(object sender, EventArgs e)
        {
            Modal_UpdateStocks updateStocks = new Modal_UpdateStocks();
            updateStocks.ShowDialog(this);
            FillTable();
        }

        private void button_deleteProduct_Click(object sender, EventArgs e)
        {
            Modal_Delete delete = new Modal_Delete();
            delete.deleteMode = 0;
            delete.ShowDialog();
            FillTable();
        }

        private void checkbox_viewLowStocks_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkbox_viewLowStocks.Checked)
            {
                case true:
                    DisplayLowStocks();
                    break;
                case false:
                    FillTable();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ProductStocksReports stockReports = new Form_ProductStocksReports();
            stockReports.Show();
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            ExportToExcel();    
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
                            workbook.Worksheets.Add(productsTable, "Products");
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

    }
}

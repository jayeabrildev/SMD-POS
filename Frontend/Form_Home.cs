using SMD_Water_Station.Backend.Objects;
using SMD_Water_Station.Classes;
using SMD_Water_Station.Frontend.DialogBoxes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SMD_Water_Station.Views
{
    public partial class HomeView : Form
    {

        public HomeView()
        {
            InitializeComponent();
        }

        //Fields
        public static string searchKeyword;
        public static DataGridView cartDatagrid;

        //Events
        private void HomeView_Load(object sender, EventArgs e)
        {
            InitiateNew();
        }

        private void Datagrid_items_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Datagrid_items.Rows[e.RowIndex];
                Product.selectedProductID = Datagrid_items.Rows[e.RowIndex].Cells[0].Value.ToString();
                Product.selectedProductName = Datagrid_items.Rows[e.RowIndex].Cells[1].Value.ToString();
                Product.selectedProductPrice = Convert.ToDouble(Datagrid_items.Rows[e.RowIndex].Cells[3].Value.ToString());

                Stocks stocks = new Stocks();

                int currentStocks = stocks.GetStocks(Product.selectedProductID);

                if (currentStocks == 0)
                {
                    Button_add.Enabled = false;
                }
                else
                {
                    Button_add.Enabled = true;
                }
            }
        }

        private void Datagrid_cart_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Cart.cartProductID = Datagrid_cart.Rows[e.RowIndex].Cells[0].Value.ToString();
            Cart.cartItemQTY = Convert.ToInt32(Datagrid_cart.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            ItemSummaryDialog add = new ItemSummaryDialog();
            add.ShowDialog(this);
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            DialogResult confirmationDialog = MessageBox.Show("Are you sure you want to remove the selected item?", "SMD Water Station", MessageBoxButtons.YesNo);

            if (confirmationDialog == DialogResult.No)
            {

            }
            else
            {
                DiscardCartContents();
            }
        }

        private void Button_Discard_Click(object sender, EventArgs e)
        {
            DialogResult confirmationDialog = MessageBox.Show("Are you sure you want to discard the items?", "SMD Water Station", MessageBoxButtons.YesNo);

            if (confirmationDialog == DialogResult.No)
            {

            }
            else
            {
                CartContents cart = cartContentsBindingSource.Current as CartContents;
                if (cart != null)
                {
                    foreach (DataGridViewRow rows in Datagrid_cart.Rows)
                    {
                        string productID = rows.Cells[0].Value.ToString();
                        int quantity = Convert.ToInt32(rows.Cells[2].Value.ToString());

                        Stocks updateStocks = new Stocks();
                        updateStocks.AddStocks(quantity, productID);
                    }
                    cartContentsBindingSource.Clear();

                }
                Cart.Summarize();
                PageHandler._homePage.LoadProducts();
            }
        }

        private void Textbox_search_TextChanged(object sender, EventArgs e)
        {
            searchKeyword = Textbox_search.Text.Trim();

            if (searchKeyword == "")
            {
                Product product = new Product();
                Datagrid_items.DataSource = product.ListProducts(false);
            }
            else
            {
                Product product = new Product();
                DataTable dataTable = null;
                if (Checkbox_DisplayLowStocks.Checked == true)
                {
                    dataTable = product.Search(searchKeyword, true);
                }
                else
                {
                    dataTable = product.Search(searchKeyword, false);
                }

                Datagrid_items.DataSource = dataTable;
            }

            if (Datagrid_items.Rows.Count >= 1)
            {
                Product.SetDatagridProperties(Datagrid_items);
            }
        }

        private void Button_Checkout_Click(object sender, EventArgs e)
        {
            if (Datagrid_cart.Rows.Count != 0)
            {
                Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
                using (Graphics G = Graphics.FromImage(bmp))
                {
                    G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                    G.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                    double percent = 0.60;
                    Color darken = Color.FromArgb((int)(255 * percent), Color.Black);

                    using (Brush brsh = new SolidBrush(darken))
                    {
                        G.FillRectangle(brsh, this.ClientRectangle);
                    }
                }

                using (Panel p = new Panel())
                {
                    p.Location = new Point(0, 0);
                    p.Size = this.ClientRectangle.Size;
                    p.BackgroundImage = bmp;
                    this.Controls.Add(p);
                    p.BringToFront();
                    CheckOutDialog checkOut = new CheckOutDialog();
                    checkOut.ShowDialog(this);
                }
            }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        //Methods
        public void InitiateNew()
        {
            LoadProducts();

            //Instantiate new list for cart
            cartContentsBindingSource.DataSource = new List<CartContents>();

            Cart.Summarize();

            Sales sales = new Sales();
            Label_GrossSalesToday.Text = sales.Today().Item2.ToString();
            Label_ItemsSoldToday.Text = sales.Today().Item1.ToString();
        }

        public void LoadProducts()
        {
            Datagrid_items.DataSource = null;

            //Load items to Datagridview
            Product product = new Product();

            if (Checkbox_DisplayLowStocks.Checked == true)
            {
                Datagrid_items.DataSource = product.ListProducts(true);
            }
            else
            {
                Datagrid_items.DataSource = product.ListProducts(false);
            }


            if (Datagrid_items.Rows.Count >= 1)
            {
                Product.SetDatagridProperties(Datagrid_items);
            }

            Label_DisplayedItems.Text = Product.CountItems().Item1.ToString();
            Label_HiddenItems.Text = Product.CountItems().Item2.ToString();
        }

        public void DiscardCartContents()
        {
            CartContents cart = cartContentsBindingSource.Current as CartContents;
            if (cart != null)
            {
                foreach (DataGridViewRow rows in Datagrid_cart.Rows)
                {
                    string productID = rows.Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(rows.Cells[2].Value.ToString());

                    Stocks updateStocks = new Stocks();
                    updateStocks.GetStocks(productID);
                    updateStocks.AddStocks(quantity, productID);
                }
                cartContentsBindingSource.Clear();

            }
            Cart.Summarize();
            PageHandler._homePage.LoadProducts();
        }

        private void Checkbox_DisplayLowStocks_CheckedChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}

using System;
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

using Models;
using SMD_Water_Station.Views.Modals;

namespace SMD_Water_Station.Views
{
    public partial class HomeView : UserControl
    {
        //Class instances
        Product product = new Product();
        
        // For datagrid of products
        BindingSource productBindingSource = new BindingSource();
        DataTable productsTable = new DataTable();

        // For datagrid of cart
        BindingList<Cart> cartbindingList;
        BindingSource source;
        List<Cart> cartProducts = new List<Cart>();

        //Variables
        public string referenceNumber;

        public HomeView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            NewTransaction();
        }


        private void datagrid_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid_products.Columns[e.ColumnIndex].Name == "AddToCart")
            {
                Modal_AddToCart addToCart = new Modal_AddToCart();
                int maxQty = Convert.ToInt32(datagrid_products.Rows[e.RowIndex].Cells["Stocks"].Value);
                addToCart.sku = datagrid_products.Rows[e.RowIndex].Cells["SKU"].Value.ToString();
                addToCart.nud_qty.Maximum = maxQty;
                addToCart.ShowDialog();

                if (addToCart.DialogResult == DialogResult.OK)
                {
                    Cart cart = new Cart();
                    cart.SKU = datagrid_products.Rows[e.RowIndex].Cells["SKU"].Value.ToString();
                    cart.Description = datagrid_products.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    cart.Price = Convert.ToDouble(datagrid_products.Rows[e.RowIndex].Cells["Price"].Value.ToString());
                    cart.QTY = Convert.ToInt32(addToCart.nud_qty.Value);
                    cart.SubTotal = Math.Round(cart.Price * cart.QTY, 2);

                    List<Cart> cartList = cartbindingList.ToList();
                    switch (cartList.Any(item => item.SKU == cart.SKU))
                    {
                        case true:
                            foreach (var existingItem in cartList)
                            {
                                if (existingItem.SKU == cart.SKU)
                                {
                                    if (existingItem.QTY + cart.QTY <= maxQty)
                                    {
                                        existingItem.QTY = existingItem.QTY + cart.QTY;
                                        existingItem.SubTotal = Math.Round(cart.Price * existingItem.QTY, 2);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Maximum Quantity already added.");
                                    }
                                }
                            }
                            break;
                        case false:

                            cartbindingList.Add(cart);
                            break;
                    }
                }
                label_total.Text = Math.Round(ComputeTotal(), 2).ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                label_totalItems.Text = cartbindingList.Count().ToString();
                
            }
            Validate();
        }

        private void datagrid_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid_orders.Columns[e.ColumnIndex].Name == "modifyAmount")
            {
                Stocks stocks = new Stocks();
                int maxQty = stocks.LoadStocks(datagrid_orders.Rows[e.RowIndex].Cells["SKU"].Value.ToString());
                
                Modal_AddToCart modifyAmount = new Modal_AddToCart();

                modifyAmount.nud_qty.Maximum = maxQty;

                modifyAmount.ShowDialog();

                if (modifyAmount.DialogResult == DialogResult.OK)
                {
                    Cart cart = new Cart();
                    cart.SKU = datagrid_orders.Rows[e.RowIndex].Cells["SKU"].Value.ToString();
                    cart.Description = datagrid_orders.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    cart.Price = Convert.ToDouble(datagrid_orders.Rows[e.RowIndex].Cells["Price"].Value.ToString());
                    cart.QTY = Convert.ToInt32(modifyAmount.nud_qty.Value);

                    List<Cart> cartList = cartbindingList.ToList();
                    switch (cartList.Any(item => item.SKU == cart.SKU))
                    {
                        case true:
                            foreach (var existingItem in cartList)
                            {
                                if (existingItem.SKU == cart.SKU)
                                {
                                    existingItem.QTY = cart.QTY;
                                    existingItem.SubTotal = Math.Round(cart.Price * existingItem.QTY, 2);
                                    
                                }
                            }
                            break;
                        case false:
                            cartbindingList.Add(cart);
                            break;
                    }
                }
                
            }
            else if(datagrid_orders.Columns[e.ColumnIndex].Name == "deleteButton")
            {
                cartbindingList.RemoveAt(e.RowIndex);
            }
            label_total.Text = Math.Round(ComputeTotal(), 2).ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            label_totalItems.Text = cartbindingList.Count().ToString();
            source.ResetBindings(false);
            Validate();
        }

        private void button_clearOrders_Click(object sender, EventArgs e)
        {
            cartbindingList.Clear();
            label_totalItems.Text = cartbindingList.Count().ToString();
            source.ResetBindings(false);
            Validate();
        }

        private void button_payment_Click(object sender, EventArgs e)
        {
            Modal_Payment payment = new Modal_Payment();
            payment.total = ComputeTotal();
            payment.ShowDialog();
            if(payment.DialogResult == DialogResult.OK)
            {
                List<Cart> cartList = cartbindingList.ToList();
                foreach (var item in cartList)
                {
                    Sales sales = new Sales();
                    sales.NewTransaction(this.referenceNumber, item.SKU, item.QTY, item.SubTotal, DateTime.Today);

                    Stocks stocks = new Stocks();
                    stocks.Deduct(item.SKU, item.QTY, "Sales");
                }
                NewTransaction();
            }
        }
        
        private async Task NewTransaction()
        {
            //Initiate new Reference number
            referenceNumber = DateTime.Now.ToString("yyyyMMddHHmmss");
            label_referencenumber.Text = referenceNumber;

            double initialTotal = 0;
            label_total.Text = initialTotal.ToString("C", CultureInfo.GetCultureInfo("en-PH"));

            //Clear the search textbox
            textbox_search.Clear();

            datagrid_products.DataSource = null;
            datagrid_orders.DataSource = null;

            datagrid_products.Columns.Clear();
            datagrid_orders.Columns.Clear();

            cartProducts.Clear();

            //List the products from the database to datagrid (Not including products with low stocks)
            productsTable = await Task.Run(() => product.ListProducts(0));
            productBindingSource.DataSource = productsTable;

            datagrid_products.DataSource = productBindingSource;
            datagrid_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_products.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_products, new object[] { true });
            
            //Add to Cart Button
            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            datagrid_products.Columns.Add(addButton);
            addButton.HeaderText = "Option";
            addButton.Text = "Add";
            addButton.Name = "AddToCart";
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.UseColumnTextForButtonValue = true;

            //Initiate Cart Datagrid
            cartbindingList = new BindingList<Cart>(cartProducts);
            source = new BindingSource(cartbindingList, null);
            datagrid_orders.DataSource = source;
            datagrid_orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_orders.Columns[0].Visible = false;
            datagrid_orders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Modify Amount Button
            DataGridViewButtonColumn modifyButton = new DataGridViewButtonColumn();
            datagrid_orders.Columns.Add(modifyButton);
            modifyButton.HeaderText = "Options";
            modifyButton.Text = "Modify Amount";
            modifyButton.Name = "modifyAmount";
            modifyButton.FlatStyle = FlatStyle.Flat;
            modifyButton.UseColumnTextForButtonValue = true;

            //Delete Button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            datagrid_orders.Columns.Add(deleteButton);
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.Name = "deleteButton";
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.UseColumnTextForButtonValue = true;

            label_totalItems.Text = cartbindingList.Count().ToString();
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = productsTable.DefaultView;
            dataView.RowFilter = string.Format("description like '%{0}%'", textbox_search.Text);
            datagrid_products.DataSource = dataView.ToTable();
        }

        private async void button_refresh_Click(object sender, EventArgs e)
        {
            //Clear the search textbox
            textbox_search.Clear();

            datagrid_products.DataSource = null;
            datagrid_products.Columns.Clear();

            //List the products from the database to datagrid
            productsTable = await Task.Run(() => product.ListProducts(0));
            productBindingSource.DataSource = productsTable;

            datagrid_products.DataSource = productBindingSource;
            datagrid_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_products.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            datagrid_products.Columns[4].Visible = false;

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_products, new object[] { true });

            //Add to Cart Button
            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            datagrid_products.Columns.Add(addButton);
            addButton.HeaderText = "Option";
            addButton.Text = "Add";
            addButton.Name = "AddToCart";
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.UseColumnTextForButtonValue = true;
        }

        private async void checkbox_viewLowStocks_CheckedChanged(object sender, EventArgs e)
        {
            datagrid_products.DataSource = null;
            datagrid_products.Columns.Clear();
            //List the products from the database to datagrid

            switch (checkbox_viewLowStocks.Checked)
            {
                case true:
                    productsTable = await Task.Run(() => product.ListProducts(1));
                    break;
                case false:
                    productsTable = await Task.Run(() => product.ListProducts(0));
                    break;
            }
           
            productBindingSource.DataSource = productsTable;

            datagrid_products.DataSource = productBindingSource;
            datagrid_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_products.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_products, new object[] { true });

            //Add to Cart Button
            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            datagrid_products.Columns.Add(addButton);
            addButton.HeaderText = "Option";
            addButton.Text = "Add";
            addButton.Name = "AddToCart";
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.UseColumnTextForButtonValue = true;
        }
        
        //Functions
        private double ComputeTotal()
        {
            List<Cart> cartList = cartbindingList.ToList();
            double totalPrice = 0;
            foreach (var existingItem in cartList)
            {
                totalPrice += existingItem.SubTotal;
            }
            source.ResetBindings(false);
            return totalPrice;
        }
        
        private void Validate()
        {
            if(datagrid_orders.Rows.Count <= 0)
            {
                button_payment.Enabled = false;
            }
            else
            {
                button_payment.Enabled = true;
            }
        }
    }
}

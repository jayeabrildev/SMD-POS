using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_Water_Station.Views.Modals
{
    public partial class Modal_UpdateStocks : Form
    {
        Product product = new Product();
        Stocks stocks = new Stocks();
        public Modal_UpdateStocks()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modal_UpdateStocks_Load(object sender, EventArgs e)
        {
            product.LoadProductDetails(ProductsView.selectedProduct);

            stocks.quantity = stocks.LoadStocks(ProductsView.selectedProduct);

            label_product.Text = product.description;
            label_currentStocks.Text = stocks.LoadStocks(ProductsView.selectedProduct).ToString();
            
            
            combobox_remarks.SelectedIndex = 0;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(rb_add.Checked == true)
            {
                stocks.AddStocks(ProductsView.selectedProduct, (int)nud_quantity.Value, combobox_remarks.Text.ToString());
            }
            else
            {
                stocks.Deduct(ProductsView.selectedProduct, (int)nud_quantity.Value, combobox_remarks.Text.ToString());
            }
            this.Close();
        }

        private void rb_deduct_CheckedChanged(object sender, EventArgs e)
        {
            nud_quantity.Value = nud_quantity.Minimum;
            nud_quantity.Maximum = stocks.LoadStocks(ProductsView.selectedProduct);
        }

        private void rb_add_CheckedChanged(object sender, EventArgs e)
        {
            nud_quantity.Value = nud_quantity.Minimum;
            nud_quantity.Maximum = 9999;
        }
    }
}

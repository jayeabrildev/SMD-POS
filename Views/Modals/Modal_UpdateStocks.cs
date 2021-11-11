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


            FillCombobox();
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
            FillCombobox();
            nud_quantity.Value = nud_quantity.Minimum;
            nud_quantity.Maximum = stocks.LoadStocks(ProductsView.selectedProduct);
            if(nud_quantity.Maximum <= 0)
            {
                button_save.Enabled = false;
            }
            else
            {
                button_save.Enabled = true;
            }
        }

        private void rb_add_CheckedChanged(object sender, EventArgs e)
        {
            FillCombobox();
            nud_quantity.Maximum = 999999;
            nud_quantity.Minimum = 1;
            nud_quantity.Value = nud_quantity.Minimum;
            button_save.Enabled = true;
        }

        private void FillCombobox()
        {
            combobox_remarks.Items.Clear();
            if (rb_add.Checked == true)
            {
                combobox_remarks.Items.Add("Restock");
                combobox_remarks.Items.Add("Correction/Adjustment");
            }
            else if(rb_deduct.Checked == true) 
            {
                combobox_remarks.Items.Add("Damaged item(s)");
                combobox_remarks.Items.Add("Lost item");
            }
            combobox_remarks.SelectedIndex = 1;
        }

    }
}

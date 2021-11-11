using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Models;

namespace SMD_Water_Station.Views.Modals
{
    public partial class Modal_NewProduct : Form
    {
        public Modal_NewProduct()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Modal_NewProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            switch (product.DuplicateCheck(textbox_sku.Text.Trim()))
            {
                case true:
                    MessageBox.Show("Product SKU is already existing.");
                    break;
                default:
                    product.productID = textbox_sku.Text.Trim();
                    product.description = textbox_description.Text.TrimEnd();
                    product.price = Convert.ToInt32(nud_price.Value);

                    Stocks stocks = new Stocks();
                    stocks.productID = product.productID;
                    stocks.quantity =  Convert.ToInt32(nud_initialStocks.Value);

                    product.AddNewProduct();
                    stocks.InitializeStocks(stocks.quantity);
                    this.Close();
                    break;
            };
            
        }

        private void textbox_sku_TextChanged(object sender, EventArgs e)
        {
            if (textbox_sku.Text.Trim().Length == 0 || textbox_description.Text.Trim().Length == 0)
            {
                button_save.Enabled = false;
            }
            else
            {
                button_save.Enabled = true;
            }
        }
    }
}

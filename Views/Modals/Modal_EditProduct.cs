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
    public partial class Modal_EditProduct : Form
    {
        Product product = new Product();
        Supplier supplier = new Supplier();

        public Modal_EditProduct()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modal_EditProduct_Load(object sender, EventArgs e)
        {
            try
            {
                product.LoadProductDetails(ProductsView.selectedProduct);
                textbox_sku.Text = ProductsView.selectedProduct;
                textbox_description.Text = product.description;
                nud_price.Value = (decimal)product.price;
                DataTable suppliersTable = supplier.ListSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.productID = ProductsView.selectedProduct;
                product.description = textbox_description.Text.TrimEnd();
                product.price = (double)nud_price.Value;
                product.UpdateProductInformation(ProductsView.selectedProduct, product.description, product.price);
                MessageBox.Show("Updated successfully", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void textbox_description_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
        private void ValidateInput()
        {
            if(textbox_description.Text.TrimEnd().Length <= 0)
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

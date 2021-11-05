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
    public partial class Modal_Delete : Form
    {
        public int deleteMode;
        public Modal_Delete()
        {
            InitializeComponent();
        }

        private void modalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                switch (deleteMode)
                {
                    case 0:
                        Product product = new Product();
                        product.DeleteProduct(ProductsView.selectedProduct);
                        break;
                    case 1:
                        Supplier supplier = new Supplier();
                        supplier.DeleteSupplier(SuppliersView.selectedSupplier);
                        break;
                    case 2:
                        Sales sales = new Sales();
                        sales.DeleteTransaction(SalesView.selectedTransaction);
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

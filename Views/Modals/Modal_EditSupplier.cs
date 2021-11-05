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
    public partial class Modal_EditSupplier : Form
    {

        private string currentSupplier;
        public Modal_EditSupplier()
        {
            InitializeComponent();
        }

        private void Modal_EditSupplier_Load(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            currentSupplier = supplier.GetSupplierName(SuppliersView.selectedSupplier);
            textbox_supplier.Text = currentSupplier;
        }

        private void textbox_supplier_TextChanged(object sender, EventArgs e)
        {
            if (textbox_supplier.Text.TrimEnd() == currentSupplier || textbox_supplier.Text.TrimEnd().Length == 0)
            {
                button_save.Enabled = false;
            }
            else
            {
                button_save.Enabled = true;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.UpdateSupplier(SuppliersView.selectedSupplier, textbox_supplier.Text.TrimEnd());
            this.Close();
        }
    }
}

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
    public partial class Modal_NewSupplier : Form
    {
        public Modal_NewSupplier()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_supplier_TextChanged(object sender, EventArgs e)
        {
            switch (textbox_supplier.Text.TrimEnd().Length)
            {
                case 0:
                    button_save.Enabled = false;
                    break;
                default:
                    button_save.Enabled = true;
                    break;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier();
                supplier.NewSupplier(textbox_supplier.Text.TrimEnd());
            }
            catch (Exception)
            {
                throw;
            }
            this.Close();
        }
    }
}

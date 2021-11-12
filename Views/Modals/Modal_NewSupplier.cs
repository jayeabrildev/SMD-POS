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
            CheckForEmpty();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string suppliername = textbox_supplier.Text.TrimEnd();
                string address = textbox_address.Text.TrimEnd();
                string contact = textbox_contact.Text.TrimEnd();
                string email = textbox_email.Text.TrimEnd();
                Supplier supplier = new Supplier();
                supplier.NewSupplier(suppliername, address, contact, email);
            }
            catch (Exception)
            {
                throw;
            }
            this.Close();
        }

        private void textbox_contact_TextChanged(object sender, EventArgs e)
        {
            CheckForEmpty();
        }

        private void textbox_address_TextChanged(object sender, EventArgs e)
        {
            CheckForEmpty();
        }

        private void textbox_email_TextChanged(object sender, EventArgs e)
        {
            CheckForEmpty();
        }
        
        private void CheckForEmpty()
        {
            TextBox[] textboxes = { textbox_supplier, textbox_address, textbox_contact, textbox_email };
            foreach (TextBox textbox in textboxes)
            {
                if (textbox.Text.Length == 0 || textbox.Text.TrimEnd() == "")
                {
                    button_save.Enabled = false;
                }
                else
                {
                    button_save.Enabled = true;
                }
            }
        }

        private void textbox_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

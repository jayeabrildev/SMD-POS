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
using SMD_Water_Station.Views.Forms;

namespace SMD_Water_Station.Views.Modals
{
    public partial class Modal_EditSupplier : Form
    {
        Supplier supplier = new Supplier();
        public Modal_EditSupplier()
        {
            InitializeComponent();
        }

        private void Modal_EditSupplier_Load(object sender, EventArgs e)
        {
            supplier.GetSupplierDetails(Form_Suppliers.selectedSupplier);
            textbox_supplier.Text = supplier.supplierName;
            textbox_address.Text = supplier.address;
            textbox_contact.Text = supplier.contact;
            textbox_email.Text = supplier.email;

            CheckForChanges(textbox_supplier, supplier.supplierName);
            CheckForChanges(textbox_address, supplier.address);
            CheckForChanges(textbox_contact, supplier.contact);
            CheckForChanges(textbox_email, supplier.email);
        }

        private void textbox_supplier_TextChanged(object sender, EventArgs e)
        {
            CheckForChanges(textbox_supplier, supplier.supplierName);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string newSuppliername = textbox_supplier.Text.TrimEnd();
            string newAddress = textbox_address.Text.TrimEnd();
            string newContact = textbox_contact.Text.TrimEnd();
            string newEmail = textbox_email.Text.TrimEnd();

            Supplier supplier = new Supplier();
            supplier.UpdateSupplier(Form_Suppliers.selectedSupplier, newSuppliername, newAddress, newContact, newEmail);
            this.Close();
        }

        private void CheckForChanges(TextBox textbox, string currentData)
        {
            if(textbox.Text.TrimEnd() == currentData || textbox.Text.TrimEnd() == "")
            {
                button_save.Enabled = false;
            }
            else
            {
                button_save.Enabled = true;
            }
        }

        private void textbox_contact_TextChanged(object sender, EventArgs e)
        {
            CheckForChanges(textbox_contact, supplier.contact);
        }

        private void textbox_address_TextChanged(object sender, EventArgs e)
        {
            CheckForChanges(textbox_address, supplier.address);
        }

        private void textbox_email_TextChanged(object sender, EventArgs e)
        {
            CheckForChanges(textbox_email, supplier.email);
        }
    }
}

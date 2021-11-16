using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_Water_Station.Views.Modals
{
    public partial class Modal_DeleteTransaction : Form
    {
        public string transactionID;
        public string refnumber;
        public string productid;
        public string productDesc;
        public int quantity;
        public double amount;

        public string remarks;
        public bool returnStocks;


        public Modal_DeleteTransaction()
        {
            InitializeComponent();
        }

        private void Modal_DeleteTransaction_Load(object sender, EventArgs e)
        {
            label_transactionID.Text = transactionID;
            label_refnumber.Text = refnumber;
            label_item.Text = productDesc;
            label_quantity.Text = quantity.ToString();
            label_amount.Text = amount.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            combobox_remarks.SelectedIndex = 0;
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deleting a transaction is irreversible, do you wish to continue?", "Warning",
              MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    Sales sales = new Sales();
                    if (checkbox_return.Checked == true)
                    {
                        sales.ReturnStocks(transactionID);
                    }
                    sales.DeleteTransaction(transactionID);
                    MessageBox.Show("Transaction deleted successfuly.", "Message");
                    this.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Modal_Payment : Form
    {
        public double total;
        public Modal_Payment()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Modal_Payment_Load(object sender, EventArgs e)
        {
            double change = 0;
            label_total.Text = total.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
            label_change.Text = change.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            
        }

        private void nud_amounttendered_ValueChanged(object sender, EventArgs e)
        {
            double amountTendered = Convert.ToDouble(nud_amounttendered.Value);
            if (amountTendered < total)
            {
                MessageBox.Show("The amount you entered is not enough.", "Error");
                button_confirm.Enabled = false;
            }
            else
            {
                double change = amountTendered - total;
                label_change.Text = change.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                button_confirm.Enabled = true;
            }
        }
    }
}

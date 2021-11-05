using SMD_Water_Station.Backend.Objects;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend.DialogBoxes
{
    public partial class CheckOutDialog : Form
    {
        public CheckOutDialog()
        {
            InitializeComponent();
        }

        //Events
        private void CheckOutDialog_Load(object sender, EventArgs e)
        {
            Label_TransactionDate.Text = DateTime.Today.ToString("MMM dd yyyy");
            Label_Total.Text = Cart.grossTotal.ToString("0.00");
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            Cart.amountTendered = Convert.ToDouble(Textbox_AmountTendered.Text);

            if (Cart.grossTotal > Cart.amountTendered)
            {
                Label_InsufficientAmount.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                Button_Confirm.Enabled = false;
                Textbox_AmountTendered.Enabled = false;
                Label_InsufficientAmount.Visible = false;
                Cart.CheckOut();
                Label_Change.Text = Cart.change.ToString("0.00");
                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Label_InsufficientAmount.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Textbox_AmountTendered_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_AmountTendered.TextLength == 0)
            {
                Button_Confirm.Enabled = false;
            }
            else
            {
                Button_Confirm.Enabled = true;
            }
        }


    }
}



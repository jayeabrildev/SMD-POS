using SMD_Water_Station.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend.DialogBoxes
{
    public partial class AddNewProductDialog : Form
    {
        public AddNewProductDialog()
        {
            InitializeComponent();
        }

        //Events
        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if (Textfield_ProductID.Text.Trim() != "" && Textfield_Description.Text.Trim() != "" && Textfield_Price.Text.Trim() != "")
            {
                string productId = Textfield_ProductID.Text.Trim();
                string description = Textfield_Description.Text.Trim();
                double price = Convert.ToDouble(Textfield_Price.Text.Trim());
                int quantity = Convert.ToInt32(NUD_InitialStocks.Value);



                Product product = new Product();
                bool hasDuplicate = product.DuplicateCheck(productId);


                if (hasDuplicate == true)
                {
                    Textfield_ProductID.SelectionStart = 0;
                    Textfield_ProductID.SelectionLength = Textfield_ProductID.Text.Length;

                    Label_ProductIDTaken.Visible = true;
                    timer1.Enabled = true;
                }
                else
                {
                    product.AddNewProduct(productId, description, price, quantity);
                    PageHandler._productsPage.LoadProducts();
                    PageHandler._productsPage.LoadStockHistory();
                    this.Close();
                }
            }
            else
            {
                if (Textfield_ProductID.Text.Trim() == "")
                {
                    Label_ProductID.ForeColor = Color.Red;
                }
                if (Textfield_Description.Text.Trim() == "")
                {
                    Label_Desription.ForeColor = Color.Red;
                }
                if (Textfield_Price.Text.Trim() == "")
                {
                    Label_Price.ForeColor = Color.Red;
                }
                Label_feedback.Visible = true;
                timer1.Enabled = true;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label_ProductID.ForeColor = Color.DimGray;
            Label_Desription.ForeColor = Color.DimGray;
            Label_Price.ForeColor = Color.DimGray;

            Label_feedback.Visible = false;
            Label_ProductIDTaken.Visible = false;
            timer1.Enabled = false;
        }

        private void Textfield_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                  && !char.IsDigit(e.KeyChar)
                  && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (Textfield_Price.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (Textfield_Price.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(Textfield_Price.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (Textfield_Price.SelectionStart != Textfield_Price.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = Textfield_Price.Text.Substring(Textfield_Price.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(Textfield_Price.Text, ref sepratorChar))
                {
                    int sepratorPosition = Textfield_Price.Text.IndexOf(sepratorChar);
                    string afterSepratorString = Textfield_Price.Text.Substring(sepratorPosition + 1);
                    if (Textfield_Price.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }
    }
}

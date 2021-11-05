using SMD_Water_Station.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend.DialogBoxes
{
    public partial class EditProductInformationDialog : Form
    {
        public EditProductInformationDialog()
        {
            InitializeComponent();
        }

        private void EditProductInformationDialog_Load(object sender, EventArgs e)
        {
            DisplayInformation();
        }

        private void DisplayInformation()
        {
            Label_ProductID.Text = Product.selectedProductID;
            Textfield_Description.Text = Product.selectedProductName;
            Textfield_Price.Text = Product.selectedProductPrice.ToString("0.00");
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Textfield_Description.Text != "" && Textfield_Price.Text != "")
            {
                string updatedDescription = Textfield_Description.Text.Trim();
                double updatedPrice = Convert.ToDouble(Textfield_Price.Text.Trim());

                Product product = new Product();
                product.UpdateProductInformation(updatedDescription, updatedPrice);

                this.Close();

                PageHandler._productsPage.LoadProducts();
            }
            else
            {
                if (Textfield_Description.Text.Trim() == "" || Textfield_Description.Text == null)
                {
                    Label_Desription.ForeColor = Color.Red;

                }

                if (Textfield_Price.Text.Trim() == "" || Textfield_Price.Text.Trim() == null)
                {
                    Label_Price.ForeColor = Color.Red;
                }

                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label_Desription.ForeColor = Color.DimGray;
            Label_Price.ForeColor = Color.DimGray;
            timer1.Enabled = false;
        }

        private void Textfield_Price_TextChanged(object sender, EventArgs e)
        {
            string enteredText = (sender as TextBox).Text;
            int cursorPosition = (sender as TextBox).SelectionStart;

            string[] splitByDecimal = enteredText.Split('.');

            if (splitByDecimal.Length > 1 && splitByDecimal[1].Length > 2)
            {
                (sender as TextBox).Text = enteredText.Remove(enteredText.Length - 1);
                (sender as TextBox).SelectionStart = cursorPosition - 1;
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
    }
}

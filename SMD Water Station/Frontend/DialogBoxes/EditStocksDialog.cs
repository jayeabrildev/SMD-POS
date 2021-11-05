using SMD_Water_Station.Backend.Objects;
using SMD_Water_Station.Classes;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend.DialogBoxes
{
    public partial class EditStocksDialog : Form
    {
        public EditStocksDialog()
        {
            InitializeComponent();
        }

        //Methods
        private void SetInformation()
        {
            Stocks stocks = new Stocks();

            Label_ProductID.Text = Product.selectedProductID;
            Label_Stocks.Text = stocks.GetStocks(Product.selectedProductID).ToString();

            if (stocks.GetStocks(Product.selectedProductID) == 0)
            {
                Rbutton_Deduct.Enabled = false;
            }
            else
            {
                Rbutton_Deduct.Enabled = true;
            }

            if (Rbutton_Add.Checked == true)
            {
                NUD_Stocks.Minimum = 1;
                NUD_Stocks.Maximum = 1000;
            }
            else
            {
                NUD_Stocks.Maximum = stocks.GetStocks(Product.selectedProductID);
            }

            LoadLogOptions();

        }

        private void LoadLogOptions()
        {
            Combobox_log.Items.Clear();
            if (Rbutton_Add.Checked == true)
            {
                Combobox_log.Items.Add("Restock");
                Combobox_log.Items.Add("Correction");
            }
            else
            {
                Combobox_log.Items.Add("Correction");
                Combobox_log.Items.Add("Damaged item");
                Combobox_log.Items.Add("Lost item");
            }
            Combobox_log.SelectedIndex = 0;
        }

        //Events
        private void EditStocksDialog_Load(object sender, EventArgs e)
        {
            SetInformation();
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks();
            if (Rbutton_Add.Checked == true)
            {
                stocks.AddStocks(Convert.ToInt32(NUD_Stocks.Value.ToString()), Product.selectedProductID);

            }
            else
            {
                stocks.DeductStocks(Convert.ToInt32(NUD_Stocks.Value.ToString()), Product.selectedProductID);
            }
            stocks.LogRecord(Product.selectedProductID, Combobox_log.SelectedItem.ToString(), Convert.ToInt32(NUD_Stocks.Value));
            PageHandler._productsPage.LoadStockHistory();
            PageHandler._productsPage.LoadProducts();
            this.Close();

        }

        private void Rbutton_Deduct_CheckedChanged(object sender, EventArgs e)
        {
            SetInformation();
        }
    }
}

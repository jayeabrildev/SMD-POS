using SMD_Water_Station.Backend.Objects;
using SMD_Water_Station.Classes;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station
{
    public partial class ItemSummaryDialog : Form
    {
        public CartContents cart { get; set; }
        public ItemSummaryDialog()
        {
            InitializeComponent();
        }

        //Methods
        private void SetItemProperties()
        {
            //Set description label
            Label_itemDescription.Text = Product.selectedProductName;

            Stocks stocks = new Stocks();
            int itemStocks = stocks.GetStocks(Product.selectedProductID);
            //Set maximum quantity for purchase
            NUD_Quantity.Maximum = itemStocks;
            Label_maxquantity.Text = itemStocks.ToString() + ")";

            //Set price
            Double computedPrice = Product.selectedProductPrice * Convert.ToInt32(NUD_Quantity.Value);
            Label_productPrice.Text = computedPrice.ToString("0.00");

            //Set quantity
            Product.selectedProductQuantity = Convert.ToInt32(NUD_Quantity.Value);
        }

        //Events


        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemSummaryDialog_Load(object sender, EventArgs e)
        {
            SetItemProperties();
        }

        private void NUD_Quantity_ValueChanged(object sender, EventArgs e)
        {
            SetItemProperties();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Stocks stocksCommand = new Stocks();
            stocksCommand.DeductStocks(Convert.ToInt32(NUD_Quantity.Value), Product.selectedProductID);
            Cart.FindSameItem();
            PageHandler._homePage.LoadProducts();
            this.Close();
        }
    }
}

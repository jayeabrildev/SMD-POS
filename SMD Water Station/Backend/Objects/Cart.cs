using SMD_Water_Station.Classes;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station.Backend.Objects
{
    public class Cart
    {
        //Public Fields
        public static double amountTendered;
        public static double grossTotal = 0;
        public static double change;
        public static string cartProductID;
        public static int cartItemQTY;

        //Private Fields
        private static DataGridView cart = PageHandler._homePage.Datagrid_cart;
        private static BindingSource cartBindingSource = PageHandler._homePage.cartContentsBindingSource;

        private static int itemCount = 0;
        private static int rowIndex = -1;
        private static bool sameItemFound;

        //Methods
        public static void FindSameItem()
        {
            sameItemFound = false;
            //Search for same item

            string searchValue = Product.selectedProductName;

            foreach (DataGridViewRow row in cart.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(searchValue))
                {
                    sameItemFound = true;
                    rowIndex = row.Index;
                    break;
                }
                else
                {
                    sameItemFound = false;
                }
            }
            AddToCart();
        }

        private static void AddToCart()
        {
            if (sameItemFound == true)
            {
                int currentQuantity = Convert.ToInt32(cart.Rows[rowIndex].Cells[2].Value.ToString());
                double currentPrice = Convert.ToDouble(cart.Rows[rowIndex].Cells[3].Value.ToString());

                int updatedQuantity = currentQuantity + Product.selectedProductQuantity;
                double updatedPrice = Product.selectedProductPrice * updatedQuantity;
                cart.Rows[rowIndex].SetValues(Product.selectedProductID, Product.selectedProductName, updatedQuantity.ToString(), updatedPrice.ToString("0.00"));
            }
            else
            {
                CartContents cart = new CartContents() { productID = Product.selectedProductID, productName = Product.selectedProductName, productQuantity = Product.selectedProductQuantity, productPrice = Product.selectedProductQuantity * Product.selectedProductPrice };
                cartBindingSource.Add(cart);
                cartBindingSource.MoveLast();
            }

            Summarize();
        }

        public static void Summarize()
        {
            if (cart.Rows.Count == 0)
            {
                grossTotal = 0;
                itemCount = 0;
                PageHandler._homePage.Button_Remove.Enabled = false;
                PageHandler._homePage.Button_Discard.Enabled = false;
                PageHandler._homePage.Button_Checkout.Enabled = false;
            }
            else
            {
                itemCount = 0;
                grossTotal = 0;
                foreach (DataGridViewRow row in cart.Rows)
                {
                    grossTotal += Convert.ToDouble(row.Cells[3].Value);
                    itemCount++;
                }
                PageHandler._homePage.Button_Remove.Enabled = true;
                PageHandler._homePage.Button_Discard.Enabled = true;
                PageHandler._homePage.Button_Checkout.Enabled = true;
            }

            PageHandler._homePage.Label_GrossTotal.Text = grossTotal.ToString("0.00");
            PageHandler._homePage.Label_TotalItems.Text = itemCount.ToString();


        }

        public static void CheckOut()
        {
            Sales sales = new Sales();
            sales.NewSales();
            change = amountTendered - grossTotal;

            Stocks stocks = new Stocks();
            foreach (DataGridViewRow row in PageHandler._homePage.Datagrid_cart.Rows)
            {
                string productid = row.Cells[0].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells[2].Value);

                stocks.LogRecord(productid, "Sales", quantity);
            }
            PageHandler._homePage.InitiateNew();

        }

    }
}

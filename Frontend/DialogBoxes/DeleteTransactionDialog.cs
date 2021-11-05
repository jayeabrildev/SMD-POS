using SMD_Water_Station.Backend.Objects;
using SMD_Water_Station.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend.DialogBoxes
{
    public partial class DeleteTransactionDialog : Form
    {
        public DeleteTransactionDialog()
        {
            InitializeComponent();
        }

        private void Button_Confirm_Click(object sender, System.EventArgs e)
        {
            Sales sales = new Sales();

            using (StringReader reader = new StringReader(Sales.transactionItems))
            using (StringReader reader2 = new StringReader(Sales.itemQuantity))
            {
                string prod;
                string qty;
                while ((prod = reader.ReadLine()) != null && (qty = reader2.ReadLine()) != null)
                {
                    sales.DeleteTransaction(prod, Convert.ToInt32(qty));
                }
            }

            PageHandler._salesPage.LoadSales();
            this.Close();
        }
    }
}

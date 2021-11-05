using SMD_Water_Station.Classes;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station.Views
{
    public partial class MainInterfaceView : Form
    {
        PageHandler pageHandler = new PageHandler();
        bool signout = false;


        public MainInterfaceView()
        {
            InitializeComponent();
        }

        //Methods
        private void ClearVariables()
        {
            Product.selectedProductID = "";
            Product.selectedProductName = "";
            Product.selectedProductPrice = 0;
            Product.selectedProductQuantity = 0;
        }

        //Home
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearVariables();
            pageHandler.Home();
            PageHandler._homePage.LoadProducts();
        }

        //Products Management
        private void productsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearVariables();
            pageHandler.Products();
            PageHandler._productsPage.LoadProducts();
        }

        //Sales Management
        private void salesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageHandler.Sales();
            PageHandler._salesPage.LoadSales();
        }

        //Events
        private void MainInterfaceView_Load(object sender, EventArgs e)
        {
            Account_name.Text = User.fullName;
            pageHandler.Home();
        }

        private void MainInterfaceView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Close = MessageBox.Show("Any unsaved changes will be discarded, Do you wish to proceed?", "SMD Water Station", MessageBoxButtons.YesNo);

            if (Close == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                PageHandler._homePage.DiscardCartContents();
                PageHandler._homePage = null;
                PageHandler._productsPage = null;
                PageHandler._salesPage = null;

                if (signout == true)
                {
                    FormHandler.signIn.Show();
                }
                else
                {
                    FormHandler.signIn.Close();
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            signout = true;
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pageHandler.AccountSettings();
        }
    }
}

using SMD_Water_Station.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Button_Home.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
        }

        private void Form_MainWIndow_Load(object sender, EventArgs e)
        {
            PageHandler pageHandler = new PageHandler();
            pageHandler.mainwindow = this;
            pageHandler.Home();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            PageHandler pageHandler = new PageHandler();
            pageHandler.mainwindow = this;
            pageHandler.Home();
            Button_Home.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
            Button_Inventory.BackgroundColor = Color.Transparent;
            Button_Suppliers.BackgroundColor = Color.Transparent;
            Button_Sales.BackgroundColor = Color.Transparent;
            button_accounts.BackgroundColor = Color.Transparent;
        }

        private void Button_Inventory_Click(object sender, EventArgs e)
        {
            PageHandler pageHandler = new PageHandler();
            pageHandler.mainwindow = this;
            pageHandler.Products();
            Button_Home.BackgroundColor = Color.Transparent;
            Button_Inventory.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
            Button_Suppliers.BackgroundColor = Color.Transparent;
            Button_Sales.BackgroundColor = Color.Transparent;
            button_accounts.BackgroundColor = Color.Transparent;
        }

        private void Button_Suppliers_Click(object sender, EventArgs e)
        {
            PageHandler pageHandler = new PageHandler();
            pageHandler.mainwindow = this;
            pageHandler.Suppliers();
            Button_Home.BackgroundColor = Color.Transparent;
            Button_Inventory.BackgroundColor = Color.Transparent;
            Button_Suppliers.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
            Button_Sales.BackgroundColor = Color.Transparent;
            button_accounts.BackgroundColor = Color.Transparent;
        }

        private void Button_Sales_Click(object sender, EventArgs e)
        {
            PageHandler pageHandler = new PageHandler();
            pageHandler.mainwindow = this;
            pageHandler.Sales();
            Button_Home.BackgroundColor = Color.Transparent;
            Button_Inventory.BackgroundColor = Color.Transparent;
            Button_Suppliers.BackgroundColor = Color.Transparent;
            Button_Sales.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
            button_accounts.BackgroundColor = Color.Transparent;
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button_accounts_Click(object sender, EventArgs e)
        {
            PageHandler pageHandler = new PageHandler();
            pageHandler.mainwindow = this;
            pageHandler.AccountSettings();
            Button_Home.BackgroundColor = Color.Transparent;
            Button_Inventory.BackgroundColor = Color.Transparent;
            Button_Suppliers.BackgroundColor = Color.Transparent;
            Button_Sales.BackgroundColor = Color.Transparent;
            button_accounts.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
        }

        private void button_logout_Click(object sender, EventArgs e)
        { 
                this.Close();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Logout",
               MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                FormHandler.signIn.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

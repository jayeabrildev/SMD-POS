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
        PageHandler pageHandler = new PageHandler();
  

        public MainWindow()
        {
            InitializeComponent();
            Button_Home.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
        }

        private void Form_MainWIndow_Load(object sender, EventArgs e)
        {
            pageHandler.Home();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            pageHandler.Home();
            Button_Home.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
            Button_Inventory.BackgroundColor = Color.Transparent;
            Button_Suppliers.BackgroundColor = Color.Transparent;
            Button_Sales.BackgroundColor = Color.Transparent;
        }

        private void Button_Inventory_Click(object sender, EventArgs e)
        {
            pageHandler.Products();
            Button_Home.BackgroundColor = Color.Transparent;
            Button_Inventory.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
            Button_Suppliers.BackgroundColor = Color.Transparent;
            Button_Sales.BackgroundColor = Color.Transparent;
        }

        private void Button_Suppliers_Click(object sender, EventArgs e)
        {
            pageHandler.Suppliers();
            Button_Home.BackgroundColor = Color.Transparent;
            Button_Inventory.BackgroundColor = Color.Transparent;
            Button_Suppliers.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
            Button_Sales.BackgroundColor = Color.Transparent;
        }

        private void Button_Sales_Click(object sender, EventArgs e)
        {
            pageHandler.Sales();
            Button_Home.BackgroundColor = Color.Transparent;
            Button_Inventory.BackgroundColor = Color.Transparent;
            Button_Suppliers.BackgroundColor = Color.Transparent;
            Button_Sales.BackgroundColor = Color.FromArgb(30, 101, 101, 101);
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

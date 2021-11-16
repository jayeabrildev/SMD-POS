using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_Water_Station.Views.Modals
{
    public partial class Modal_AddToCart : Form
    {
        public string sku;
        public Modal_AddToCart()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Modal_AddToCart_Load(object sender, EventArgs e)
        {
            label_maxQty.Text = "(Max " + nud_qty.Maximum + ")";
        }

    }
}

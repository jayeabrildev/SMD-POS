using Models;
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
    public partial class Modal_NewMaterial : Form
    {

        public Modal_NewMaterial()
        {
            InitializeComponent();
        }

        private void modalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Raw_Material rawMaterial = new Raw_Material();
            rawMaterial.description = textbox_description.Text.TrimEnd();
            rawMaterial.stocks = (int)nud_initialStocks.Value;
            rawMaterial.supplierid = (int)combobox_suppliers.SelectedValue;

            rawMaterial.NewMaterial();
        }

        private void Modal_NewMaterial_Load(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            DataTable suppliersTable = supplier.ListSuppliers();
            if (suppliersTable.Rows.Count >= 1)
            {
                combobox_suppliers.ValueMember = suppliersTable.Columns[0].ToString();
                combobox_suppliers.DisplayMember = suppliersTable.Columns[1].ToString();
                combobox_suppliers.DataSource = suppliersTable;
            }
        }

        private void textbox_description_TextChanged(object sender, EventArgs e)
        {
            if (textbox_description.TextLength == 0 || textbox_description.Text.TrimEnd() == "")
            {
                button_save.Enabled = false;
            }
            else
            {
                if(combobox_suppliers.Items.Count <= 0)
                {
                    button_save.Enabled = false;
                }
                else
                {
                    button_save.Enabled = true;
                }
            }
        }
    }
}

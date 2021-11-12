using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Models;
namespace SMD_Water_Station.Views.Modals
{
    public partial class Modal_UpdateMaterialStocks : Form
    {

        Raw_Material rawMaterial = new Raw_Material();
        public Modal_UpdateMaterialStocks()
        {
            InitializeComponent();
        }

        private void Form_UpdateMaterialStocks_Load(object sender, EventArgs e)
        {
            rawMaterial.LoadMaterialDetails(MaterialsView.selectedMaterial);
            label_currentStocks.Text = rawMaterial.stocks.ToString();
            label_material.Text = rawMaterial.description;

            DisplayOptions();
        }

        private void DisplayOptions()
        {
            combobox_remarks.Items.Clear();
            if(rawMaterial.stocks == 0)
            {
                rb_add.Checked = true;
                rb_deduct.Enabled = false;
            }
            else
            {
                rb_deduct.Enabled = true;
            }
            if(rb_add.Checked == true)
            {
                combobox_remarks.Items.Add("Re-stock");
                combobox_remarks.Items.Add("Correction/Adjustment");
                combobox_remarks.Items.Add("Others");
            }else if(rb_deduct.Checked == true)
            {
                nud_quantity.Maximum = rawMaterial.stocks;
                combobox_remarks.Items.Add("Production");
                combobox_remarks.Items.Add("Damaged Item");
                combobox_remarks.Items.Add("Item loss");
            }
            combobox_remarks.SelectedIndex = 0;
        }

        private void rb_add_CheckedChanged(object sender, EventArgs e)
        {
            DisplayOptions();
        }

        private void rb_deduct_CheckedChanged(object sender, EventArgs e)
        {
            DisplayOptions();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Save changes",
               MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    if(rb_add.Checked == true)
                    {
                        rawMaterial.UpdateStocks(MaterialsView.selectedMaterial, (int)nud_quantity.Value, 1);
                    }else if(rb_deduct.Checked == true)
                    {
                        rawMaterial.UpdateStocks(MaterialsView.selectedMaterial, (int)nud_quantity.Value, 2);
                    }
                    
                    this.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}

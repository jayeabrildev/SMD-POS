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
    public partial class Modal_EditMaterial : Form
    {
        Raw_Material rawMaterial = new Raw_Material();
        
        public string description;
        public int supplierid;

        public Modal_EditMaterial()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Save changes",
               MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    string newDescription = textbox_description.Text.TrimEnd();
                    int supplierID = (int)combobox_supplier.SelectedValue;
                    rawMaterial.EditMaterial(MaterialsView.selectedMaterial, newDescription, supplierID);
                    this.Close();
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        private void textbox_description_TextChanged(object sender, EventArgs e)
        {
            if(textbox_description.TextLength == 0 || textbox_description.Text.TrimEnd() == "")
            {
                button_save.Enabled = false;
            }
            else
            {
                button_save.Enabled = true;
            }
        }

        private void Modal_EditMaterial_Load(object sender, EventArgs e)
        {
            rawMaterial.LoadMaterialDetails(MaterialsView.selectedMaterial);
            textbox_description.Text = rawMaterial.description;

            Supplier supplier = new Supplier();
            DataTable suppliersTable = supplier.ListSuppliers();
            if (suppliersTable.Rows.Count >= 1)
            {
                combobox_supplier.ValueMember = suppliersTable.Columns[0].ToString();
                combobox_supplier.DisplayMember = suppliersTable.Columns[1].ToString();
                combobox_supplier.DataSource = suppliersTable;

                combobox_supplier.SelectedValue = rawMaterial.supplierid;
            }
        }
    }
}

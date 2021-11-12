using SMD_Water_Station.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using SMD_Water_Station.Views.Modals;
using SMD_Water_Station.Views.Forms;

namespace SMD_Water_Station.Views
{
    public partial class MaterialsView : UserControl
    {
        BindingSource materialsBindingSource = new BindingSource();
        DataTable materialsTable = new DataTable();
        Raw_Material rawMaterial = new Raw_Material();
        
        public static int selectedMaterial;

        public MaterialsView()
        {
            InitializeComponent();
        }

        private void SuppliersView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FillTable();
        }

        private void datagrid_suppliers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Set current row
                DataGridViewRow currentRow = datagrid_materials.Rows[e.RowIndex];

                //Fill the properties
                rawMaterial.id = Convert.ToInt32(datagrid_materials.Rows[e.RowIndex].Cells[0].Value);
                rawMaterial.description = datagrid_materials.Rows[e.RowIndex].Cells[1].Value.ToString();
                rawMaterial.stocks = Convert.ToInt32(datagrid_materials.Rows[e.RowIndex].Cells[2].Value);
                rawMaterial.supplierid = Convert.ToInt32(datagrid_materials.Rows[e.RowIndex].Cells[3].Value);

                selectedMaterial = rawMaterial.id;

                //Change label values
                label_materialID.Text = rawMaterial.id.ToString();
                label_description.Text = rawMaterial.description;
                label_supplier.Text = datagrid_materials.Rows[e.RowIndex].Cells[4].Value.ToString();

                label_stocks.Text = rawMaterial.CountStocks(rawMaterial.id).ToString();

                button_editMaterials.Enabled = true;
                button_deleteMaterial.Enabled = true;
                button_updateStocks.Enabled = true;
            }
            else
            {
                button_editMaterials.Enabled = false;
                button_deleteMaterial.Enabled = false;
                button_updateStocks.Enabled = false;
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = materialsTable.DefaultView;
            dataView.RowFilter = string.Format("`description` like '%{0}%'", textbox_search.Text);
            datagrid_materials.DataSource = dataView.ToTable();
        }

        private void button_newSupplier_Click(object sender, EventArgs e)
        {
            Modal_NewMaterial newMaterial = new Modal_NewMaterial();
            newMaterial.ShowDialog(this);
            FillTable();
        }

        private void button_editSupplier_Click(object sender, EventArgs e)
        {
            Modal_EditSupplier editSupplier = new Modal_EditSupplier();
            editSupplier.ShowDialog();
            FillTable();
        }

        private void button_deleteSupplier_Click(object sender, EventArgs e)
        {
            Modal_Delete delete = new Modal_Delete();
            delete.deleteMode = 1;
            delete.ShowDialog();
            FillTable();
        }
    
        private async Task FillTable()
        {
            textbox_search.Clear();

            Raw_Material rawMaterial = new Raw_Material();
            materialsTable = await Task.Run(() => rawMaterial.ListMaterials());

            materialsBindingSource.DataSource = materialsTable;
            datagrid_materials.DataSource = materialsBindingSource;

            datagrid_materials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_materials.Columns[3].Visible = false;
            datagrid_materials.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
   

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_materials, new object[] { true });
        }

        private void button_editMaterials_Click(object sender, EventArgs e)
        {
            Modal_EditMaterial editMaterial = new Modal_EditMaterial();
            editMaterial.ShowDialog();
            FillTable();
        }

        private void button_updateStocks_Click(object sender, EventArgs e)
        {
            Modal_UpdateMaterialStocks updateMaterialStocks = new Modal_UpdateMaterialStocks();
            updateMaterialStocks.ShowDialog();
            FillTable();
        }

        private void button_viewSuppliers_Click(object sender, EventArgs e)
        {
            Form_Suppliers suppliers = new Form_Suppliers();
            suppliers.Show();
        }
    }
}

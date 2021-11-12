using Models;
using SMD_Water_Station.Views.Modals;
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

namespace SMD_Water_Station.Views.Forms
{
    public partial class Form_Suppliers : Form
    {
        public static int selectedSupplier;
        BindingSource suppliersBindingSource = new BindingSource();
        DataTable suppliersTable = new DataTable();
        Supplier supplier = new Supplier();

        public Form_Suppliers()
        {
            InitializeComponent();
        }

        private void Form_Suppliers_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private async Task FillTable()
        {
            textbox_search.Clear();

            Supplier supplier = new Supplier();
            suppliersTable = await Task.Run(() => supplier.ListSuppliers());

            suppliersBindingSource.DataSource = suppliersTable;
            datagrid_suppliers.DataSource = suppliersBindingSource;

            datagrid_suppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_suppliers.Columns[3].Visible = false;
            datagrid_suppliers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_suppliers, new object[] { true });
        }

        private void datagrid_suppliers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Set current row
                DataGridViewRow currentRow = datagrid_suppliers.Rows[e.RowIndex];

                //Fill the properties
                supplier.supplierID = Convert.ToInt32(datagrid_suppliers.Rows[e.RowIndex].Cells[0].Value);
                supplier.supplierName = datagrid_suppliers.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplier.address = datagrid_suppliers.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplier.contact = datagrid_suppliers.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplier.email = datagrid_suppliers.Rows[e.RowIndex].Cells[4].Value.ToString();

                selectedSupplier = supplier.supplierID;

                //Change label values
                label_supplierID.Text = supplier.supplierID.ToString();
                label_supplierName.Text = supplier.supplierName;
                label_address.Text = supplier.address;
                label_contact.Text = supplier.contact;
                label_email.Text = supplier.email;

                label_productsSupplied.Text = supplier.CountSuppliedProducts(supplier.supplierID).ToString();

                button_editSupplier.Enabled = true;
                button_deleteSupplier.Enabled = true;
            }
            else
            {
                button_editSupplier.Enabled = false;
                button_deleteSupplier.Enabled = false;
            }
        }

        private void button_deleteMaterial_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Warning: Deleting a supplier means also deleting it's associated raw materials, do you wish to continue?", "Delete",
              MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                supplier.DeleteSupplier(selectedSupplier);
            }

            FillTable();
        }

        private void button_editMaterials_Click(object sender, EventArgs e)
        {
            Modal_EditSupplier editSupplier = new Modal_EditSupplier();
            editSupplier.ShowDialog();
            FillTable();
        }

        private void button_newSupplier_Click(object sender, EventArgs e)
        {
            Modal_NewSupplier newSupplier = new Modal_NewSupplier();
            newSupplier.ShowDialog();
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = suppliersTable.DefaultView;
            dataView.RowFilter = string.Format("`Supplier name` like '%{0}%'", textbox_search.Text);
            datagrid_suppliers.DataSource = dataView.ToTable();

            switch (datagrid_suppliers.Rows.Count)
            {
                case 0:
                    button_editSupplier.Enabled = false;
                    button_deleteSupplier.Enabled = false;

                    supplier.supplierID = 0;

                    label_supplierID.Text = "----------";
                    label_supplierName.Text = "----------";
                    label_address.Text = "----------";
                    label_contact.Text = "----------";
                    label_email.Text = "----------";

                    break;
                default:
                    button_editSupplier.Enabled = true;
                    button_deleteSupplier.Enabled = true;
                    break;
            }
        }
    }
}

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

namespace SMD_Water_Station.Views
{
    public partial class SuppliersView : UserControl
    {
        PageHandler pageHandler = new PageHandler();
        BindingSource suppliersBindingSource = new BindingSource();
        DataTable suppliersTable = new DataTable();
        Supplier supplier = new Supplier();

        public static int selectedSupplier;

        public SuppliersView()
        {
            InitializeComponent();
        }

        private void SuppliersView_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FillTable();
        }

        private void button_manageProducts_Click(object sender, EventArgs e)
        {
            pageHandler.Products();
        }

        private void datagrid_suppliers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Set current row
                DataGridViewRow currentRow = datagrid_suppliers.Rows[e.RowIndex];

                //Fill the properties
                supplier.supplierID = Convert.ToInt32(datagrid_suppliers.Rows[e.RowIndex].Cells[0].Value.ToString());
                supplier.supplierName = datagrid_suppliers.Rows[e.RowIndex].Cells[1].Value.ToString();

                selectedSupplier = supplier.supplierID;

                //Change label values
                label_supplierID.Text = supplier.supplierID.ToString();
                label_supplierName.Text = supplier.supplierName;
                label_productsSupplied.Text = supplier.CountSuppliedProducts(supplier.supplierID).ToString();
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = suppliersTable.DefaultView;
            dataView.RowFilter = string.Format("`supplier name` like '%{0}%'", textbox_search.Text);
            datagrid_suppliers.DataSource = dataView.ToTable();
        }

        private void button_newSupplier_Click(object sender, EventArgs e)
        {
            Modal_NewSupplier newSupplier = new Modal_NewSupplier();
            newSupplier.ShowDialog(this);
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
            
            Supplier supplier = new Supplier();
            suppliersTable = await Task.Run(() => supplier.ListSuppliers());

            suppliersBindingSource.DataSource = suppliersTable;
            datagrid_suppliers.DataSource = suppliersBindingSource;

            datagrid_suppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_suppliers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
   

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            datagrid_suppliers, new object[] { true });
        }
    }
}


namespace SMD_Water_Station.Views.Forms
{
    partial class Form_Suppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.button_newSupplier = new System.Windows.Forms.Button();
            this.advancedPanel3 = new BevelPanel.AdvancedPanel();
            this.label_productsSupplied = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.advancedPanel2 = new BevelPanel.AdvancedPanel();
            this.datagrid_suppliers = new System.Windows.Forms.DataGridView();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new BevelPanel.AdvancedPanel();
            this.label_email = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_contact = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_address = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_supplierName = new System.Windows.Forms.Label();
            this.label_supplierID = new System.Windows.Forms.Label();
            this.button_deleteSupplier = new System.Windows.Forms.Button();
            this.button_editSupplier = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_export = new System.Windows.Forms.Button();
            this.advancedPanel3.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_suppliers)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Suppliers";
            // 
            // button_newSupplier
            // 
            this.button_newSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_newSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_newSupplier.FlatAppearance.BorderSize = 0;
            this.button_newSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newSupplier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newSupplier.ForeColor = System.Drawing.Color.White;
            this.button_newSupplier.Location = new System.Drawing.Point(859, 615);
            this.button_newSupplier.Name = "button_newSupplier";
            this.button_newSupplier.Size = new System.Drawing.Size(424, 35);
            this.button_newSupplier.TabIndex = 30;
            this.button_newSupplier.Text = "New Supplier";
            this.button_newSupplier.UseVisualStyleBackColor = false;
            this.button_newSupplier.Click += new System.EventHandler(this.button_newSupplier_Click);
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel3.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.label_productsSupplied);
            this.advancedPanel3.Controls.Add(this.label8);
            this.advancedPanel3.EdgeWidth = 1;
            this.advancedPanel3.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.ForeColor = System.Drawing.Color.White;
            this.advancedPanel3.Location = new System.Drawing.Point(859, 474);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 12;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 0;
            this.advancedPanel3.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel3.Size = new System.Drawing.Size(424, 61);
            this.advancedPanel3.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel3.TabIndex = 34;
            // 
            // label_productsSupplied
            // 
            this.label_productsSupplied.AutoSize = true;
            this.label_productsSupplied.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productsSupplied.Location = new System.Drawing.Point(297, 13);
            this.label_productsSupplied.Name = "label_productsSupplied";
            this.label_productsSupplied.Size = new System.Drawing.Size(45, 32);
            this.label_productsSupplied.TabIndex = 23;
            this.label_productsSupplied.Text = "XX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Supplied Materials";
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel2.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.datagrid_suppliers);
            this.advancedPanel2.Controls.Add(this.textbox_search);
            this.advancedPanel2.Controls.Add(this.label12);
            this.advancedPanel2.EdgeWidth = 1;
            this.advancedPanel2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.ForeColor = System.Drawing.Color.White;
            this.advancedPanel2.Location = new System.Drawing.Point(36, 67);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 12;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 0;
            this.advancedPanel2.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel2.Size = new System.Drawing.Size(784, 706);
            this.advancedPanel2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 32;
            // 
            // datagrid_suppliers
            // 
            this.datagrid_suppliers.AllowUserToAddRows = false;
            this.datagrid_suppliers.AllowUserToDeleteRows = false;
            this.datagrid_suppliers.AllowUserToResizeColumns = false;
            this.datagrid_suppliers.AllowUserToResizeRows = false;
            this.datagrid_suppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_suppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.datagrid_suppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_suppliers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.datagrid_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_suppliers.DefaultCellStyle = dataGridViewCellStyle8;
            this.datagrid_suppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid_suppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.datagrid_suppliers.Location = new System.Drawing.Point(18, 50);
            this.datagrid_suppliers.MultiSelect = false;
            this.datagrid_suppliers.Name = "datagrid_suppliers";
            this.datagrid_suppliers.ReadOnly = true;
            this.datagrid_suppliers.RowHeadersVisible = false;
            this.datagrid_suppliers.RowHeadersWidth = 51;
            this.datagrid_suppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_suppliers.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.datagrid_suppliers.RowTemplate.Height = 24;
            this.datagrid_suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_suppliers.Size = new System.Drawing.Size(745, 634);
            this.datagrid_suppliers.TabIndex = 5;
            this.datagrid_suppliers.VirtualMode = true;
            this.datagrid_suppliers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_suppliers_RowEnter);
            // 
            // textbox_search
            // 
            this.textbox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.textbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.White;
            this.textbox_search.Location = new System.Drawing.Point(81, 20);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(274, 24);
            this.textbox_search.TabIndex = 4;
            this.textbox_search.TextChanged += new System.EventHandler(this.textbox_search_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Search";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel1.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.label_email);
            this.advancedPanel1.Controls.Add(this.label11);
            this.advancedPanel1.Controls.Add(this.panel4);
            this.advancedPanel1.Controls.Add(this.label_contact);
            this.advancedPanel1.Controls.Add(this.label9);
            this.advancedPanel1.Controls.Add(this.panel1);
            this.advancedPanel1.Controls.Add(this.label_address);
            this.advancedPanel1.Controls.Add(this.label6);
            this.advancedPanel1.Controls.Add(this.label_supplierName);
            this.advancedPanel1.Controls.Add(this.label_supplierID);
            this.advancedPanel1.Controls.Add(this.button_deleteSupplier);
            this.advancedPanel1.Controls.Add(this.button_editSupplier);
            this.advancedPanel1.Controls.Add(this.panel3);
            this.advancedPanel1.Controls.Add(this.label5);
            this.advancedPanel1.Controls.Add(this.panel2);
            this.advancedPanel1.Controls.Add(this.label4);
            this.advancedPanel1.Controls.Add(this.label1);
            this.advancedPanel1.EdgeWidth = 1;
            this.advancedPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.ForeColor = System.Drawing.Color.White;
            this.advancedPanel1.Location = new System.Drawing.Point(859, 67);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 12;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel1.ShadowShift = 0;
            this.advancedPanel1.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel1.Size = new System.Drawing.Size(424, 387);
            this.advancedPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel1.TabIndex = 33;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(15, 350);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(69, 19);
            this.label_email.TabIndex = 25;
            this.label_email.Text = "----------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Email";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(22, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 1);
            this.panel4.TabIndex = 20;
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.Location = new System.Drawing.Point(15, 292);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(69, 19);
            this.label_contact.TabIndex = 22;
            this.label_contact.Text = "----------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contact number";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(22, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 1);
            this.panel1.TabIndex = 11;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(18, 210);
            this.label_address.MaximumSize = new System.Drawing.Size(0, 170);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(69, 19);
            this.label_address.TabIndex = 19;
            this.label_address.Text = "----------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Address";
            // 
            // label_supplierName
            // 
            this.label_supplierName.AutoSize = true;
            this.label_supplierName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supplierName.Location = new System.Drawing.Point(18, 152);
            this.label_supplierName.Name = "label_supplierName";
            this.label_supplierName.Size = new System.Drawing.Size(69, 19);
            this.label_supplierName.TabIndex = 17;
            this.label_supplierName.Text = "----------";
            // 
            // label_supplierID
            // 
            this.label_supplierID.AutoSize = true;
            this.label_supplierID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supplierID.Location = new System.Drawing.Point(18, 92);
            this.label_supplierID.Name = "label_supplierID";
            this.label_supplierID.Size = new System.Drawing.Size(69, 19);
            this.label_supplierID.TabIndex = 16;
            this.label_supplierID.Text = "----------";
            // 
            // button_deleteSupplier
            // 
            this.button_deleteSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_deleteSupplier.FlatAppearance.BorderSize = 0;
            this.button_deleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteSupplier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteSupplier.ForeColor = System.Drawing.Color.White;
            this.button_deleteSupplier.Location = new System.Drawing.Point(310, 16);
            this.button_deleteSupplier.Name = "button_deleteSupplier";
            this.button_deleteSupplier.Size = new System.Drawing.Size(90, 30);
            this.button_deleteSupplier.TabIndex = 15;
            this.button_deleteSupplier.Text = "Delete";
            this.button_deleteSupplier.UseVisualStyleBackColor = false;
            this.button_deleteSupplier.Click += new System.EventHandler(this.button_deleteMaterial_Click);
            // 
            // button_editSupplier
            // 
            this.button_editSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_editSupplier.FlatAppearance.BorderSize = 0;
            this.button_editSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editSupplier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editSupplier.ForeColor = System.Drawing.Color.White;
            this.button_editSupplier.Location = new System.Drawing.Point(213, 16);
            this.button_editSupplier.Name = "button_editSupplier";
            this.button_editSupplier.Size = new System.Drawing.Size(90, 30);
            this.button_editSupplier.TabIndex = 4;
            this.button_editSupplier.Text = "Edit";
            this.button_editSupplier.UseVisualStyleBackColor = false;
            this.button_editSupplier.Click += new System.EventHandler(this.button_editMaterials_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(22, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 1);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Supplier name";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(22, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 1);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier Details";
            // 
            // button_export
            // 
            this.button_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_export.FlatAppearance.BorderSize = 0;
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_export.ForeColor = System.Drawing.Color.White;
            this.button_export.Location = new System.Drawing.Point(859, 556);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(424, 35);
            this.button_export.TabIndex = 35;
            this.button_export.Text = "Export to Excel";
            this.button_export.UseVisualStyleBackColor = false;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // Form_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1316, 808);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.advancedPanel3);
            this.Controls.Add(this.advancedPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_newSupplier);
            this.Controls.Add(this.advancedPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form_Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Suppliers_Load);
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel3.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_suppliers)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private BevelPanel.AdvancedPanel advancedPanel3;
        private System.Windows.Forms.Label label_productsSupplied;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private BevelPanel.AdvancedPanel advancedPanel2;
        private System.Windows.Forms.DataGridView datagrid_suppliers;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_supplierName;
        private System.Windows.Forms.Label label_supplierID;
        private System.Windows.Forms.Button button_deleteSupplier;
        private System.Windows.Forms.Button button_editSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_newSupplier;
        private BevelPanel.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_export;
    }
}
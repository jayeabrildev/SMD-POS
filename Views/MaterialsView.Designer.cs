
namespace SMD_Water_Station.Views
{
    partial class MaterialsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.button_newMaterial = new System.Windows.Forms.Button();
            this.button_viewSuppliers = new System.Windows.Forms.Button();
            this.advancedPanel3 = new BevelPanel.AdvancedPanel();
            this.label_stocks = new System.Windows.Forms.Label();
            this.button_updateStocks = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.advancedPanel2 = new BevelPanel.AdvancedPanel();
            this.datagrid_materials = new System.Windows.Forms.DataGridView();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new BevelPanel.AdvancedPanel();
            this.label_supplier = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_materialID = new System.Windows.Forms.Label();
            this.button_deleteMaterial = new System.Windows.Forms.Button();
            this.button_editMaterials = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedPanel3.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_materials)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Raw Materials";
            // 
            // button_newMaterial
            // 
            this.button_newMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_newMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_newMaterial.FlatAppearance.BorderSize = 0;
            this.button_newMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newMaterial.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newMaterial.ForeColor = System.Drawing.Color.White;
            this.button_newMaterial.Location = new System.Drawing.Point(909, 452);
            this.button_newMaterial.Name = "button_newMaterial";
            this.button_newMaterial.Size = new System.Drawing.Size(363, 35);
            this.button_newMaterial.TabIndex = 23;
            this.button_newMaterial.Text = "New Material";
            this.button_newMaterial.UseVisualStyleBackColor = false;
            this.button_newMaterial.Click += new System.EventHandler(this.button_newSupplier_Click);
            // 
            // button_viewSuppliers
            // 
            this.button_viewSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_viewSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_viewSuppliers.FlatAppearance.BorderSize = 0;
            this.button_viewSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_viewSuppliers.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewSuppliers.ForeColor = System.Drawing.Color.White;
            this.button_viewSuppliers.Location = new System.Drawing.Point(1067, 19);
            this.button_viewSuppliers.Name = "button_viewSuppliers";
            this.button_viewSuppliers.Size = new System.Drawing.Size(205, 35);
            this.button_viewSuppliers.TabIndex = 29;
            this.button_viewSuppliers.Text = "View Suppliers";
            this.button_viewSuppliers.UseVisualStyleBackColor = false;
            this.button_viewSuppliers.Click += new System.EventHandler(this.button_viewSuppliers_Click);
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel3.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.label_stocks);
            this.advancedPanel3.Controls.Add(this.button_updateStocks);
            this.advancedPanel3.Controls.Add(this.label8);
            this.advancedPanel3.EdgeWidth = 1;
            this.advancedPanel3.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.ForeColor = System.Drawing.Color.White;
            this.advancedPanel3.Location = new System.Drawing.Point(909, 343);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 12;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 0;
            this.advancedPanel3.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel3.Size = new System.Drawing.Size(363, 86);
            this.advancedPanel3.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel3.TabIndex = 28;
            // 
            // label_stocks
            // 
            this.label_stocks.AutoSize = true;
            this.label_stocks.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stocks.Location = new System.Drawing.Point(13, 39);
            this.label_stocks.Name = "label_stocks";
            this.label_stocks.Size = new System.Drawing.Size(45, 32);
            this.label_stocks.TabIndex = 23;
            this.label_stocks.Text = "XX";
            // 
            // button_updateStocks
            // 
            this.button_updateStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_updateStocks.Enabled = false;
            this.button_updateStocks.FlatAppearance.BorderSize = 0;
            this.button_updateStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateStocks.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateStocks.ForeColor = System.Drawing.Color.White;
            this.button_updateStocks.Location = new System.Drawing.Point(185, 28);
            this.button_updateStocks.Name = "button_updateStocks";
            this.button_updateStocks.Size = new System.Drawing.Size(157, 30);
            this.button_updateStocks.TabIndex = 15;
            this.button_updateStocks.Text = "Update";
            this.button_updateStocks.UseVisualStyleBackColor = false;
            this.button_updateStocks.Click += new System.EventHandler(this.button_updateStocks_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Current Stocks";
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel2.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.datagrid_materials);
            this.advancedPanel2.Controls.Add(this.textbox_search);
            this.advancedPanel2.Controls.Add(this.label12);
            this.advancedPanel2.EdgeWidth = 1;
            this.advancedPanel2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.ForeColor = System.Drawing.Color.White;
            this.advancedPanel2.Location = new System.Drawing.Point(25, 66);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 12;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 0;
            this.advancedPanel2.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel2.Size = new System.Drawing.Size(860, 623);
            this.advancedPanel2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 26;
            // 
            // datagrid_materials
            // 
            this.datagrid_materials.AllowUserToAddRows = false;
            this.datagrid_materials.AllowUserToDeleteRows = false;
            this.datagrid_materials.AllowUserToResizeColumns = false;
            this.datagrid_materials.AllowUserToResizeRows = false;
            this.datagrid_materials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_materials.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.datagrid_materials.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_materials.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_materials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_materials.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_materials.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid_materials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.datagrid_materials.Location = new System.Drawing.Point(18, 50);
            this.datagrid_materials.MultiSelect = false;
            this.datagrid_materials.Name = "datagrid_materials";
            this.datagrid_materials.ReadOnly = true;
            this.datagrid_materials.RowHeadersVisible = false;
            this.datagrid_materials.RowHeadersWidth = 51;
            this.datagrid_materials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_materials.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_materials.RowTemplate.Height = 24;
            this.datagrid_materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_materials.Size = new System.Drawing.Size(821, 551);
            this.datagrid_materials.TabIndex = 5;
            this.datagrid_materials.VirtualMode = true;
            this.datagrid_materials.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_suppliers_RowEnter);
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
            this.label12.Size = new System.Drawing.Size(61, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Search";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel1.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.label_supplier);
            this.advancedPanel1.Controls.Add(this.label_description);
            this.advancedPanel1.Controls.Add(this.label_materialID);
            this.advancedPanel1.Controls.Add(this.button_deleteMaterial);
            this.advancedPanel1.Controls.Add(this.button_editMaterials);
            this.advancedPanel1.Controls.Add(this.label6);
            this.advancedPanel1.Controls.Add(this.panel3);
            this.advancedPanel1.Controls.Add(this.label5);
            this.advancedPanel1.Controls.Add(this.panel2);
            this.advancedPanel1.Controls.Add(this.label4);
            this.advancedPanel1.Controls.Add(this.label1);
            this.advancedPanel1.EdgeWidth = 1;
            this.advancedPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.ForeColor = System.Drawing.Color.White;
            this.advancedPanel1.Location = new System.Drawing.Point(909, 66);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 12;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel1.ShadowShift = 0;
            this.advancedPanel1.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel1.Size = new System.Drawing.Size(363, 253);
            this.advancedPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel1.TabIndex = 27;
            // 
            // label_supplier
            // 
            this.label_supplier.AutoSize = true;
            this.label_supplier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supplier.Location = new System.Drawing.Point(18, 210);
            this.label_supplier.Name = "label_supplier";
            this.label_supplier.Size = new System.Drawing.Size(69, 19);
            this.label_supplier.TabIndex = 18;
            this.label_supplier.Text = "----------";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(18, 152);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(69, 19);
            this.label_description.TabIndex = 17;
            this.label_description.Text = "----------";
            // 
            // label_materialID
            // 
            this.label_materialID.AutoSize = true;
            this.label_materialID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_materialID.Location = new System.Drawing.Point(18, 92);
            this.label_materialID.Name = "label_materialID";
            this.label_materialID.Size = new System.Drawing.Size(69, 19);
            this.label_materialID.TabIndex = 16;
            this.label_materialID.Text = "----------";
            // 
            // button_deleteMaterial
            // 
            this.button_deleteMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_deleteMaterial.FlatAppearance.BorderSize = 0;
            this.button_deleteMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteMaterial.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteMaterial.ForeColor = System.Drawing.Color.White;
            this.button_deleteMaterial.Location = new System.Drawing.Point(255, 16);
            this.button_deleteMaterial.Name = "button_deleteMaterial";
            this.button_deleteMaterial.Size = new System.Drawing.Size(90, 30);
            this.button_deleteMaterial.TabIndex = 15;
            this.button_deleteMaterial.Text = "Delete";
            this.button_deleteMaterial.UseVisualStyleBackColor = false;
            this.button_deleteMaterial.Click += new System.EventHandler(this.button_deleteSupplier_Click);
            // 
            // button_editMaterials
            // 
            this.button_editMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_editMaterials.FlatAppearance.BorderSize = 0;
            this.button_editMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editMaterials.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editMaterials.ForeColor = System.Drawing.Color.White;
            this.button_editMaterials.Location = new System.Drawing.Point(158, 16);
            this.button_editMaterials.Name = "button_editMaterials";
            this.button_editMaterials.Size = new System.Drawing.Size(90, 30);
            this.button_editMaterials.TabIndex = 4;
            this.button_editMaterials.Text = "Edit";
            this.button_editMaterials.UseVisualStyleBackColor = false;
            this.button_editMaterials.Click += new System.EventHandler(this.button_editMaterials_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Supplier";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(22, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 1);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(22, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 1);
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
            this.label1.Text = "Material Details";
            // 
            // MaterialsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.button_viewSuppliers);
            this.Controls.Add(this.advancedPanel3);
            this.Controls.Add(this.advancedPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.advancedPanel1);
            this.Controls.Add(this.button_newMaterial);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaterialsView";
            this.Size = new System.Drawing.Size(1292, 721);
            this.Load += new System.EventHandler(this.SuppliersView_Load);
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel3.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_materials)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label label12;
        private BevelPanel.AdvancedPanel advancedPanel2;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_materialID;
        private System.Windows.Forms.Button button_deleteMaterial;
        private System.Windows.Forms.Button button_editMaterials;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BevelPanel.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.Button button_newMaterial;
        private System.Windows.Forms.DataGridView datagrid_materials;
        private System.Windows.Forms.Label label_supplier;
        private System.Windows.Forms.Label label6;
        private BevelPanel.AdvancedPanel advancedPanel3;
        private System.Windows.Forms.Label label_stocks;
        private System.Windows.Forms.Button button_updateStocks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_viewSuppliers;
    }
}

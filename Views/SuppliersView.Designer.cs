
namespace SMD_Water_Station.Views
{
    partial class SuppliersView
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
            this.button_newSupplier = new System.Windows.Forms.Button();
            this.advancedPanel2 = new BevelPanel.AdvancedPanel();
            this.datagrid_suppliers = new System.Windows.Forms.DataGridView();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new BevelPanel.AdvancedPanel();
            this.label_productsSupplied = new System.Windows.Forms.Label();
            this.label_supplierName = new System.Windows.Forms.Label();
            this.label_supplierID = new System.Windows.Forms.Label();
            this.button_deleteSupplier = new System.Windows.Forms.Button();
            this.button_editSupplier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_suppliers)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Supplier Management";
            // 
            // button_newSupplier
            // 
            this.button_newSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_newSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_newSupplier.FlatAppearance.BorderSize = 0;
            this.button_newSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newSupplier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newSupplier.ForeColor = System.Drawing.Color.White;
            this.button_newSupplier.Location = new System.Drawing.Point(909, 336);
            this.button_newSupplier.Name = "button_newSupplier";
            this.button_newSupplier.Size = new System.Drawing.Size(363, 35);
            this.button_newSupplier.TabIndex = 23;
            this.button_newSupplier.Text = "New Supplier";
            this.button_newSupplier.UseVisualStyleBackColor = false;
            this.button_newSupplier.Click += new System.EventHandler(this.button_newSupplier_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_suppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_suppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid_suppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.datagrid_suppliers.Location = new System.Drawing.Point(18, 50);
            this.datagrid_suppliers.MultiSelect = false;
            this.datagrid_suppliers.Name = "datagrid_suppliers";
            this.datagrid_suppliers.ReadOnly = true;
            this.datagrid_suppliers.RowHeadersVisible = false;
            this.datagrid_suppliers.RowHeadersWidth = 51;
            this.datagrid_suppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_suppliers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_suppliers.RowTemplate.Height = 24;
            this.datagrid_suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_suppliers.Size = new System.Drawing.Size(821, 551);
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
            this.label12.Size = new System.Drawing.Size(61, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Search";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel1.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.label_productsSupplied);
            this.advancedPanel1.Controls.Add(this.label_supplierName);
            this.advancedPanel1.Controls.Add(this.label_supplierID);
            this.advancedPanel1.Controls.Add(this.button_deleteSupplier);
            this.advancedPanel1.Controls.Add(this.button_editSupplier);
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
            // label_productsSupplied
            // 
            this.label_productsSupplied.AutoSize = true;
            this.label_productsSupplied.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productsSupplied.Location = new System.Drawing.Point(18, 210);
            this.label_productsSupplied.Name = "label_productsSupplied";
            this.label_productsSupplied.Size = new System.Drawing.Size(69, 19);
            this.label_productsSupplied.TabIndex = 18;
            this.label_productsSupplied.Text = "----------";
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
            this.button_deleteSupplier.Location = new System.Drawing.Point(255, 16);
            this.button_deleteSupplier.Name = "button_deleteSupplier";
            this.button_deleteSupplier.Size = new System.Drawing.Size(90, 30);
            this.button_deleteSupplier.TabIndex = 15;
            this.button_deleteSupplier.Text = "Delete";
            this.button_deleteSupplier.UseVisualStyleBackColor = false;
            this.button_deleteSupplier.Click += new System.EventHandler(this.button_deleteSupplier_Click);
            // 
            // button_editSupplier
            // 
            this.button_editSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_editSupplier.FlatAppearance.BorderSize = 0;
            this.button_editSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editSupplier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editSupplier.ForeColor = System.Drawing.Color.White;
            this.button_editSupplier.Location = new System.Drawing.Point(158, 16);
            this.button_editSupplier.Name = "button_editSupplier";
            this.button_editSupplier.Size = new System.Drawing.Size(90, 30);
            this.button_editSupplier.TabIndex = 4;
            this.button_editSupplier.Text = "Edit";
            this.button_editSupplier.UseVisualStyleBackColor = false;
            this.button_editSupplier.Click += new System.EventHandler(this.button_editSupplier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Products supplied";
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
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Supplier name";
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
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Supplier ID";
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
            // SuppliersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.advancedPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.advancedPanel1);
            this.Controls.Add(this.button_newSupplier);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SuppliersView";
            this.Size = new System.Drawing.Size(1292, 721);
            this.Load += new System.EventHandler(this.SuppliersView_Load);
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_suppliers)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label label12;
        private BevelPanel.AdvancedPanel advancedPanel2;
        private System.Windows.Forms.Label label_productsSupplied;
        private System.Windows.Forms.Label label_supplierName;
        private System.Windows.Forms.Label label_supplierID;
        private System.Windows.Forms.Button button_deleteSupplier;
        private System.Windows.Forms.Button button_editSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BevelPanel.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.Button button_newSupplier;
        private System.Windows.Forms.DataGridView datagrid_suppliers;
    }
}

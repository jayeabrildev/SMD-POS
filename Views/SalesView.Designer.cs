
namespace SMD_Water_Station.Views
{
    partial class SalesView
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
            this.button_editProduct = new System.Windows.Forms.Button();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_average = new System.Windows.Forms.Label();
            this.label_todaysales = new System.Windows.Forms.Label();
            this.label_sales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_totalsales = new System.Windows.Forms.Label();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.advancedPanel4 = new BevelPanel.AdvancedPanel();
            this.datagrid_sales = new System.Windows.Forms.DataGridView();
            this.advancedPanel2 = new BevelPanel.AdvancedPanel();
            this.cartesian_sales = new LiveCharts.WinForms.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_sales)).BeginInit();
            this.advancedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_editProduct
            // 
            this.button_editProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_editProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_editProduct.FlatAppearance.BorderSize = 0;
            this.button_editProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editProduct.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editProduct.ForeColor = System.Drawing.Color.White;
            this.button_editProduct.Location = new System.Drawing.Point(29, 381);
            this.button_editProduct.Name = "button_editProduct";
            this.button_editProduct.Size = new System.Drawing.Size(207, 30);
            this.button_editProduct.TabIndex = 26;
            this.button_editProduct.Text = "Export to Excel";
            this.button_editProduct.UseVisualStyleBackColor = false;
            this.button_editProduct.Click += new System.EventHandler(this.button_editProduct_Click);
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(307, 21);
            this.dtp_start.MaxDate = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(127, 25);
            this.dtp_start.TabIndex = 27;
            this.dtp_start.Value = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(451, 22);
            this.dtp_end.MaxDate = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(127, 25);
            this.dtp_end.TabIndex = 28;
            this.dtp_end.Value = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Range";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Daily Average";
            // 
            // label_average
            // 
            this.label_average.AutoSize = true;
            this.label_average.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_average.Location = new System.Drawing.Point(23, 126);
            this.label_average.Name = "label_average";
            this.label_average.Size = new System.Drawing.Size(94, 25);
            this.label_average.TabIndex = 6;
            this.label_average.Text = "PHP 0.00";
            // 
            // label_todaysales
            // 
            this.label_todaysales.AutoSize = true;
            this.label_todaysales.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_todaysales.Location = new System.Drawing.Point(23, 74);
            this.label_todaysales.Name = "label_todaysales";
            this.label_todaysales.Size = new System.Drawing.Size(94, 25);
            this.label_todaysales.TabIndex = 5;
            this.label_todaysales.Text = "PHP 0.00";
            // 
            // label_sales
            // 
            this.label_sales.AutoSize = true;
            this.label_sales.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sales.Location = new System.Drawing.Point(25, 54);
            this.label_sales.Name = "label_sales";
            this.label_sales.Size = new System.Drawing.Size(46, 19);
            this.label_sales.TabIndex = 4;
            this.label_sales.Text = "Today";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total Sales";
            // 
            // label_totalsales
            // 
            this.label_totalsales.AutoSize = true;
            this.label_totalsales.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalsales.Location = new System.Drawing.Point(23, 178);
            this.label_totalsales.Name = "label_totalsales";
            this.label_totalsales.Size = new System.Drawing.Size(94, 25);
            this.label_totalsales.TabIndex = 31;
            this.label_totalsales.Text = "PHP 0.00";
            // 
            // textbox_search
            // 
            this.textbox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.textbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.White;
            this.textbox_search.Location = new System.Drawing.Point(980, 21);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(274, 24);
            this.textbox_search.TabIndex = 34;
            this.textbox_search.TextChanged += new System.EventHandler(this.textbox_search_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(891, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Ref. number";
            // 
            // advancedPanel4
            // 
            this.advancedPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel4.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel4.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel4.Controls.Add(this.datagrid_sales);
            this.advancedPanel4.EdgeWidth = 1;
            this.advancedPanel4.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.ForeColor = System.Drawing.Color.White;
            this.advancedPanel4.Location = new System.Drawing.Point(253, 54);
            this.advancedPanel4.Name = "advancedPanel4";
            this.advancedPanel4.RectRadius = 12;
            this.advancedPanel4.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel4.ShadowShift = 0;
            this.advancedPanel4.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel4.Size = new System.Drawing.Size(1001, 397);
            this.advancedPanel4.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel4.TabIndex = 26;
            // 
            // datagrid_sales
            // 
            this.datagrid_sales.AllowUserToAddRows = false;
            this.datagrid_sales.AllowUserToDeleteRows = false;
            this.datagrid_sales.AllowUserToResizeColumns = false;
            this.datagrid_sales.AllowUserToResizeRows = false;
            this.datagrid_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_sales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.datagrid_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_sales.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_sales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid_sales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.datagrid_sales.Location = new System.Drawing.Point(14, 16);
            this.datagrid_sales.MultiSelect = false;
            this.datagrid_sales.Name = "datagrid_sales";
            this.datagrid_sales.ReadOnly = true;
            this.datagrid_sales.RowHeadersVisible = false;
            this.datagrid_sales.RowHeadersWidth = 51;
            this.datagrid_sales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_sales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_sales.RowTemplate.Height = 24;
            this.datagrid_sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_sales.Size = new System.Drawing.Size(972, 365);
            this.datagrid_sales.TabIndex = 5;
            this.datagrid_sales.VirtualMode = true;
            this.datagrid_sales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_sales_CellClick);
            this.datagrid_sales.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_sales_RowEnter);
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel2.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.cartesian_sales);
            this.advancedPanel2.Controls.Add(this.label3);
            this.advancedPanel2.EdgeWidth = 1;
            this.advancedPanel2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.ForeColor = System.Drawing.Color.White;
            this.advancedPanel2.Location = new System.Drawing.Point(252, 473);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 12;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 0;
            this.advancedPanel2.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel2.Size = new System.Drawing.Size(1002, 222);
            this.advancedPanel2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 25;
            // 
            // cartesian_sales
            // 
            this.cartesian_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesian_sales.CausesValidation = false;
            this.cartesian_sales.Location = new System.Drawing.Point(21, 48);
            this.cartesian_sales.Name = "cartesian_sales";
            this.cartesian_sales.Size = new System.Drawing.Size(956, 165);
            this.cartesian_sales.TabIndex = 5;
            this.cartesian_sales.Text = "cartesianChart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monthly Overview";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = global::SMD_Water_Station.Properties.Resources.SMDLOGO_Large;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(32, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 35;
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_totalsales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_todaysales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_sales);
            this.Controls.Add(this.label_average);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.button_editProduct);
            this.Controls.Add(this.advancedPanel4);
            this.Controls.Add(this.advancedPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SalesView";
            this.Size = new System.Drawing.Size(1277, 721);
            this.Load += new System.EventHandler(this.SalesView_Load);
            this.advancedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_sales)).EndInit();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_todaysales;
        private System.Windows.Forms.Label label_sales;
        private System.Windows.Forms.Button button_editProduct;
        private BevelPanel.AdvancedPanel advancedPanel4;
        private System.Windows.Forms.DataGridView datagrid_sales;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_average;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_totalsales;
        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.CartesianChart cartesian_sales;
        private BevelPanel.AdvancedPanel advancedPanel2;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
    }
}

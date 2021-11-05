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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Chart_Today = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panel_Today = new BevelPanel.AdvancedPanel();
            this.Label_Today_ItemsSold = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Label_Today_GrossSales = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Icon_Today = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.advancedPanel2 = new BevelPanel.AdvancedPanel();
            this.Link_DeleteTransaction = new System.Windows.Forms.LinkLabel();
            this.Datagrid_Items = new System.Windows.Forms.DataGridView();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label_IssuedBy = new System.Windows.Forms.Label();
            this.Label_DateIssued = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Label_SalesID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedPanel1 = new BevelPanel.AdvancedPanel();
            this.Label_TotalGross = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Icon_Search = new System.Windows.Forms.Panel();
            this.Textbox_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Datagrid_Sales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Today)).BeginInit();
            this.Panel_Today.SuspendLayout();
            this.advancedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Items)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 20);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 683);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1330, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 683);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(20, 683);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1310, 20);
            this.panel4.TabIndex = 4;
            // 
            // Chart_Today
            // 
            chartArea4.Name = "ChartArea1";
            this.Chart_Today.ChartAreas.Add(chartArea4);
            this.Chart_Today.Location = new System.Drawing.Point(920, 253);
            this.Chart_Today.Name = "Chart_Today";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.IsVisibleInLegend = false;
            series4.Name = "Gross Sales";
            this.Chart_Today.Series.Add(series4);
            this.Chart_Today.Size = new System.Drawing.Size(400, 403);
            this.Chart_Today.TabIndex = 19;
            this.Chart_Today.Text = "chart1";
            // 
            // Panel_Today
            // 
            this.Panel_Today.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.Panel_Today.Controls.Add(this.Label_TotalGross);
            this.Panel_Today.Controls.Add(this.Label_Today_ItemsSold);
            this.Panel_Today.Controls.Add(this.label14);
            this.Panel_Today.Controls.Add(this.label9);
            this.Panel_Today.Controls.Add(this.label15);
            this.Panel_Today.Controls.Add(this.Label_Today_GrossSales);
            this.Panel_Today.Controls.Add(this.label11);
            this.Panel_Today.Controls.Add(this.Icon_Today);
            this.Panel_Today.Controls.Add(this.label12);
            this.Panel_Today.Controls.Add(this.label13);
            this.Panel_Today.EdgeWidth = 1;
            this.Panel_Today.EndColor = System.Drawing.Color.White;
            this.Panel_Today.FlatBorderColor = System.Drawing.Color.Silver;
            this.Panel_Today.Location = new System.Drawing.Point(938, 52);
            this.Panel_Today.Name = "Panel_Today";
            this.Panel_Today.RectRadius = 10;
            this.Panel_Today.ShadowColor = System.Drawing.Color.Silver;
            this.Panel_Today.ShadowShift = 3;
            this.Panel_Today.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.Panel_Today.Size = new System.Drawing.Size(368, 195);
            this.Panel_Today.StartColor = System.Drawing.Color.White;
            this.Panel_Today.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.Panel_Today.TabIndex = 20;
            // 
            // Label_Today_ItemsSold
            // 
            this.Label_Today_ItemsSold.AutoSize = true;
            this.Label_Today_ItemsSold.BackColor = System.Drawing.Color.White;
            this.Label_Today_ItemsSold.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Today_ItemsSold.ForeColor = System.Drawing.Color.Black;
            this.Label_Today_ItemsSold.Location = new System.Drawing.Point(58, 140);
            this.Label_Today_ItemsSold.Name = "Label_Today_ItemsSold";
            this.Label_Today_ItemsSold.Size = new System.Drawing.Size(44, 19);
            this.Label_Today_ItemsSold.TabIndex = 10;
            this.Label_Today_ItemsSold.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(38, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Items sold";
            // 
            // Label_Today_GrossSales
            // 
            this.Label_Today_GrossSales.AutoSize = true;
            this.Label_Today_GrossSales.BackColor = System.Drawing.Color.White;
            this.Label_Today_GrossSales.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Today_GrossSales.ForeColor = System.Drawing.Color.Black;
            this.Label_Today_GrossSales.Location = new System.Drawing.Point(100, 86);
            this.Label_Today_GrossSales.Name = "Label_Today_GrossSales";
            this.Label_Today_GrossSales.Size = new System.Drawing.Size(44, 19);
            this.Label_Today_GrossSales.TabIndex = 7;
            this.Label_Today_GrossSales.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(47, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Today";
            // 
            // Icon_Today
            // 
            this.Icon_Today.BackColor = System.Drawing.Color.Transparent;
            this.Icon_Today.BackgroundImage = global::SMD_Water_Station.Properties.Resources.ViewDay_Black;
            this.Icon_Today.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon_Today.Location = new System.Drawing.Point(25, 26);
            this.Icon_Today.Name = "Icon_Today";
            this.Icon_Today.Size = new System.Drawing.Size(20, 20);
            this.Icon_Today.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(58, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "PHP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(38, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 14);
            this.label13.TabIndex = 3;
            this.label13.Text = "Gross Sales";
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.Link_DeleteTransaction);
            this.advancedPanel2.Controls.Add(this.Datagrid_Items);
            this.advancedPanel2.Controls.Add(this.Label_IssuedBy);
            this.advancedPanel2.Controls.Add(this.Label_DateIssued);
            this.advancedPanel2.Controls.Add(this.panel5);
            this.advancedPanel2.Controls.Add(this.Label_SalesID);
            this.advancedPanel2.Controls.Add(this.label5);
            this.advancedPanel2.Controls.Add(this.label4);
            this.advancedPanel2.Controls.Add(this.label3);
            this.advancedPanel2.Controls.Add(this.label2);
            this.advancedPanel2.Controls.Add(this.label1);
            this.advancedPanel2.EdgeWidth = 2;
            this.advancedPanel2.EndColor = System.Drawing.Color.White;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.Gainsboro;
            this.advancedPanel2.Location = new System.Drawing.Point(578, 52);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 10;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.LightGray;
            this.advancedPanel2.ShadowShift = 3;
            this.advancedPanel2.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.advancedPanel2.Size = new System.Drawing.Size(340, 604);
            this.advancedPanel2.StartColor = System.Drawing.Color.White;
            this.advancedPanel2.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 16;
            // 
            // Link_DeleteTransaction
            // 
            this.Link_DeleteTransaction.AutoSize = true;
            this.Link_DeleteTransaction.Location = new System.Drawing.Point(192, 102);
            this.Link_DeleteTransaction.Name = "Link_DeleteTransaction";
            this.Link_DeleteTransaction.Size = new System.Drawing.Size(116, 17);
            this.Link_DeleteTransaction.TabIndex = 17;
            this.Link_DeleteTransaction.TabStop = true;
            this.Link_DeleteTransaction.Text = "Delete Transaction";
            this.Link_DeleteTransaction.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_DeleteTransaction_LinkClicked);
            // 
            // Datagrid_Items
            // 
            this.Datagrid_Items.AllowUserToAddRows = false;
            this.Datagrid_Items.AllowUserToDeleteRows = false;
            this.Datagrid_Items.AllowUserToResizeColumns = false;
            this.Datagrid_Items.AllowUserToResizeRows = false;
            this.Datagrid_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datagrid_Items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Datagrid_Items.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_Items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_Items.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Datagrid_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Datagrid_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_Items.ColumnHeadersVisible = false;
            this.Datagrid_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Items,
            this.Quantity});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_Items.DefaultCellStyle = dataGridViewCellStyle20;
            this.Datagrid_Items.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Datagrid_Items.Location = new System.Drawing.Point(28, 253);
            this.Datagrid_Items.Name = "Datagrid_Items";
            this.Datagrid_Items.ReadOnly = true;
            this.Datagrid_Items.RowHeadersVisible = false;
            this.Datagrid_Items.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_Items.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.Datagrid_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_Items.Size = new System.Drawing.Size(280, 327);
            this.Datagrid_Items.TabIndex = 16;
            // 
            // Items
            // 
            this.Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Items.Frozen = true;
            this.Items.HeaderText = "Items";
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "QTY";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Label_IssuedBy
            // 
            this.Label_IssuedBy.AutoSize = true;
            this.Label_IssuedBy.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_IssuedBy.Location = new System.Drawing.Point(40, 206);
            this.Label_IssuedBy.Name = "Label_IssuedBy";
            this.Label_IssuedBy.Size = new System.Drawing.Size(71, 17);
            this.Label_IssuedBy.TabIndex = 9;
            this.Label_IssuedBy.Text = "000000000";
            // 
            // Label_DateIssued
            // 
            this.Label_DateIssued.AutoSize = true;
            this.Label_DateIssued.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DateIssued.Location = new System.Drawing.Point(40, 154);
            this.Label_DateIssued.Name = "Label_DateIssued";
            this.Label_DateIssued.Size = new System.Drawing.Size(72, 17);
            this.Label_DateIssued.TabIndex = 8;
            this.Label_DateIssued.Text = "00-00-0000";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(28, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 1);
            this.panel5.TabIndex = 7;
            // 
            // Label_SalesID
            // 
            this.Label_SalesID.AutoSize = true;
            this.Label_SalesID.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SalesID.Location = new System.Drawing.Point(40, 102);
            this.Label_SalesID.Name = "Label_SalesID";
            this.Label_SalesID.Size = new System.Drawing.Size(71, 17);
            this.Label_SalesID.TabIndex = 6;
            this.Label_SalesID.Text = "000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(31, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Issued by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(31, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date issued";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Information";
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.Icon_Search);
            this.advancedPanel1.Controls.Add(this.Textbox_search);
            this.advancedPanel1.Controls.Add(this.Datagrid_Sales);
            this.advancedPanel1.EdgeWidth = 2;
            this.advancedPanel1.EndColor = System.Drawing.Color.White;
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.Gainsboro;
            this.advancedPanel1.Location = new System.Drawing.Point(53, 52);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 10;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.LightGray;
            this.advancedPanel1.ShadowShift = 3;
            this.advancedPanel1.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.advancedPanel1.Size = new System.Drawing.Size(507, 604);
            this.advancedPanel1.StartColor = System.Drawing.Color.White;
            this.advancedPanel1.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel1.TabIndex = 5;
            // 
            // Label_TotalGross
            // 
            this.Label_TotalGross.AutoSize = true;
            this.Label_TotalGross.BackColor = System.Drawing.Color.White;
            this.Label_TotalGross.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalGross.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalGross.Location = new System.Drawing.Point(259, 85);
            this.Label_TotalGross.Name = "Label_TotalGross";
            this.Label_TotalGross.Size = new System.Drawing.Size(44, 19);
            this.Label_TotalGross.TabIndex = 26;
            this.Label_TotalGross.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(217, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 19);
            this.label14.TabIndex = 25;
            this.label14.Text = "PHP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(197, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 14);
            this.label15.TabIndex = 24;
            this.label15.Text = "Total Gross Sales";
            // 
            // Icon_Search
            // 
            this.Icon_Search.BackgroundImage = global::SMD_Water_Station.Properties.Resources.icons8_search_100;
            this.Icon_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon_Search.Location = new System.Drawing.Point(40, 48);
            this.Icon_Search.Name = "Icon_Search";
            this.Icon_Search.Size = new System.Drawing.Size(20, 20);
            this.Icon_Search.TabIndex = 14;
            // 
            // Textbox_search
            // 
            this.Textbox_search.Depth = 0;
            this.Textbox_search.Hint = "Sales ID";
            this.Textbox_search.Location = new System.Drawing.Point(68, 46);
            this.Textbox_search.MaxLength = 32767;
            this.Textbox_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_search.Name = "Textbox_search";
            this.Textbox_search.PasswordChar = '\0';
            this.Textbox_search.SelectedText = "";
            this.Textbox_search.SelectionLength = 0;
            this.Textbox_search.SelectionStart = 0;
            this.Textbox_search.Size = new System.Drawing.Size(152, 23);
            this.Textbox_search.TabIndex = 15;
            this.Textbox_search.TabStop = false;
            this.Textbox_search.UseSystemPasswordChar = false;
            this.Textbox_search.Enter += new System.EventHandler(this.Textbox_search_Enter);
            // 
            // Datagrid_Sales
            // 
            this.Datagrid_Sales.AllowUserToAddRows = false;
            this.Datagrid_Sales.AllowUserToDeleteRows = false;
            this.Datagrid_Sales.AllowUserToResizeColumns = false;
            this.Datagrid_Sales.AllowUserToResizeRows = false;
            this.Datagrid_Sales.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_Sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_Sales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_Sales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Datagrid_Sales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_Sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.Datagrid_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_Sales.DefaultCellStyle = dataGridViewCellStyle23;
            this.Datagrid_Sales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Datagrid_Sales.Location = new System.Drawing.Point(39, 79);
            this.Datagrid_Sales.Name = "Datagrid_Sales";
            this.Datagrid_Sales.ReadOnly = true;
            this.Datagrid_Sales.RowHeadersVisible = false;
            this.Datagrid_Sales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_Sales.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.Datagrid_Sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_Sales.Size = new System.Drawing.Size(430, 501);
            this.Datagrid_Sales.TabIndex = 2;
            this.Datagrid_Sales.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_Sales_RowEnter);
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 703);
            this.Controls.Add(this.Panel_Today);
            this.Controls.Add(this.Chart_Today);
            this.Controls.Add(this.advancedPanel2);
            this.Controls.Add(this.advancedPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesView";
            this.Load += new System.EventHandler(this.SalesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Today)).EndInit();
            this.Panel_Today.ResumeLayout(false);
            this.Panel_Today.PerformLayout();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Items)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_Sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private BevelPanel.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.Panel Icon_Search;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_search;
        private BevelPanel.AdvancedPanel advancedPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_SalesID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Label_IssuedBy;
        private System.Windows.Forms.Label Label_DateIssued;
        private System.Windows.Forms.LinkLabel Link_DeleteTransaction;
        public System.Windows.Forms.DataGridView Datagrid_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        public System.Windows.Forms.DataVisualization.Charting.Chart Chart_Today;
        private BevelPanel.AdvancedPanel Panel_Today;
        private System.Windows.Forms.Label Label_Today_ItemsSold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Label_Today_GrossSales;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel Icon_Today;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Label_TotalGross;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView Datagrid_Sales;
    }
}
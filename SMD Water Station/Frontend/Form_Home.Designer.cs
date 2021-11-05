namespace SMD_Water_Station.Views
{
    partial class HomeView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_Checkout = new System.Windows.Forms.Button();
            this.Button_Discard = new System.Windows.Forms.Button();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Button_add = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Sales_Today_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advancedPanel2 = new BevelPanel.AdvancedPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advancedPanel4 = new BevelPanel.AdvancedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.advancedPanel3 = new BevelPanel.AdvancedPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.Label_TotalItems = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Label_GrossTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.Datagrid_cart = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartContentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advancedPanel1 = new BevelPanel.AdvancedPanel();
            this.Panel_items = new System.Windows.Forms.Panel();
            this.advancedPanel6 = new BevelPanel.AdvancedPanel();
            this.Label_viewHiddenItems = new System.Windows.Forms.LinkLabel();
            this.Label_HiddenItems = new System.Windows.Forms.Label();
            this.Label_DisplayedItems = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.advancedPanel5 = new BevelPanel.AdvancedPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.Checkbox_DisplayLowStocks = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Icon_Search = new System.Windows.Forms.Panel();
            this.Textbox_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Datagrid_items = new System.Windows.Forms.DataGridView();
            this.Panel_Today = new BevelPanel.AdvancedPanel();
            this.Label_ItemsSoldToday = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_GrossSalesToday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Icon_Today = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sales_Today_BindingSource)).BeginInit();
            this.advancedPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.advancedPanel4.SuspendLayout();
            this.advancedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartContentsBindingSource)).BeginInit();
            this.advancedPanel1.SuspendLayout();
            this.Panel_items.SuspendLayout();
            this.advancedPanel6.SuspendLayout();
            this.advancedPanel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_items)).BeginInit();
            this.Panel_Today.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Remove
            // 
            this.Button_Remove.BackgroundImage = global::SMD_Water_Station.Properties.Resources.baseline_remove_circle_black_48dp;
            this.Button_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Remove.Enabled = false;
            this.Button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Remove.Location = new System.Drawing.Point(15, 32);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(30, 30);
            this.Button_Remove.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Button_Remove, "Remove Item");
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Checkout
            // 
            this.Button_Checkout.BackgroundImage = global::SMD_Water_Station.Properties.Resources.baseline_local_grocery_store_black_48dp;
            this.Button_Checkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Checkout.Enabled = false;
            this.Button_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Checkout.Location = new System.Drawing.Point(15, 70);
            this.Button_Checkout.Name = "Button_Checkout";
            this.Button_Checkout.Size = new System.Drawing.Size(30, 30);
            this.Button_Checkout.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Button_Checkout, "Checkout");
            this.Button_Checkout.UseVisualStyleBackColor = true;
            this.Button_Checkout.Click += new System.EventHandler(this.Button_Checkout_Click);
            // 
            // Button_Discard
            // 
            this.Button_Discard.BackgroundImage = global::SMD_Water_Station.Properties.Resources.Delete_Black;
            this.Button_Discard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Discard.Enabled = false;
            this.Button_Discard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Discard.Location = new System.Drawing.Point(54, 32);
            this.Button_Discard.Name = "Button_Discard";
            this.Button_Discard.Size = new System.Drawing.Size(30, 30);
            this.Button_Discard.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Button_Discard, "Discard Items");
            this.Button_Discard.UseVisualStyleBackColor = true;
            this.Button_Discard.Click += new System.EventHandler(this.Button_Discard_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.BackgroundImage = global::SMD_Water_Station.Properties.Resources.round_cached_black_48dp;
            this.Button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Refresh.Location = new System.Drawing.Point(51, 32);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(30, 30);
            this.Button_Refresh.TabIndex = 16;
            this.toolTip1.SetToolTip(this.Button_Refresh, "Refresh");
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Button_add
            // 
            this.Button_add.BackgroundImage = global::SMD_Water_Station.Properties.Resources.AddCircle_Black;
            this.Button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_add.Location = new System.Drawing.Point(15, 32);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(30, 30);
            this.Button_add.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Button_add, "Add");
            this.Button_add.UseVisualStyleBackColor = true;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.panel7);
            this.advancedPanel2.EdgeWidth = 1;
            this.advancedPanel2.EndColor = System.Drawing.Color.White;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel2.Location = new System.Drawing.Point(859, 5);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 10;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.Silver;
            this.advancedPanel2.ShadowShift = 3;
            this.advancedPanel2.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.advancedPanel2.Size = new System.Drawing.Size(474, 686);
            this.advancedPanel2.StartColor = System.Drawing.Color.White;
            this.advancedPanel2.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.advancedPanel4);
            this.panel7.Controls.Add(this.advancedPanel3);
            this.panel7.Controls.Add(this.Datagrid_cart);
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(17, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(440, 649);
            this.panel7.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 50);
            this.panel5.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order Summary";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 49);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(440, 1);
            this.panel8.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(25, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 1);
            this.panel1.TabIndex = 11;
            // 
            // advancedPanel4
            // 
            this.advancedPanel4.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel4.Controls.Add(this.label6);
            this.advancedPanel4.Controls.Add(this.Button_Remove);
            this.advancedPanel4.Controls.Add(this.Button_Checkout);
            this.advancedPanel4.Controls.Add(this.Button_Discard);
            this.advancedPanel4.EdgeWidth = 1;
            this.advancedPanel4.EndColor = System.Drawing.Color.White;
            this.advancedPanel4.FlatBorderColor = System.Drawing.Color.LightGray;
            this.advancedPanel4.Location = new System.Drawing.Point(270, 504);
            this.advancedPanel4.Name = "advancedPanel4";
            this.advancedPanel4.RectRadius = 10;
            this.advancedPanel4.ShadowColor = System.Drawing.Color.LightGray;
            this.advancedPanel4.ShadowShift = 1;
            this.advancedPanel4.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.advancedPanel4.Size = new System.Drawing.Size(100, 115);
            this.advancedPanel4.StartColor = System.Drawing.Color.White;
            this.advancedPanel4.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Options";
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.label15);
            this.advancedPanel3.Controls.Add(this.Label_TotalItems);
            this.advancedPanel3.Controls.Add(this.label14);
            this.advancedPanel3.Controls.Add(this.Label_GrossTotal);
            this.advancedPanel3.Controls.Add(this.label16);
            this.advancedPanel3.Controls.Add(this.panel14);
            this.advancedPanel3.EdgeWidth = 1;
            this.advancedPanel3.EndColor = System.Drawing.Color.White;
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.LightGray;
            this.advancedPanel3.Location = new System.Drawing.Point(67, 504);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 10;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.LightGray;
            this.advancedPanel3.ShadowShift = 1;
            this.advancedPanel3.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.advancedPanel3.Size = new System.Drawing.Size(197, 115);
            this.advancedPanel3.StartColor = System.Drawing.Color.White;
            this.advancedPanel3.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel3.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(12, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Gross Total";
            // 
            // Label_TotalItems
            // 
            this.Label_TotalItems.AutoSize = true;
            this.Label_TotalItems.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalItems.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalItems.Location = new System.Drawing.Point(18, 83);
            this.Label_TotalItems.Name = "Label_TotalItems";
            this.Label_TotalItems.Size = new System.Drawing.Size(22, 23);
            this.Label_TotalItems.TabIndex = 12;
            this.Label_TotalItems.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(18, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "PHP";
            // 
            // Label_GrossTotal
            // 
            this.Label_GrossTotal.AutoSize = true;
            this.Label_GrossTotal.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GrossTotal.ForeColor = System.Drawing.Color.Black;
            this.Label_GrossTotal.Location = new System.Drawing.Point(66, 30);
            this.Label_GrossTotal.Name = "Label_GrossTotal";
            this.Label_GrossTotal.Size = new System.Drawing.Size(52, 23);
            this.Label_GrossTotal.TabIndex = 9;
            this.Label_GrossTotal.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(12, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Total Items";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DimGray;
            this.panel14.Location = new System.Drawing.Point(14, 58);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(170, 1);
            this.panel14.TabIndex = 10;
            // 
            // Datagrid_cart
            // 
            this.Datagrid_cart.AllowUserToAddRows = false;
            this.Datagrid_cart.AllowUserToResizeColumns = false;
            this.Datagrid_cart.AllowUserToResizeRows = false;
            this.Datagrid_cart.AutoGenerateColumns = false;
            this.Datagrid_cart.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_cart.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Datagrid_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Datagrid_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.Datagrid_cart.DataSource = this.cartContentsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_cart.DefaultCellStyle = dataGridViewCellStyle2;
            this.Datagrid_cart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Datagrid_cart.Location = new System.Drawing.Point(25, 68);
            this.Datagrid_cart.Name = "Datagrid_cart";
            this.Datagrid_cart.ReadOnly = true;
            this.Datagrid_cart.RowHeadersVisible = false;
            this.Datagrid_cart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_cart.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Datagrid_cart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Datagrid_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_cart.Size = new System.Drawing.Size(397, 391);
            this.Datagrid_cart.TabIndex = 4;
            this.Datagrid_cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_items_RowEnter);
            this.Datagrid_cart.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_cart_RowEnter);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "productName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "productQuantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cartContentsBindingSource
            // 
            this.cartContentsBindingSource.DataSource = typeof(SMD_Water_Station.Backend.Objects.CartContents);
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.Panel_items);
            this.advancedPanel1.EdgeWidth = 1;
            this.advancedPanel1.EndColor = System.Drawing.Color.White;
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel1.Location = new System.Drawing.Point(331, 6);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 10;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.advancedPanel1.ShadowShift = 3;
            this.advancedPanel1.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.advancedPanel1.Size = new System.Drawing.Size(514, 686);
            this.advancedPanel1.StartColor = System.Drawing.Color.White;
            this.advancedPanel1.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel1.TabIndex = 11;
            // 
            // Panel_items
            // 
            this.Panel_items.BackColor = System.Drawing.Color.White;
            this.Panel_items.Controls.Add(this.advancedPanel6);
            this.Panel_items.Controls.Add(this.panel2);
            this.Panel_items.Controls.Add(this.advancedPanel5);
            this.Panel_items.Controls.Add(this.panel6);
            this.Panel_items.Controls.Add(this.Datagrid_items);
            this.Panel_items.Location = new System.Drawing.Point(26, 17);
            this.Panel_items.Name = "Panel_items";
            this.Panel_items.Size = new System.Drawing.Size(461, 649);
            this.Panel_items.TabIndex = 2;
            // 
            // advancedPanel6
            // 
            this.advancedPanel6.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel6.Controls.Add(this.Label_viewHiddenItems);
            this.advancedPanel6.Controls.Add(this.Label_HiddenItems);
            this.advancedPanel6.Controls.Add(this.Label_DisplayedItems);
            this.advancedPanel6.Controls.Add(this.label13);
            this.advancedPanel6.Controls.Add(this.label12);
            this.advancedPanel6.Controls.Add(this.panel3);
            this.advancedPanel6.EdgeWidth = 1;
            this.advancedPanel6.EndColor = System.Drawing.Color.White;
            this.advancedPanel6.FlatBorderColor = System.Drawing.Color.LightGray;
            this.advancedPanel6.Location = new System.Drawing.Point(171, 504);
            this.advancedPanel6.Name = "advancedPanel6";
            this.advancedPanel6.RectRadius = 10;
            this.advancedPanel6.ShadowColor = System.Drawing.Color.LightGray;
            this.advancedPanel6.ShadowShift = 1;
            this.advancedPanel6.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.advancedPanel6.Size = new System.Drawing.Size(219, 115);
            this.advancedPanel6.StartColor = System.Drawing.Color.White;
            this.advancedPanel6.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel6.TabIndex = 14;
            // 
            // Label_viewHiddenItems
            // 
            this.Label_viewHiddenItems.AutoSize = true;
            this.Label_viewHiddenItems.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_viewHiddenItems.Location = new System.Drawing.Point(154, 83);
            this.Label_viewHiddenItems.Name = "Label_viewHiddenItems";
            this.Label_viewHiddenItems.Size = new System.Drawing.Size(36, 17);
            this.Label_viewHiddenItems.TabIndex = 15;
            this.Label_viewHiddenItems.TabStop = true;
            this.Label_viewHiddenItems.Text = "View";
            this.Label_viewHiddenItems.Visible = false;
            // 
            // Label_HiddenItems
            // 
            this.Label_HiddenItems.AutoSize = true;
            this.Label_HiddenItems.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HiddenItems.ForeColor = System.Drawing.Color.Black;
            this.Label_HiddenItems.Location = new System.Drawing.Point(22, 83);
            this.Label_HiddenItems.Name = "Label_HiddenItems";
            this.Label_HiddenItems.Size = new System.Drawing.Size(34, 23);
            this.Label_HiddenItems.TabIndex = 14;
            this.Label_HiddenItems.Text = "00";
            // 
            // Label_DisplayedItems
            // 
            this.Label_DisplayedItems.AutoSize = true;
            this.Label_DisplayedItems.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DisplayedItems.ForeColor = System.Drawing.Color.Black;
            this.Label_DisplayedItems.Location = new System.Drawing.Point(22, 30);
            this.Label_DisplayedItems.Name = "Label_DisplayedItems";
            this.Label_DisplayedItems.Size = new System.Drawing.Size(34, 23);
            this.Label_DisplayedItems.TabIndex = 13;
            this.Label_DisplayedItems.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(12, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Items hidden due to low stock";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(12, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Items in display";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(14, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(32, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 1);
            this.panel2.TabIndex = 16;
            // 
            // advancedPanel5
            // 
            this.advancedPanel5.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel5.Controls.Add(this.Button_Refresh);
            this.advancedPanel5.Controls.Add(this.label11);
            this.advancedPanel5.Controls.Add(this.Button_add);
            this.advancedPanel5.EdgeWidth = 1;
            this.advancedPanel5.EndColor = System.Drawing.Color.White;
            this.advancedPanel5.FlatBorderColor = System.Drawing.Color.Silver;
            this.advancedPanel5.Location = new System.Drawing.Point(65, 504);
            this.advancedPanel5.Name = "advancedPanel5";
            this.advancedPanel5.RectRadius = 10;
            this.advancedPanel5.ShadowColor = System.Drawing.Color.Silver;
            this.advancedPanel5.ShadowShift = 1;
            this.advancedPanel5.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.advancedPanel5.Size = new System.Drawing.Size(100, 78);
            this.advancedPanel5.StartColor = System.Drawing.Color.White;
            this.advancedPanel5.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel5.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(12, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Options";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.Checkbox_DisplayLowStocks);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.Icon_Search);
            this.panel6.Controls.Add(this.Textbox_search);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(461, 50);
            this.panel6.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(262, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Display products with low stocks";
            // 
            // Checkbox_DisplayLowStocks
            // 
            this.Checkbox_DisplayLowStocks.AutoSize = true;
            this.Checkbox_DisplayLowStocks.Depth = 0;
            this.Checkbox_DisplayLowStocks.Font = new System.Drawing.Font("Roboto", 10F);
            this.Checkbox_DisplayLowStocks.Location = new System.Drawing.Point(235, 8);
            this.Checkbox_DisplayLowStocks.Margin = new System.Windows.Forms.Padding(0);
            this.Checkbox_DisplayLowStocks.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Checkbox_DisplayLowStocks.MouseState = MaterialSkin.MouseState.HOVER;
            this.Checkbox_DisplayLowStocks.Name = "Checkbox_DisplayLowStocks";
            this.Checkbox_DisplayLowStocks.Ripple = true;
            this.Checkbox_DisplayLowStocks.Size = new System.Drawing.Size(26, 30);
            this.Checkbox_DisplayLowStocks.TabIndex = 18;
            this.Checkbox_DisplayLowStocks.UseVisualStyleBackColor = true;
            this.Checkbox_DisplayLowStocks.CheckedChanged += new System.EventHandler(this.Checkbox_DisplayLowStocks_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 1);
            this.panel4.TabIndex = 14;
            // 
            // Icon_Search
            // 
            this.Icon_Search.BackgroundImage = global::SMD_Water_Station.Properties.Resources.icons8_search_100;
            this.Icon_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon_Search.Location = new System.Drawing.Point(15, 15);
            this.Icon_Search.Name = "Icon_Search";
            this.Icon_Search.Size = new System.Drawing.Size(20, 20);
            this.Icon_Search.TabIndex = 4;
            // 
            // Textbox_search
            // 
            this.Textbox_search.Depth = 0;
            this.Textbox_search.Hint = "";
            this.Textbox_search.Location = new System.Drawing.Point(43, 13);
            this.Textbox_search.MaxLength = 32767;
            this.Textbox_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_search.Name = "Textbox_search";
            this.Textbox_search.PasswordChar = '\0';
            this.Textbox_search.SelectedText = "";
            this.Textbox_search.SelectionLength = 0;
            this.Textbox_search.SelectionStart = 0;
            this.Textbox_search.Size = new System.Drawing.Size(184, 23);
            this.Textbox_search.TabIndex = 13;
            this.Textbox_search.TabStop = false;
            this.Textbox_search.UseSystemPasswordChar = false;
            this.Textbox_search.TextChanged += new System.EventHandler(this.Textbox_search_TextChanged);
            // 
            // Datagrid_items
            // 
            this.Datagrid_items.AllowUserToAddRows = false;
            this.Datagrid_items.AllowUserToDeleteRows = false;
            this.Datagrid_items.AllowUserToResizeColumns = false;
            this.Datagrid_items.AllowUserToResizeRows = false;
            this.Datagrid_items.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_items.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Datagrid_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Datagrid_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_items.DefaultCellStyle = dataGridViewCellStyle5;
            this.Datagrid_items.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Datagrid_items.Location = new System.Drawing.Point(15, 68);
            this.Datagrid_items.Name = "Datagrid_items";
            this.Datagrid_items.ReadOnly = true;
            this.Datagrid_items.RowHeadersVisible = false;
            this.Datagrid_items.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_items.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Datagrid_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_items.Size = new System.Drawing.Size(430, 391);
            this.Datagrid_items.TabIndex = 1;
            this.Datagrid_items.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_items_RowEnter);
            // 
            // Panel_Today
            // 
            this.Panel_Today.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.Panel_Today.Controls.Add(this.Label_ItemsSoldToday);
            this.Panel_Today.Controls.Add(this.label8);
            this.Panel_Today.Controls.Add(this.Label_GrossSalesToday);
            this.Panel_Today.Controls.Add(this.label2);
            this.Panel_Today.Controls.Add(this.Icon_Today);
            this.Panel_Today.Controls.Add(this.label7);
            this.Panel_Today.Controls.Add(this.label4);
            this.Panel_Today.EdgeWidth = 1;
            this.Panel_Today.EndColor = System.Drawing.Color.White;
            this.Panel_Today.FlatBorderColor = System.Drawing.Color.Silver;
            this.Panel_Today.Location = new System.Drawing.Point(17, 6);
            this.Panel_Today.Name = "Panel_Today";
            this.Panel_Today.RectRadius = 10;
            this.Panel_Today.ShadowColor = System.Drawing.Color.Silver;
            this.Panel_Today.ShadowShift = 3;
            this.Panel_Today.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Surrounded;
            this.Panel_Today.Size = new System.Drawing.Size(300, 189);
            this.Panel_Today.StartColor = System.Drawing.Color.White;
            this.Panel_Today.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.Panel_Today.TabIndex = 4;
            // 
            // Label_ItemsSoldToday
            // 
            this.Label_ItemsSoldToday.AutoSize = true;
            this.Label_ItemsSoldToday.BackColor = System.Drawing.Color.White;
            this.Label_ItemsSoldToday.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ItemsSoldToday.ForeColor = System.Drawing.Color.Black;
            this.Label_ItemsSoldToday.Location = new System.Drawing.Point(61, 140);
            this.Label_ItemsSoldToday.Name = "Label_ItemsSoldToday";
            this.Label_ItemsSoldToday.Size = new System.Drawing.Size(44, 19);
            this.Label_ItemsSoldToday.TabIndex = 10;
            this.Label_ItemsSoldToday.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(38, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Items sold";
            // 
            // Label_GrossSalesToday
            // 
            this.Label_GrossSalesToday.AutoSize = true;
            this.Label_GrossSalesToday.BackColor = System.Drawing.Color.White;
            this.Label_GrossSalesToday.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GrossSalesToday.ForeColor = System.Drawing.Color.Black;
            this.Label_GrossSalesToday.Location = new System.Drawing.Point(118, 86);
            this.Label_GrossSalesToday.Name = "Label_GrossSalesToday";
            this.Label_GrossSalesToday.Size = new System.Drawing.Size(44, 19);
            this.Label_GrossSalesToday.TabIndex = 7;
            this.Label_GrossSalesToday.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(47, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Today";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(61, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "PHP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(38, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gross Sales";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 703);
            this.Controls.Add(this.advancedPanel2);
            this.Controls.Add(this.advancedPanel1);
            this.Controls.Add(this.Panel_Today);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeView";
            this.Load += new System.EventHandler(this.HomeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sales_Today_BindingSource)).EndInit();
            this.advancedPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.advancedPanel4.ResumeLayout(false);
            this.advancedPanel4.PerformLayout();
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartContentsBindingSource)).EndInit();
            this.advancedPanel1.ResumeLayout(false);
            this.Panel_items.ResumeLayout(false);
            this.advancedPanel6.ResumeLayout(false);
            this.advancedPanel6.PerformLayout();
            this.advancedPanel5.ResumeLayout(false);
            this.advancedPanel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_items)).EndInit();
            this.Panel_Today.ResumeLayout(false);
            this.Panel_Today.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Icon_Today;
        private System.Windows.Forms.Panel Panel_items;
        private System.Windows.Forms.DataGridView Datagrid_items;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label_GrossSalesToday;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Button_add;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView Datagrid_cart;
        public System.Windows.Forms.Label Label_GrossTotal;
        public System.Windows.Forms.Label Label_TotalItems;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button Button_Discard;
        public System.Windows.Forms.Button Button_Checkout;
        public System.Windows.Forms.Button Button_Remove;
        public System.Windows.Forms.BindingSource cartContentsBindingSource;
        private BevelPanel.AdvancedPanel Panel_Today;
        private BevelPanel.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.Panel Icon_Search;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_search;
        private BevelPanel.AdvancedPanel advancedPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private BevelPanel.AdvancedPanel advancedPanel3;
        private BevelPanel.AdvancedPanel advancedPanel4;
        private System.Windows.Forms.Label label6;
        private BevelPanel.AdvancedPanel advancedPanel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private BevelPanel.AdvancedPanel advancedPanel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label Label_HiddenItems;
        public System.Windows.Forms.Label Label_DisplayedItems;
        private System.Windows.Forms.LinkLabel Label_viewHiddenItems;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label17;
        public MaterialSkin.Controls.MaterialCheckBox Checkbox_DisplayLowStocks;
        public System.Windows.Forms.BindingSource Sales_Today_BindingSource;
        private System.Windows.Forms.Label Label_ItemsSoldToday;
        private System.Windows.Forms.Label label8;
    }
}
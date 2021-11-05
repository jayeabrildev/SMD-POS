
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label_referencenumber = new System.Windows.Forms.Label();
            this.button_clearOrders = new System.Windows.Forms.Button();
            this.button_payment = new System.Windows.Forms.Button();
            this.advancedPanel4 = new BevelPanel.AdvancedPanel();
            this.label_totalItems = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.advancedPanel3 = new BevelPanel.AdvancedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_orders = new System.Windows.Forms.DataGridView();
            this.advancedPanel2 = new BevelPanel.AdvancedPanel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.datagrid_products = new System.Windows.Forms.DataGridView();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.advancedPanel4.SuspendLayout();
            this.advancedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_orders)).BeginInit();
            this.advancedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_products)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reference number:";
            // 
            // label_referencenumber
            // 
            this.label_referencenumber.AutoSize = true;
            this.label_referencenumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_referencenumber.Location = new System.Drawing.Point(14, 37);
            this.label_referencenumber.Name = "label_referencenumber";
            this.label_referencenumber.Size = new System.Drawing.Size(99, 20);
            this.label_referencenumber.TabIndex = 24;
            this.label_referencenumber.Text = "XXXXXXXXXX";
            // 
            // button_clearOrders
            // 
            this.button_clearOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_clearOrders.FlatAppearance.BorderSize = 0;
            this.button_clearOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearOrders.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearOrders.ForeColor = System.Drawing.Color.White;
            this.button_clearOrders.Location = new System.Drawing.Point(1120, 15);
            this.button_clearOrders.Name = "button_clearOrders";
            this.button_clearOrders.Size = new System.Drawing.Size(140, 32);
            this.button_clearOrders.TabIndex = 25;
            this.button_clearOrders.Text = "Clear Orders";
            this.button_clearOrders.UseVisualStyleBackColor = false;
            this.button_clearOrders.Click += new System.EventHandler(this.button_clearOrders_Click);
            // 
            // button_payment
            // 
            this.button_payment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_payment.Enabled = false;
            this.button_payment.FlatAppearance.BorderSize = 0;
            this.button_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_payment.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_payment.ForeColor = System.Drawing.Color.White;
            this.button_payment.Location = new System.Drawing.Point(974, 15);
            this.button_payment.Name = "button_payment";
            this.button_payment.Size = new System.Drawing.Size(140, 32);
            this.button_payment.TabIndex = 26;
            this.button_payment.Text = "Payment";
            this.button_payment.UseVisualStyleBackColor = false;
            this.button_payment.Click += new System.EventHandler(this.button_payment_Click);
            // 
            // advancedPanel4
            // 
            this.advancedPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel4.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel4.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel4.Controls.Add(this.label_totalItems);
            this.advancedPanel4.Controls.Add(this.label_total);
            this.advancedPanel4.Controls.Add(this.label7);
            this.advancedPanel4.Controls.Add(this.label_referencenumber);
            this.advancedPanel4.Controls.Add(this.label6);
            this.advancedPanel4.Controls.Add(this.label2);
            this.advancedPanel4.EdgeWidth = 1;
            this.advancedPanel4.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.ForeColor = System.Drawing.Color.White;
            this.advancedPanel4.Location = new System.Drawing.Point(811, 533);
            this.advancedPanel4.Name = "advancedPanel4";
            this.advancedPanel4.RectRadius = 12;
            this.advancedPanel4.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel4.ShadowShift = 0;
            this.advancedPanel4.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel4.Size = new System.Drawing.Size(452, 158);
            this.advancedPanel4.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel4.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel4.TabIndex = 24;
            // 
            // label_totalItems
            // 
            this.label_totalItems.AutoSize = true;
            this.label_totalItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalItems.Location = new System.Drawing.Point(118, 100);
            this.label_totalItems.Name = "label_totalItems";
            this.label_totalItems.Size = new System.Drawing.Size(18, 20);
            this.label_totalItems.TabIndex = 11;
            this.label_totalItems.Text = "0";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(118, 72);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(44, 20);
            this.label_total.TabIndex = 10;
            this.label_total.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total items";
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel3.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel3.Controls.Add(this.label1);
            this.advancedPanel3.Controls.Add(this.datagrid_orders);
            this.advancedPanel3.EdgeWidth = 1;
            this.advancedPanel3.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.ForeColor = System.Drawing.Color.White;
            this.advancedPanel3.Location = new System.Drawing.Point(811, 64);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 12;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 0;
            this.advancedPanel3.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel3.Size = new System.Drawing.Size(452, 447);
            this.advancedPanel3.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel3.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel3.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Orders";
            // 
            // datagrid_orders
            // 
            this.datagrid_orders.AllowUserToAddRows = false;
            this.datagrid_orders.AllowUserToDeleteRows = false;
            this.datagrid_orders.AllowUserToResizeColumns = false;
            this.datagrid_orders.AllowUserToResizeRows = false;
            this.datagrid_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.datagrid_orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_orders.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_orders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid_orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.datagrid_orders.Location = new System.Drawing.Point(18, 50);
            this.datagrid_orders.MultiSelect = false;
            this.datagrid_orders.Name = "datagrid_orders";
            this.datagrid_orders.ReadOnly = true;
            this.datagrid_orders.RowHeadersVisible = false;
            this.datagrid_orders.RowHeadersWidth = 51;
            this.datagrid_orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_orders.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_orders.RowTemplate.Height = 24;
            this.datagrid_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_orders.Size = new System.Drawing.Size(413, 376);
            this.datagrid_orders.TabIndex = 7;
            this.datagrid_orders.VirtualMode = true;
            this.datagrid_orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_orders_CellClick);
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel2.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.Controls.Add(this.button_refresh);
            this.advancedPanel2.Controls.Add(this.datagrid_products);
            this.advancedPanel2.Controls.Add(this.textbox_search);
            this.advancedPanel2.Controls.Add(this.label12);
            this.advancedPanel2.EdgeWidth = 1;
            this.advancedPanel2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.ForeColor = System.Drawing.Color.White;
            this.advancedPanel2.Location = new System.Drawing.Point(26, 64);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 12;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 0;
            this.advancedPanel2.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel2.Size = new System.Drawing.Size(763, 627);
            this.advancedPanel2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel2.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel2.TabIndex = 8;
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(603, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(140, 32);
            this.button_refresh.TabIndex = 27;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // datagrid_products
            // 
            this.datagrid_products.AllowUserToAddRows = false;
            this.datagrid_products.AllowUserToDeleteRows = false;
            this.datagrid_products.AllowUserToResizeColumns = false;
            this.datagrid_products.AllowUserToResizeRows = false;
            this.datagrid_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.datagrid_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_products.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid_products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid_products.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.datagrid_products.Location = new System.Drawing.Point(18, 50);
            this.datagrid_products.MultiSelect = false;
            this.datagrid_products.Name = "datagrid_products";
            this.datagrid_products.ReadOnly = true;
            this.datagrid_products.RowHeadersVisible = false;
            this.datagrid_products.RowHeadersWidth = 51;
            this.datagrid_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_products.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid_products.RowTemplate.Height = 24;
            this.datagrid_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_products.Size = new System.Drawing.Size(725, 556);
            this.datagrid_products.TabIndex = 6;
            this.datagrid_products.VirtualMode = true;
            this.datagrid_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_products_CellClick);
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::SMD_Water_Station.Properties.Resources.SMDLOGO;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(26, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 40);
            this.panel1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "SMD Water Refilling Station";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.advancedPanel4);
            this.Controls.Add(this.button_payment);
            this.Controls.Add(this.button_clearOrders);
            this.Controls.Add(this.advancedPanel3);
            this.Controls.Add(this.advancedPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(1292, 721);
            this.Load += new System.EventHandler(this.Home_Load);
            this.advancedPanel4.ResumeLayout(false);
            this.advancedPanel4.PerformLayout();
            this.advancedPanel3.ResumeLayout(false);
            this.advancedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_orders)).EndInit();
            this.advancedPanel2.ResumeLayout(false);
            this.advancedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BevelPanel.AdvancedPanel advancedPanel1;
        private BevelPanel.AdvancedPanel advancedPanel2;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Label label12;
        private BevelPanel.AdvancedPanel advancedPanel3;
        private System.Windows.Forms.DataGridView datagrid_products;
        private System.Windows.Forms.DataGridView datagrid_orders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_referencenumber;
        private System.Windows.Forms.Button button_clearOrders;
        private System.Windows.Forms.Button button_payment;
        private BevelPanel.AdvancedPanel advancedPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_totalItems;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

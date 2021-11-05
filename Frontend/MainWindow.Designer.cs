
namespace SMD_Water_Station.Frontend
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.NavBar = new System.Windows.Forms.Panel();
            this.button_RoundCorners1 = new SMD_Water_Station.Frontend.Custom_Controls.Button_RoundCorners();
            this.Panel_Content = new System.Windows.Forms.Panel();
            this.Button_Sales = new SMD_Water_Station.Frontend.Custom_Controls.Button_RoundCorners();
            this.Button_Suppliers = new SMD_Water_Station.Frontend.Custom_Controls.Button_RoundCorners();
            this.Button_Inventory = new SMD_Water_Station.Frontend.Custom_Controls.Button_RoundCorners();
            this.Button_Home = new SMD_Water_Station.Frontend.Custom_Controls.Button_RoundCorners();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
            this.NavBar.Controls.Add(this.Button_Sales);
            this.NavBar.Controls.Add(this.button_RoundCorners1);
            this.NavBar.Controls.Add(this.Button_Suppliers);
            this.NavBar.Controls.Add(this.Button_Inventory);
            this.NavBar.Controls.Add(this.Button_Home);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Margin = new System.Windows.Forms.Padding(4);
            this.NavBar.Name = "NavBar";
            this.NavBar.Padding = new System.Windows.Forms.Padding(5);
            this.NavBar.Size = new System.Drawing.Size(50, 721);
            this.NavBar.TabIndex = 0;
            // 
            // button_RoundCorners1
            // 
            this.button_RoundCorners1.BackColor = System.Drawing.Color.Transparent;
            this.button_RoundCorners1.BackgroundColor = System.Drawing.Color.Transparent;
            this.button_RoundCorners1.BackgroundImage = global::SMD_Water_Station.Properties.Resources.outline_manage_accounts_white_24dp;
            this.button_RoundCorners1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_RoundCorners1.BorderColor = System.Drawing.Color.White;
            this.button_RoundCorners1.BorderRadius = 15;
            this.button_RoundCorners1.BorderSize = 0;
            this.button_RoundCorners1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_RoundCorners1.FlatAppearance.BorderSize = 0;
            this.button_RoundCorners1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RoundCorners1.ForeColor = System.Drawing.Color.Transparent;
            this.button_RoundCorners1.Location = new System.Drawing.Point(5, 677);
            this.button_RoundCorners1.Margin = new System.Windows.Forms.Padding(0);
            this.button_RoundCorners1.Name = "button_RoundCorners1";
            this.button_RoundCorners1.Size = new System.Drawing.Size(40, 39);
            this.button_RoundCorners1.TabIndex = 6;
            this.button_RoundCorners1.TextColor = System.Drawing.Color.Transparent;
            this.button_RoundCorners1.UseVisualStyleBackColor = false;
            // 
            // Panel_Content
            // 
            this.Panel_Content.BackColor = System.Drawing.Color.White;
            this.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Content.Location = new System.Drawing.Point(50, 0);
            this.Panel_Content.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Content.Name = "Panel_Content";
            this.Panel_Content.Size = new System.Drawing.Size(1292, 721);
            this.Panel_Content.TabIndex = 1;
            // 
            // Button_Sales
            // 
            this.Button_Sales.BackColor = System.Drawing.Color.Transparent;
            this.Button_Sales.BackgroundColor = System.Drawing.Color.Transparent;
            this.Button_Sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Sales.BackgroundImage")));
            this.Button_Sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Sales.BorderColor = System.Drawing.Color.White;
            this.Button_Sales.BorderRadius = 15;
            this.Button_Sales.BorderSize = 0;
            this.Button_Sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Sales.FlatAppearance.BorderSize = 0;
            this.Button_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Sales.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Sales.Location = new System.Drawing.Point(5, 122);
            this.Button_Sales.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Sales.Name = "Button_Sales";
            this.Button_Sales.Size = new System.Drawing.Size(40, 39);
            this.Button_Sales.TabIndex = 2;
            this.Button_Sales.TextColor = System.Drawing.Color.Transparent;
            this.Button_Sales.UseVisualStyleBackColor = false;
            this.Button_Sales.Click += new System.EventHandler(this.Button_Sales_Click);
            // 
            // Button_Suppliers
            // 
            this.Button_Suppliers.BackColor = System.Drawing.Color.Transparent;
            this.Button_Suppliers.BackgroundColor = System.Drawing.Color.Transparent;
            this.Button_Suppliers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Suppliers.BackgroundImage")));
            this.Button_Suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Suppliers.BorderColor = System.Drawing.Color.White;
            this.Button_Suppliers.BorderRadius = 15;
            this.Button_Suppliers.BorderSize = 0;
            this.Button_Suppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Suppliers.FlatAppearance.BorderSize = 0;
            this.Button_Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Suppliers.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Suppliers.Location = new System.Drawing.Point(5, 83);
            this.Button_Suppliers.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Suppliers.Name = "Button_Suppliers";
            this.Button_Suppliers.Size = new System.Drawing.Size(40, 39);
            this.Button_Suppliers.TabIndex = 3;
            this.Button_Suppliers.TextColor = System.Drawing.Color.Transparent;
            this.Button_Suppliers.UseVisualStyleBackColor = false;
            this.Button_Suppliers.Click += new System.EventHandler(this.Button_Suppliers_Click);
            // 
            // Button_Inventory
            // 
            this.Button_Inventory.BackColor = System.Drawing.Color.Transparent;
            this.Button_Inventory.BackgroundColor = System.Drawing.Color.Transparent;
            this.Button_Inventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Inventory.BackgroundImage")));
            this.Button_Inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Inventory.BorderColor = System.Drawing.Color.White;
            this.Button_Inventory.BorderRadius = 15;
            this.Button_Inventory.BorderSize = 0;
            this.Button_Inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Inventory.FlatAppearance.BorderSize = 0;
            this.Button_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Inventory.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Inventory.Location = new System.Drawing.Point(5, 44);
            this.Button_Inventory.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Inventory.Name = "Button_Inventory";
            this.Button_Inventory.Size = new System.Drawing.Size(40, 39);
            this.Button_Inventory.TabIndex = 1;
            this.Button_Inventory.TextColor = System.Drawing.Color.Transparent;
            this.Button_Inventory.UseVisualStyleBackColor = false;
            this.Button_Inventory.Click += new System.EventHandler(this.Button_Inventory_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.BackColor = System.Drawing.Color.Transparent;
            this.Button_Home.BackgroundColor = System.Drawing.Color.Transparent;
            this.Button_Home.BackgroundImage = global::SMD_Water_Station.Properties.Resources.outline_home_white_24dp;
            this.Button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Home.BorderColor = System.Drawing.Color.White;
            this.Button_Home.BorderRadius = 15;
            this.Button_Home.BorderSize = 0;
            this.Button_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Home.FlatAppearance.BorderSize = 0;
            this.Button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Home.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Home.Location = new System.Drawing.Point(5, 5);
            this.Button_Home.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(40, 39);
            this.Button_Home.TabIndex = 0;
            this.Button_Home.TextColor = System.Drawing.Color.Transparent;
            this.Button_Home.UseVisualStyleBackColor = false;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 721);
            this.Controls.Add(this.Panel_Content);
            this.Controls.Add(this.NavBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1360, 768);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_MainWIndow_Load);
            this.NavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private Custom_Controls.Button_RoundCorners Button_Home;
        private Custom_Controls.Button_RoundCorners Button_Suppliers;
        private Custom_Controls.Button_RoundCorners Button_Inventory;
        private Custom_Controls.Button_RoundCorners button_RoundCorners1;
        public System.Windows.Forms.Panel Panel_Content;
        private Custom_Controls.Button_RoundCorners Button_Sales;
    }
}
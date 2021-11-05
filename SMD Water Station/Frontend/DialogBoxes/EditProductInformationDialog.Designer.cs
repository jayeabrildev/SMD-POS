namespace SMD_Water_Station.Frontend.DialogBoxes
{
    partial class EditProductInformationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductInformationDialog));
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Desription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Textfield_Description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textfield_Price = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Button_Save = new MaterialSkin.Controls.MaterialFlatButton();
            this.Label_ProductID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Price.Location = new System.Drawing.Point(66, 192);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(37, 17);
            this.Label_Price.TabIndex = 26;
            this.Label_Price.Text = "Price";
            // 
            // Label_Desription
            // 
            this.Label_Desription.AutoSize = true;
            this.Label_Desription.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Desription.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Desription.Location = new System.Drawing.Point(66, 139);
            this.Label_Desription.Name = "Label_Desription";
            this.Label_Desription.Size = new System.Drawing.Size(73, 17);
            this.Label_Desription.TabIndex = 19;
            this.Label_Desription.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(66, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product information";
            // 
            // Textfield_Description
            // 
            this.Textfield_Description.Depth = 0;
            this.Textfield_Description.Hint = "";
            this.Textfield_Description.Location = new System.Drawing.Point(69, 156);
            this.Textfield_Description.MaxLength = 32767;
            this.Textfield_Description.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_Description.Name = "Textfield_Description";
            this.Textfield_Description.PasswordChar = '\0';
            this.Textfield_Description.SelectedText = "";
            this.Textfield_Description.SelectionLength = 0;
            this.Textfield_Description.SelectionStart = 0;
            this.Textfield_Description.Size = new System.Drawing.Size(230, 23);
            this.Textfield_Description.TabIndex = 29;
            this.Textfield_Description.TabStop = false;
            this.Textfield_Description.UseSystemPasswordChar = false;
            // 
            // Textfield_Price
            // 
            this.Textfield_Price.Depth = 0;
            this.Textfield_Price.Hint = "";
            this.Textfield_Price.Location = new System.Drawing.Point(69, 209);
            this.Textfield_Price.MaxLength = 10;
            this.Textfield_Price.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_Price.Name = "Textfield_Price";
            this.Textfield_Price.PasswordChar = '\0';
            this.Textfield_Price.SelectedText = "";
            this.Textfield_Price.SelectionLength = 0;
            this.Textfield_Price.SelectionStart = 0;
            this.Textfield_Price.Size = new System.Drawing.Size(147, 23);
            this.Textfield_Price.TabIndex = 30;
            this.Textfield_Price.TabStop = false;
            this.Textfield_Price.UseSystemPasswordChar = false;
            this.Textfield_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textfield_Price_KeyPress);
            this.Textfield_Price.TextChanged += new System.EventHandler(this.Textfield_Price_TextChanged);
            // 
            // Button_Save
            // 
            this.Button_Save.AutoSize = true;
            this.Button_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Save.Depth = 0;
            this.Button_Save.Icon = null;
            this.Button_Save.Location = new System.Drawing.Point(69, 268);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Save.MinimumSize = new System.Drawing.Size(230, 40);
            this.Button_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Primary = false;
            this.Button_Save.Size = new System.Drawing.Size(230, 40);
            this.Button_Save.TabIndex = 31;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_ProductID
            // 
            this.Label_ProductID.AutoSize = true;
            this.Label_ProductID.Location = new System.Drawing.Point(66, 110);
            this.Label_ProductID.Name = "Label_ProductID";
            this.Label_ProductID.Size = new System.Drawing.Size(88, 17);
            this.Label_ProductID.TabIndex = 32;
            this.Label_ProductID.Text = "XXXXXXXXXX";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SMD_Water_Station.Properties.Resources.product_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 50);
            this.panel2.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 1);
            this.panel4.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 1);
            this.panel3.TabIndex = 0;
            // 
            // EditProductInformationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Label_ProductID);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Textfield_Price);
            this.Controls.Add(this.Textfield_Description);
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.Label_Desription);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProductInformationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Information";
            this.Load += new System.EventHandler(this.EditProductInformationDialog_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label Label_Desription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_Description;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_Price;
        private MaterialSkin.Controls.MaterialFlatButton Button_Save;
        private System.Windows.Forms.Label Label_ProductID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
namespace SMD_Water_Station
{
    partial class ItemSummaryDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSummaryDialog));
            this.label2 = new System.Windows.Forms.Label();
            this.Label_itemDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_maxquantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_productPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_Add = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Quantity)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item";
            // 
            // Label_itemDescription
            // 
            this.Label_itemDescription.AutoSize = true;
            this.Label_itemDescription.BackColor = System.Drawing.Color.Transparent;
            this.Label_itemDescription.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_itemDescription.ForeColor = System.Drawing.Color.Black;
            this.Label_itemDescription.Location = new System.Drawing.Point(70, 123);
            this.Label_itemDescription.Name = "Label_itemDescription";
            this.Label_itemDescription.Size = new System.Drawing.Size(19, 15);
            this.Label_itemDescription.TabIndex = 3;
            this.Label_itemDescription.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(61, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // NUD_Quantity
            // 
            this.NUD_Quantity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Quantity.ForeColor = System.Drawing.Color.Black;
            this.NUD_Quantity.Location = new System.Drawing.Point(73, 171);
            this.NUD_Quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUD_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Quantity.Name = "NUD_Quantity";
            this.NUD_Quantity.Size = new System.Drawing.Size(55, 23);
            this.NUD_Quantity.TabIndex = 5;
            this.NUD_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Quantity.ValueChanged += new System.EventHandler(this.NUD_Quantity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(134, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "(Max:";
            // 
            // Label_maxquantity
            // 
            this.Label_maxquantity.AutoSize = true;
            this.Label_maxquantity.BackColor = System.Drawing.Color.Transparent;
            this.Label_maxquantity.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_maxquantity.ForeColor = System.Drawing.Color.Black;
            this.Label_maxquantity.Location = new System.Drawing.Point(177, 174);
            this.Label_maxquantity.Name = "Label_maxquantity";
            this.Label_maxquantity.Size = new System.Drawing.Size(25, 15);
            this.Label_maxquantity.TabIndex = 9;
            this.Label_maxquantity.Text = "00)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(61, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(70, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "PHP";
            // 
            // Label_productPrice
            // 
            this.Label_productPrice.AutoSize = true;
            this.Label_productPrice.BackColor = System.Drawing.Color.Transparent;
            this.Label_productPrice.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_productPrice.ForeColor = System.Drawing.Color.Black;
            this.Label_productPrice.Location = new System.Drawing.Point(105, 226);
            this.Label_productPrice.Name = "Label_productPrice";
            this.Label_productPrice.Size = new System.Drawing.Size(37, 19);
            this.Label_productPrice.TabIndex = 14;
            this.Label_productPrice.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(44, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 1);
            this.panel2.TabIndex = 19;
            // 
            // Button_Add
            // 
            this.Button_Add.AutoSize = true;
            this.Button_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Add.Depth = 0;
            this.Button_Add.Icon = null;
            this.Button_Add.Location = new System.Drawing.Point(79, 272);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Add.MinimumSize = new System.Drawing.Size(215, 0);
            this.Button_Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Primary = false;
            this.Button_Add.Size = new System.Drawing.Size(215, 36);
            this.Button_Add.TabIndex = 20;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SMD_Water_Station.Properties.Resources.icons8_add_receipt_64;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Summary";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 50);
            this.panel4.TabIndex = 24;
            // 
            // ItemSummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(375, 328);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Label_maxquantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_itemDescription);
            this.Controls.Add(this.NUD_Quantity);
            this.Controls.Add(this.Label_productPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemSummaryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add to cart";
            this.Load += new System.EventHandler(this.ItemSummaryDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Quantity)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_itemDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_maxquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_productPrice;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton Button_Add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
    }
}
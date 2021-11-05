namespace SMD_Water_Station.Frontend.DialogBoxes
{
    partial class AddNewProductDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProductDialog));
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Desription = new System.Windows.Forms.Label();
            this.Label_ProductID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Confirm = new MaterialSkin.Controls.MaterialFlatButton();
            this.Textfield_Price = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textfield_Description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Textfield_ProductID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_InitialStocks = new System.Windows.Forms.NumericUpDown();
            this.Label_feedback = new System.Windows.Forms.Label();
            this.Label_ProductIDTaken = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_InitialStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Price.Location = new System.Drawing.Point(56, 185);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(36, 15);
            this.Label_Price.TabIndex = 38;
            this.Label_Price.Text = "Price";
            // 
            // Label_Desription
            // 
            this.Label_Desription.AutoSize = true;
            this.Label_Desription.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Desription.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Desription.Location = new System.Drawing.Point(56, 142);
            this.Label_Desription.Name = "Label_Desription";
            this.Label_Desription.Size = new System.Drawing.Size(72, 15);
            this.Label_Desription.TabIndex = 37;
            this.Label_Desription.Text = "Description";
            // 
            // Label_ProductID
            // 
            this.Label_ProductID.AutoSize = true;
            this.Label_ProductID.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ProductID.ForeColor = System.Drawing.Color.DimGray;
            this.Label_ProductID.Location = new System.Drawing.Point(56, 96);
            this.Label_ProductID.Name = "Label_ProductID";
            this.Label_ProductID.Size = new System.Drawing.Size(67, 15);
            this.Label_ProductID.TabIndex = 36;
            this.Label_ProductID.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add new product";
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.AutoSize = true;
            this.Button_Confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Confirm.Depth = 0;
            this.Button_Confirm.Icon = null;
            this.Button_Confirm.Location = new System.Drawing.Point(97, 319);
            this.Button_Confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Confirm.MinimumSize = new System.Drawing.Size(230, 40);
            this.Button_Confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Primary = false;
            this.Button_Confirm.Size = new System.Drawing.Size(230, 40);
            this.Button_Confirm.TabIndex = 4;
            this.Button_Confirm.Text = "Confirm";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // Textfield_Price
            // 
            this.Textfield_Price.Depth = 0;
            this.Textfield_Price.Hint = "";
            this.Textfield_Price.Location = new System.Drawing.Point(59, 202);
            this.Textfield_Price.MaxLength = 10;
            this.Textfield_Price.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_Price.Name = "Textfield_Price";
            this.Textfield_Price.PasswordChar = '\0';
            this.Textfield_Price.SelectedText = "";
            this.Textfield_Price.SelectionLength = 0;
            this.Textfield_Price.SelectionStart = 0;
            this.Textfield_Price.Size = new System.Drawing.Size(147, 23);
            this.Textfield_Price.TabIndex = 2;
            this.Textfield_Price.TabStop = false;
            this.Textfield_Price.UseSystemPasswordChar = false;
            this.Textfield_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textfield_Price_KeyPress);
            // 
            // Textfield_Description
            // 
            this.Textfield_Description.Depth = 0;
            this.Textfield_Description.Hint = "";
            this.Textfield_Description.Location = new System.Drawing.Point(59, 159);
            this.Textfield_Description.MaxLength = 32767;
            this.Textfield_Description.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_Description.Name = "Textfield_Description";
            this.Textfield_Description.PasswordChar = '\0';
            this.Textfield_Description.SelectedText = "";
            this.Textfield_Description.SelectionLength = 0;
            this.Textfield_Description.SelectionStart = 0;
            this.Textfield_Description.Size = new System.Drawing.Size(305, 23);
            this.Textfield_Description.TabIndex = 1;
            this.Textfield_Description.TabStop = false;
            this.Textfield_Description.UseSystemPasswordChar = false;
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
            this.panel2.Size = new System.Drawing.Size(425, 50);
            this.panel2.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 1);
            this.panel4.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 1);
            this.panel3.TabIndex = 0;
            // 
            // Textfield_ProductID
            // 
            this.Textfield_ProductID.Depth = 0;
            this.Textfield_ProductID.Hint = "";
            this.Textfield_ProductID.Location = new System.Drawing.Point(59, 116);
            this.Textfield_ProductID.MaxLength = 20;
            this.Textfield_ProductID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_ProductID.Name = "Textfield_ProductID";
            this.Textfield_ProductID.PasswordChar = '\0';
            this.Textfield_ProductID.SelectedText = "";
            this.Textfield_ProductID.SelectionLength = 0;
            this.Textfield_ProductID.SelectionStart = 0;
            this.Textfield_ProductID.Size = new System.Drawing.Size(175, 23);
            this.Textfield_ProductID.TabIndex = 0;
            this.Textfield_ProductID.TabStop = false;
            this.Textfield_ProductID.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(56, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Initial stocks";
            // 
            // NUD_InitialStocks
            // 
            this.NUD_InitialStocks.Location = new System.Drawing.Point(59, 248);
            this.NUD_InitialStocks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_InitialStocks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_InitialStocks.Name = "NUD_InitialStocks";
            this.NUD_InitialStocks.Size = new System.Drawing.Size(78, 23);
            this.NUD_InitialStocks.TabIndex = 3;
            this.NUD_InitialStocks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_feedback
            // 
            this.Label_feedback.AutoSize = true;
            this.Label_feedback.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_feedback.ForeColor = System.Drawing.Color.Red;
            this.Label_feedback.Location = new System.Drawing.Point(56, 274);
            this.Label_feedback.Name = "Label_feedback";
            this.Label_feedback.Size = new System.Drawing.Size(184, 15);
            this.Label_feedback.TabIndex = 46;
            this.Label_feedback.Text = "Please fill all the required fields";
            this.Label_feedback.Visible = false;
            // 
            // Label_ProductIDTaken
            // 
            this.Label_ProductIDTaken.AutoSize = true;
            this.Label_ProductIDTaken.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ProductIDTaken.ForeColor = System.Drawing.Color.Red;
            this.Label_ProductIDTaken.Location = new System.Drawing.Point(240, 116);
            this.Label_ProductIDTaken.Name = "Label_ProductIDTaken";
            this.Label_ProductIDTaken.Size = new System.Drawing.Size(159, 15);
            this.Label_ProductIDTaken.TabIndex = 47;
            this.Label_ProductIDTaken.Text = "Product ID is already taken";
            this.Label_ProductIDTaken.Visible = false;
            // 
            // AddNewProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 400);
            this.Controls.Add(this.Label_ProductIDTaken);
            this.Controls.Add(this.Label_feedback);
            this.Controls.Add(this.NUD_InitialStocks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textfield_ProductID);
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.Label_Desription);
            this.Controls.Add(this.Label_ProductID);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.Textfield_Price);
            this.Controls.Add(this.Textfield_Description);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_InitialStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label Label_Desription;
        private System.Windows.Forms.Label Label_ProductID;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton Button_Confirm;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_Price;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_Description;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_ProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_InitialStocks;
        private System.Windows.Forms.Label Label_feedback;
        private System.Windows.Forms.Label Label_ProductIDTaken;
    }
}

namespace SMD_Water_Station.Views.Modals
{
    partial class Modal_UpdateStocks
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
            this.modalPanel = new BevelPanel.AdvancedPanel();
            this.label_currentStocks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_remarks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_deduct = new System.Windows.Forms.RadioButton();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.label_product = new System.Windows.Forms.Label();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // modalPanel
            // 
            this.modalPanel.BackColor = System.Drawing.Color.Transparent;
            this.modalPanel.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.modalPanel.Controls.Add(this.label_currentStocks);
            this.modalPanel.Controls.Add(this.label3);
            this.modalPanel.Controls.Add(this.combobox_remarks);
            this.modalPanel.Controls.Add(this.label2);
            this.modalPanel.Controls.Add(this.rb_deduct);
            this.modalPanel.Controls.Add(this.rb_add);
            this.modalPanel.Controls.Add(this.label_product);
            this.modalPanel.Controls.Add(this.nud_quantity);
            this.modalPanel.Controls.Add(this.button_cancel);
            this.modalPanel.Controls.Add(this.button_save);
            this.modalPanel.Controls.Add(this.label7);
            this.modalPanel.Controls.Add(this.panel3);
            this.modalPanel.Controls.Add(this.label5);
            this.modalPanel.Controls.Add(this.label1);
            this.modalPanel.EdgeWidth = 1;
            this.modalPanel.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.modalPanel.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.modalPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalPanel.ForeColor = System.Drawing.Color.White;
            this.modalPanel.Location = new System.Drawing.Point(0, 0);
            this.modalPanel.Name = "modalPanel";
            this.modalPanel.RectRadius = 12;
            this.modalPanel.ShadowColor = System.Drawing.Color.DimGray;
            this.modalPanel.ShadowShift = 0;
            this.modalPanel.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.modalPanel.Size = new System.Drawing.Size(435, 236);
            this.modalPanel.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.modalPanel.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.modalPanel.TabIndex = 13;
            // 
            // label_currentStocks
            // 
            this.label_currentStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_currentStocks.AutoSize = true;
            this.label_currentStocks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentStocks.Location = new System.Drawing.Point(321, 21);
            this.label_currentStocks.Name = "label_currentStocks";
            this.label_currentStocks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_currentStocks.Size = new System.Drawing.Size(19, 23);
            this.label_currentStocks.TabIndex = 32;
            this.label_currentStocks.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Current stocks";
            // 
            // combobox_remarks
            // 
            this.combobox_remarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_remarks.FormattingEnabled = true;
            this.combobox_remarks.Location = new System.Drawing.Point(94, 138);
            this.combobox_remarks.Name = "combobox_remarks";
            this.combobox_remarks.Size = new System.Drawing.Size(317, 25);
            this.combobox_remarks.Sorted = true;
            this.combobox_remarks.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Remarks";
            // 
            // rb_deduct
            // 
            this.rb_deduct.AutoSize = true;
            this.rb_deduct.Location = new System.Drawing.Point(244, 102);
            this.rb_deduct.Name = "rb_deduct";
            this.rb_deduct.Size = new System.Drawing.Size(74, 23);
            this.rb_deduct.TabIndex = 28;
            this.rb_deduct.Text = "Deduct";
            this.rb_deduct.UseVisualStyleBackColor = true;
            this.rb_deduct.CheckedChanged += new System.EventHandler(this.rb_deduct_CheckedChanged);
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Checked = true;
            this.rb_add.Location = new System.Drawing.Point(187, 102);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(55, 23);
            this.rb_add.TabIndex = 27;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "Add";
            this.rb_add.UseVisualStyleBackColor = true;
            this.rb_add.CheckedChanged += new System.EventHandler(this.rb_add_CheckedChanged);
            // 
            // label_product
            // 
            this.label_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.Location = new System.Drawing.Point(94, 59);
            this.label_product.Name = "label_product";
            this.label_product.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_product.Size = new System.Drawing.Size(95, 19);
            this.label_product.TabIndex = 26;
            this.label_product.Text = "Product name";
            // 
            // nud_quantity
            // 
            this.nud_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.nud_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_quantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_quantity.ForeColor = System.Drawing.Color.White;
            this.nud_quantity.Location = new System.Drawing.Point(94, 102);
            this.nud_quantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(87, 23);
            this.nud_quantity.TabIndex = 25;
            this.nud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(311, 181);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(205, 181);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 30);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantity";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(22, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 1);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Stocks";
            // 
            // Modal_UpdateStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(435, 236);
            this.Controls.Add(this.modalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modal_UpdateStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modal_UpdateStocks";
            this.Load += new System.EventHandler(this.Modal_UpdateStocks_Load);
            this.modalPanel.ResumeLayout(false);
            this.modalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BevelPanel.AdvancedPanel modalPanel;
        private System.Windows.Forms.RadioButton rb_deduct;
        private System.Windows.Forms.RadioButton rb_add;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_remarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_currentStocks;
        private System.Windows.Forms.Label label3;
    }
}
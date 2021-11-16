
namespace SMD_Water_Station.Views.Modals
{
    partial class Modal_DeleteTransaction
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
            this.checkbox_return = new System.Windows.Forms.CheckBox();
            this.combobox_remarks = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_item = new System.Windows.Forms.Label();
            this.label_refnumber = new System.Windows.Forms.Label();
            this.label_transactionID = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modalPanel
            // 
            this.modalPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modalPanel.BackColor = System.Drawing.Color.Transparent;
            this.modalPanel.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.modalPanel.Controls.Add(this.checkbox_return);
            this.modalPanel.Controls.Add(this.combobox_remarks);
            this.modalPanel.Controls.Add(this.panel5);
            this.modalPanel.Controls.Add(this.label3);
            this.modalPanel.Controls.Add(this.label_quantity);
            this.modalPanel.Controls.Add(this.label_item);
            this.modalPanel.Controls.Add(this.label_refnumber);
            this.modalPanel.Controls.Add(this.label_transactionID);
            this.modalPanel.Controls.Add(this.label_amount);
            this.modalPanel.Controls.Add(this.label2);
            this.modalPanel.Controls.Add(this.panel1);
            this.modalPanel.Controls.Add(this.button_cancel);
            this.modalPanel.Controls.Add(this.button_save);
            this.modalPanel.Controls.Add(this.label7);
            this.modalPanel.Controls.Add(this.panel4);
            this.modalPanel.Controls.Add(this.label6);
            this.modalPanel.Controls.Add(this.panel3);
            this.modalPanel.Controls.Add(this.label5);
            this.modalPanel.Controls.Add(this.panel2);
            this.modalPanel.Controls.Add(this.label4);
            this.modalPanel.Controls.Add(this.label1);
            this.modalPanel.EdgeWidth = 1;
            this.modalPanel.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.modalPanel.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.modalPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalPanel.ForeColor = System.Drawing.Color.White;
            this.modalPanel.Location = new System.Drawing.Point(35, 34);
            this.modalPanel.Name = "modalPanel";
            this.modalPanel.RectRadius = 12;
            this.modalPanel.ShadowColor = System.Drawing.Color.DimGray;
            this.modalPanel.ShadowShift = 0;
            this.modalPanel.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.modalPanel.Size = new System.Drawing.Size(567, 384);
            this.modalPanel.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.modalPanel.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.modalPanel.TabIndex = 12;
            // 
            // checkbox_return
            // 
            this.checkbox_return.AutoSize = true;
            this.checkbox_return.Location = new System.Drawing.Point(22, 298);
            this.checkbox_return.Name = "checkbox_return";
            this.checkbox_return.Size = new System.Drawing.Size(186, 23);
            this.checkbox_return.TabIndex = 24;
            this.checkbox_return.Text = "Return quantity to stocks";
            this.checkbox_return.UseVisualStyleBackColor = true;
            // 
            // combobox_remarks
            // 
            this.combobox_remarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_remarks.FormattingEnabled = true;
            this.combobox_remarks.Items.AddRange(new object[] {
            "Item return",
            "Item remove/cancel"});
            this.combobox_remarks.Location = new System.Drawing.Point(125, 263);
            this.combobox_remarks.Name = "combobox_remarks";
            this.combobox_remarks.Size = new System.Drawing.Size(255, 25);
            this.combobox_remarks.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(19, 251);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(520, 1);
            this.panel5.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Remarks";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(121, 188);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(83, 19);
            this.label_quantity.TabIndex = 21;
            this.label_quantity.Text = "Ref. number";
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item.Location = new System.Drawing.Point(121, 146);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(83, 19);
            this.label_item.TabIndex = 20;
            this.label_item.Text = "Ref. number";
            // 
            // label_refnumber
            // 
            this.label_refnumber.AutoSize = true;
            this.label_refnumber.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_refnumber.Location = new System.Drawing.Point(121, 105);
            this.label_refnumber.Name = "label_refnumber";
            this.label_refnumber.Size = new System.Drawing.Size(83, 19);
            this.label_refnumber.TabIndex = 19;
            this.label_refnumber.Text = "Ref. number";
            // 
            // label_transactionID
            // 
            this.label_transactionID.AutoSize = true;
            this.label_transactionID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transactionID.Location = new System.Drawing.Point(121, 65);
            this.label_transactionID.Name = "label_transactionID";
            this.label_transactionID.Size = new System.Drawing.Size(96, 19);
            this.label_transactionID.TabIndex = 18;
            this.label_transactionID.Text = "Transaction ID";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(121, 228);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(59, 19);
            this.label_amount.TabIndex = 17;
            this.label_amount.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(22, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 1);
            this.panel1.TabIndex = 13;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(442, 331);
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
            this.button_save.Location = new System.Drawing.Point(337, 331);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 30);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Confirm";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantity";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(22, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 1);
            this.panel4.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Item";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(22, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 1);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ref. number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(22, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 1);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transaction ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transaction Details";
            // 
            // Modal_DeleteTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.modalPanel);
            this.Name = "Modal_DeleteTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Transaction";
            this.Load += new System.EventHandler(this.Modal_DeleteTransaction_Load);
            this.modalPanel.ResumeLayout(false);
            this.modalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BevelPanel.AdvancedPanel modalPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Label label_refnumber;
        private System.Windows.Forms.Label label_transactionID;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_remarks;
        private System.Windows.Forms.CheckBox checkbox_return;
    }
}

namespace SMD_Water_Station.Views.Modals
{
    partial class Modal_EditMaterial
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
            this.combobox_supplier = new System.Windows.Forms.ComboBox();
            this.textbox_description = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modalPanel
            // 
            this.modalPanel.BackColor = System.Drawing.Color.Transparent;
            this.modalPanel.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.modalPanel.Controls.Add(this.combobox_supplier);
            this.modalPanel.Controls.Add(this.textbox_description);
            this.modalPanel.Controls.Add(this.label14);
            this.modalPanel.Controls.Add(this.button_cancel);
            this.modalPanel.Controls.Add(this.button_save);
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
            this.modalPanel.Size = new System.Drawing.Size(435, 209);
            this.modalPanel.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.modalPanel.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.modalPanel.TabIndex = 13;
            // 
            // combobox_supplier
            // 
            this.combobox_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.combobox_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobox_supplier.ForeColor = System.Drawing.Color.White;
            this.combobox_supplier.FormattingEnabled = true;
            this.combobox_supplier.Location = new System.Drawing.Point(172, 106);
            this.combobox_supplier.Name = "combobox_supplier";
            this.combobox_supplier.Size = new System.Drawing.Size(240, 25);
            this.combobox_supplier.TabIndex = 24;
            // 
            // textbox_description
            // 
            this.textbox_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.textbox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_description.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_description.ForeColor = System.Drawing.Color.White;
            this.textbox_description.Location = new System.Drawing.Point(172, 68);
            this.textbox_description.MaxLength = 100;
            this.textbox_description.Name = "textbox_description";
            this.textbox_description.Size = new System.Drawing.Size(240, 20);
            this.textbox_description.TabIndex = 22;
            this.textbox_description.TextChanged += new System.EventHandler(this.textbox_description_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "Supplier";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(312, 150);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(207, 150);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 30);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(23, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 1);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edit Material Details";
            // 
            // Modal_EditMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(435, 209);
            this.Controls.Add(this.modalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modal_EditMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Material";
            this.Load += new System.EventHandler(this.Modal_EditMaterial_Load);
            this.modalPanel.ResumeLayout(false);
            this.modalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BevelPanel.AdvancedPanel modalPanel;
        private System.Windows.Forms.TextBox textbox_description;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_supplier;
    }
}
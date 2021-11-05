
namespace SMD_Water_Station.Views.Modals
{
    partial class Modal_EditPersonal
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.advancedPanel1 = new BevelPanel.AdvancedPanel();
            this.textbox_lastname = new System.Windows.Forms.TextBox();
            this.textbox_firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(200, 327);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(120, 30);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(326, 327);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(120, 30);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel1.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.textbox_lastname);
            this.advancedPanel1.Controls.Add(this.textbox_firstname);
            this.advancedPanel1.Controls.Add(this.label5);
            this.advancedPanel1.Controls.Add(this.label4);
            this.advancedPanel1.Controls.Add(this.label1);
            this.advancedPanel1.EdgeWidth = 1;
            this.advancedPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.ForeColor = System.Drawing.Color.White;
            this.advancedPanel1.Location = new System.Drawing.Point(83, 118);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 12;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel1.ShadowShift = 0;
            this.advancedPanel1.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel1.Size = new System.Drawing.Size(363, 203);
            this.advancedPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel1.TabIndex = 11;
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_lastname.Location = new System.Drawing.Point(22, 149);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(320, 24);
            this.textbox_lastname.TabIndex = 12;
            this.textbox_lastname.TextChanged += new System.EventHandler(this.textbox_lastname_TextChanged);
            // 
            // textbox_firstname
            // 
            this.textbox_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_firstname.Location = new System.Drawing.Point(22, 90);
            this.textbox_firstname.Name = "textbox_firstname";
            this.textbox_firstname.Size = new System.Drawing.Size(320, 24);
            this.textbox_firstname.TabIndex = 11;
            this.textbox_firstname.TextChanged += new System.EventHandler(this.textbox_firstname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Firstname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personal Information";
            // 
            // Modal_EditPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.advancedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modal_EditPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.Modal_EditPersonal_Load);
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BevelPanel.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textbox_firstname;
        private System.Windows.Forms.TextBox textbox_lastname;
    }
}
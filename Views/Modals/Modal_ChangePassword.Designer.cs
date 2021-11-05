
namespace SMD_Water_Station.Views.Modals
{
    partial class Modal_ChangePassword
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
            this.advancedPanel1 = new BevelPanel.AdvancedPanel();
            this.textbox_newPass = new System.Windows.Forms.TextBox();
            this.textbox_currentPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_confirmNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.advancedPanel1.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.Controls.Add(this.label1);
            this.advancedPanel1.Controls.Add(this.button_cancel);
            this.advancedPanel1.Controls.Add(this.button_save);
            this.advancedPanel1.Controls.Add(this.textbox_confirmNewPass);
            this.advancedPanel1.Controls.Add(this.label2);
            this.advancedPanel1.Controls.Add(this.textbox_newPass);
            this.advancedPanel1.Controls.Add(this.textbox_currentPassword);
            this.advancedPanel1.Controls.Add(this.label5);
            this.advancedPanel1.Controls.Add(this.label4);
            this.advancedPanel1.EdgeWidth = 1;
            this.advancedPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.ForeColor = System.Drawing.Color.White;
            this.advancedPanel1.Location = new System.Drawing.Point(23, 26);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 12;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel1.ShadowShift = 0;
            this.advancedPanel1.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel1.Size = new System.Drawing.Size(363, 269);
            this.advancedPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.advancedPanel1.Style = BevelPanel.AdvancedPanel.BevelStyle.Flat;
            this.advancedPanel1.TabIndex = 12;
            // 
            // textbox_newPass
            // 
            this.textbox_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_newPass.Location = new System.Drawing.Point(21, 102);
            this.textbox_newPass.Name = "textbox_newPass";
            this.textbox_newPass.Size = new System.Drawing.Size(320, 24);
            this.textbox_newPass.TabIndex = 12;
            this.textbox_newPass.UseSystemPasswordChar = true;
            this.textbox_newPass.TextChanged += new System.EventHandler(this.textbox_newPass_TextChanged);
            // 
            // textbox_currentPassword
            // 
            this.textbox_currentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_currentPassword.Location = new System.Drawing.Point(21, 43);
            this.textbox_currentPassword.Name = "textbox_currentPassword";
            this.textbox_currentPassword.Size = new System.Drawing.Size(320, 24);
            this.textbox_currentPassword.TabIndex = 11;
            this.textbox_currentPassword.UseSystemPasswordChar = true;
            this.textbox_currentPassword.TextChanged += new System.EventHandler(this.textbox_currentPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Password";
            // 
            // textbox_confirmNewPass
            // 
            this.textbox_confirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_confirmNewPass.Location = new System.Drawing.Point(21, 162);
            this.textbox_confirmNewPass.Name = "textbox_confirmNewPass";
            this.textbox_confirmNewPass.Size = new System.Drawing.Size(320, 24);
            this.textbox_confirmNewPass.TabIndex = 14;
            this.textbox_confirmNewPass.UseSystemPasswordChar = true;
            this.textbox_confirmNewPass.TextChanged += new System.EventHandler(this.textbox_confirmNewPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Confirm New Password";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(221, 218);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(120, 30);
            this.button_cancel.TabIndex = 16;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(95, 218);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(120, 30);
            this.button_save.TabIndex = 15;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(17, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Passwords does not match";
            // 
            // Modal_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(410, 323);
            this.Controls.Add(this.advancedPanel1);
            this.Name = "Modal_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Modal_ChangePassword_Load);
            this.advancedPanel1.ResumeLayout(false);
            this.advancedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BevelPanel.AdvancedPanel advancedPanel1;
        private System.Windows.Forms.TextBox textbox_newPass;
        private System.Windows.Forms.TextBox textbox_currentPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_confirmNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
    }
}
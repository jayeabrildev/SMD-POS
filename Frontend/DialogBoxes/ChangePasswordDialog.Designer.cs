namespace SMD_Water_Station.Frontend.DialogBoxes
{
    partial class ChangePasswordDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Textfield_CurrentPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textfield_NewPasssword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textfield_ConfirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Button_Save = new MaterialSkin.Controls.MaterialFlatButton();
            this.Label_IncorrectPassword = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Checkbox_ShowPassword = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_PasswordsDoNotMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm password";
            // 
            // Textfield_CurrentPassword
            // 
            this.Textfield_CurrentPassword.Depth = 0;
            this.Textfield_CurrentPassword.Hint = "";
            this.Textfield_CurrentPassword.Location = new System.Drawing.Point(176, 52);
            this.Textfield_CurrentPassword.MaxLength = 30;
            this.Textfield_CurrentPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_CurrentPassword.Name = "Textfield_CurrentPassword";
            this.Textfield_CurrentPassword.PasswordChar = '\0';
            this.Textfield_CurrentPassword.SelectedText = "";
            this.Textfield_CurrentPassword.SelectionLength = 0;
            this.Textfield_CurrentPassword.SelectionStart = 0;
            this.Textfield_CurrentPassword.Size = new System.Drawing.Size(201, 23);
            this.Textfield_CurrentPassword.TabIndex = 3;
            this.Textfield_CurrentPassword.TabStop = false;
            this.Textfield_CurrentPassword.UseSystemPasswordChar = true;
            // 
            // Textfield_NewPasssword
            // 
            this.Textfield_NewPasssword.Depth = 0;
            this.Textfield_NewPasssword.Hint = "";
            this.Textfield_NewPasssword.Location = new System.Drawing.Point(176, 107);
            this.Textfield_NewPasssword.MaxLength = 30;
            this.Textfield_NewPasssword.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_NewPasssword.Name = "Textfield_NewPasssword";
            this.Textfield_NewPasssword.PasswordChar = '\0';
            this.Textfield_NewPasssword.SelectedText = "";
            this.Textfield_NewPasssword.SelectionLength = 0;
            this.Textfield_NewPasssword.SelectionStart = 0;
            this.Textfield_NewPasssword.Size = new System.Drawing.Size(201, 23);
            this.Textfield_NewPasssword.TabIndex = 4;
            this.Textfield_NewPasssword.TabStop = false;
            this.Textfield_NewPasssword.UseSystemPasswordChar = true;
            // 
            // Textfield_ConfirmPassword
            // 
            this.Textfield_ConfirmPassword.Depth = 0;
            this.Textfield_ConfirmPassword.Hint = "";
            this.Textfield_ConfirmPassword.Location = new System.Drawing.Point(176, 148);
            this.Textfield_ConfirmPassword.MaxLength = 30;
            this.Textfield_ConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_ConfirmPassword.Name = "Textfield_ConfirmPassword";
            this.Textfield_ConfirmPassword.PasswordChar = '\0';
            this.Textfield_ConfirmPassword.SelectedText = "";
            this.Textfield_ConfirmPassword.SelectionLength = 0;
            this.Textfield_ConfirmPassword.SelectionStart = 0;
            this.Textfield_ConfirmPassword.Size = new System.Drawing.Size(201, 23);
            this.Textfield_ConfirmPassword.TabIndex = 5;
            this.Textfield_ConfirmPassword.TabStop = false;
            this.Textfield_ConfirmPassword.UseSystemPasswordChar = true;
            this.Textfield_ConfirmPassword.TextChanged += new System.EventHandler(this.Textfield_ConfirmPassword_TextChanged);
            // 
            // Button_Save
            // 
            this.Button_Save.AutoSize = true;
            this.Button_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Save.Depth = 0;
            this.Button_Save.Icon = null;
            this.Button_Save.Location = new System.Drawing.Point(76, 190);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Save.MinimumSize = new System.Drawing.Size(300, 36);
            this.Button_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Primary = false;
            this.Button_Save.Size = new System.Drawing.Size(300, 36);
            this.Button_Save.TabIndex = 6;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_IncorrectPassword
            // 
            this.Label_IncorrectPassword.AutoSize = true;
            this.Label_IncorrectPassword.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_IncorrectPassword.ForeColor = System.Drawing.Color.Red;
            this.Label_IncorrectPassword.Location = new System.Drawing.Point(173, 81);
            this.Label_IncorrectPassword.Name = "Label_IncorrectPassword";
            this.Label_IncorrectPassword.Size = new System.Drawing.Size(123, 15);
            this.Label_IncorrectPassword.TabIndex = 7;
            this.Label_IncorrectPassword.Text = "Password is incorrect";
            this.Label_IncorrectPassword.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Checkbox_ShowPassword
            // 
            this.Checkbox_ShowPassword.AutoSize = true;
            this.Checkbox_ShowPassword.Depth = 0;
            this.Checkbox_ShowPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.Checkbox_ShowPassword.Location = new System.Drawing.Point(380, 107);
            this.Checkbox_ShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.Checkbox_ShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Checkbox_ShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.Checkbox_ShowPassword.Name = "Checkbox_ShowPassword";
            this.Checkbox_ShowPassword.Ripple = true;
            this.Checkbox_ShowPassword.Size = new System.Drawing.Size(26, 30);
            this.Checkbox_ShowPassword.TabIndex = 8;
            this.Checkbox_ShowPassword.UseVisualStyleBackColor = true;
            this.Checkbox_ShowPassword.CheckedChanged += new System.EventHandler(this.Checkbox_ShowPassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SMD_Water_Station.Properties.Resources.clipart2178237;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(408, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 15);
            this.panel1.TabIndex = 9;
            // 
            // Label_PasswordsDoNotMatch
            // 
            this.Label_PasswordsDoNotMatch.AutoSize = true;
            this.Label_PasswordsDoNotMatch.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PasswordsDoNotMatch.ForeColor = System.Drawing.Color.Red;
            this.Label_PasswordsDoNotMatch.Location = new System.Drawing.Point(173, 174);
            this.Label_PasswordsDoNotMatch.Name = "Label_PasswordsDoNotMatch";
            this.Label_PasswordsDoNotMatch.Size = new System.Drawing.Size(143, 15);
            this.Label_PasswordsDoNotMatch.TabIndex = 10;
            this.Label_PasswordsDoNotMatch.Text = "Passwords do not match";
            this.Label_PasswordsDoNotMatch.Visible = false;
            // 
            // ChangePasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 268);
            this.Controls.Add(this.Label_PasswordsDoNotMatch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Checkbox_ShowPassword);
            this.Controls.Add(this.Label_IncorrectPassword);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Textfield_ConfirmPassword);
            this.Controls.Add(this.Textfield_NewPasssword);
            this.Controls.Add(this.Textfield_CurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_CurrentPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_NewPasssword;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_ConfirmPassword;
        private MaterialSkin.Controls.MaterialFlatButton Button_Save;
        private System.Windows.Forms.Label Label_IncorrectPassword;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialCheckBox Checkbox_ShowPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_PasswordsDoNotMatch;
    }
}
namespace SMD_Water_Station
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.Link_Signup = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Checkbox_showPassword = new MaterialSkin.Controls.MaterialCheckBox();
            this.Textbox_ID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textbox_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Label_UserID = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Link_Signup
            // 
            this.Link_Signup.AutoSize = true;
            this.Link_Signup.BackColor = System.Drawing.Color.Transparent;
            this.Link_Signup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Signup.Location = new System.Drawing.Point(206, 446);
            this.Link_Signup.Name = "Link_Signup";
            this.Link_Signup.Size = new System.Drawing.Size(62, 20);
            this.Link_Signup.TabIndex = 5;
            this.Link_Signup.TabStop = true;
            this.Link_Signup.Text = "Sign up.";
            this.Link_Signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Signup_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Checkbox_showPassword
            // 
            this.Checkbox_showPassword.AutoSize = true;
            this.Checkbox_showPassword.Depth = 0;
            this.Checkbox_showPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.Checkbox_showPassword.Location = new System.Drawing.Point(63, 275);
            this.Checkbox_showPassword.Margin = new System.Windows.Forms.Padding(0);
            this.Checkbox_showPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Checkbox_showPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.Checkbox_showPassword.Name = "Checkbox_showPassword";
            this.Checkbox_showPassword.Ripple = true;
            this.Checkbox_showPassword.Size = new System.Drawing.Size(26, 30);
            this.Checkbox_showPassword.TabIndex = 9;
            this.Checkbox_showPassword.UseVisualStyleBackColor = true;
            this.Checkbox_showPassword.CheckedChanged += new System.EventHandler(this.Checkbox_showPassword_CheckedChanged_1);
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Depth = 0;
            this.Textbox_ID.Hint = "";
            this.Textbox_ID.Location = new System.Drawing.Point(69, 197);
            this.Textbox_ID.MaxLength = 10;
            this.Textbox_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.PasswordChar = '\0';
            this.Textbox_ID.SelectedText = "";
            this.Textbox_ID.SelectionLength = 0;
            this.Textbox_ID.SelectionStart = 0;
            this.Textbox_ID.Size = new System.Drawing.Size(215, 28);
            this.Textbox_ID.TabIndex = 12;
            this.Textbox_ID.TabStop = false;
            this.Textbox_ID.UseSystemPasswordChar = false;
            // 
            // Textbox_password
            // 
            this.Textbox_password.Depth = 0;
            this.Textbox_password.Hint = "";
            this.Textbox_password.Location = new System.Drawing.Point(69, 253);
            this.Textbox_password.MaxLength = 20;
            this.Textbox_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_password.Name = "Textbox_password";
            this.Textbox_password.PasswordChar = '\0';
            this.Textbox_password.SelectedText = "";
            this.Textbox_password.SelectionLength = 0;
            this.Textbox_password.SelectionStart = 0;
            this.Textbox_password.Size = new System.Drawing.Size(215, 28);
            this.Textbox_password.TabIndex = 13;
            this.Textbox_password.TabStop = false;
            this.Textbox_password.UseSystemPasswordChar = true;
            this.Textbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_password_KeyDown);
            // 
            // Label_UserID
            // 
            this.Label_UserID.AutoSize = true;
            this.Label_UserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserID.ForeColor = System.Drawing.Color.Black;
            this.Label_UserID.Location = new System.Drawing.Point(66, 177);
            this.Label_UserID.Name = "Label_UserID";
            this.Label_UserID.Size = new System.Drawing.Size(66, 23);
            this.Label_UserID.TabIndex = 18;
            this.Label_UserID.Text = "User ID";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.ForeColor = System.Drawing.Color.Black;
            this.Label_Password.Location = new System.Drawing.Point(66, 233);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(80, 23);
            this.Label_Password.TabIndex = 19;
            this.Label_Password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(76, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Don\'t have an account?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(66, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sign in to get started.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Button_Submit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Textbox_password);
            this.panel2.Controls.Add(this.Link_Signup);
            this.panel2.Controls.Add(this.Label_UserID);
            this.panel2.Controls.Add(this.Checkbox_showPassword);
            this.panel2.Controls.Add(this.Textbox_ID);
            this.panel2.Controls.Add(this.Label_Password);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 476);
            this.panel2.TabIndex = 23;
            // 
            // Button_Submit
            // 
            this.Button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Submit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Submit.Location = new System.Drawing.Point(69, 323);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(215, 35);
            this.Button_Submit.TabIndex = 26;
            this.Button_Submit.Text = "Submit";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 60);
            this.label2.TabIndex = 25;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Show password";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(353, 476);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMD Water Station";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel Link_Signup;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialCheckBox Checkbox_showPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_ID;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_password;
        private System.Windows.Forms.Label Label_UserID;
        private System.Windows.Forms.Label Label_Password;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.Label label2;
    }
}


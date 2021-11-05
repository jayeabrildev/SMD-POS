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
            this.Button_signin = new MaterialSkin.Controls.MaterialFlatButton();
            this.Textbox_ID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textbox_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Label_UserID = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Link_Signup
            // 
            this.Link_Signup.AutoSize = true;
            this.Link_Signup.BackColor = System.Drawing.Color.Transparent;
            this.Link_Signup.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Signup.Location = new System.Drawing.Point(208, 446);
            this.Link_Signup.Name = "Link_Signup";
            this.Link_Signup.Size = new System.Drawing.Size(47, 14);
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
            this.Checkbox_showPassword.Location = new System.Drawing.Point(63, 280);
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
            // Button_signin
            // 
            this.Button_signin.AutoSize = true;
            this.Button_signin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_signin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Button_signin.Depth = 0;
            this.Button_signin.Icon = null;
            this.Button_signin.Location = new System.Drawing.Point(69, 324);
            this.Button_signin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_signin.MinimumSize = new System.Drawing.Size(215, 0);
            this.Button_signin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_signin.Name = "Button_signin";
            this.Button_signin.Primary = false;
            this.Button_signin.Size = new System.Drawing.Size(215, 36);
            this.Button_signin.TabIndex = 10;
            this.Button_signin.Text = "SUBMIT";
            this.Button_signin.UseVisualStyleBackColor = false;
            this.Button_signin.Click += new System.EventHandler(this.Button_signin_Click);
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Depth = 0;
            this.Textbox_ID.Hint = "";
            this.Textbox_ID.Location = new System.Drawing.Point(69, 207);
            this.Textbox_ID.MaxLength = 10;
            this.Textbox_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.PasswordChar = '\0';
            this.Textbox_ID.SelectedText = "";
            this.Textbox_ID.SelectionLength = 0;
            this.Textbox_ID.SelectionStart = 0;
            this.Textbox_ID.Size = new System.Drawing.Size(215, 23);
            this.Textbox_ID.TabIndex = 12;
            this.Textbox_ID.TabStop = false;
            this.Textbox_ID.UseSystemPasswordChar = false;
            // 
            // Textbox_password
            // 
            this.Textbox_password.Depth = 0;
            this.Textbox_password.Hint = "";
            this.Textbox_password.Location = new System.Drawing.Point(69, 254);
            this.Textbox_password.MaxLength = 20;
            this.Textbox_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_password.Name = "Textbox_password";
            this.Textbox_password.PasswordChar = '\0';
            this.Textbox_password.SelectedText = "";
            this.Textbox_password.SelectionLength = 0;
            this.Textbox_password.SelectionStart = 0;
            this.Textbox_password.Size = new System.Drawing.Size(215, 23);
            this.Textbox_password.TabIndex = 13;
            this.Textbox_password.TabStop = false;
            this.Textbox_password.UseSystemPasswordChar = true;
            this.Textbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_password_KeyDown);
            // 
            // Label_UserID
            // 
            this.Label_UserID.AutoSize = true;
            this.Label_UserID.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserID.ForeColor = System.Drawing.Color.DimGray;
            this.Label_UserID.Location = new System.Drawing.Point(66, 189);
            this.Label_UserID.Name = "Label_UserID";
            this.Label_UserID.Size = new System.Drawing.Size(45, 15);
            this.Label_UserID.TabIndex = 18;
            this.Label_UserID.Text = "User ID";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Password.Location = new System.Drawing.Point(66, 236);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(61, 15);
            this.Label_Password.TabIndex = 19;
            this.Label_Password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(89, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Don\'t have an account?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(121, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sign in to get started.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Textbox_password);
            this.panel2.Controls.Add(this.Link_Signup);
            this.panel2.Controls.Add(this.Label_UserID);
            this.panel2.Controls.Add(this.Checkbox_showPassword);
            this.panel2.Controls.Add(this.Textbox_ID);
            this.panel2.Controls.Add(this.Label_Password);
            this.panel2.Controls.Add(this.Button_signin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 476);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(92, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Show password";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SMD_Water_Station.Properties.Resources.NicePng_login_icon_png_1388174;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(126, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 23;
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
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
        private MaterialSkin.Controls.MaterialFlatButton Button_signin;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_ID;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_password;
        private System.Windows.Forms.Label Label_UserID;
        private System.Windows.Forms.Label Label_Password;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}


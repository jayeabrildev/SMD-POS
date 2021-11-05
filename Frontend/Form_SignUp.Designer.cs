namespace SMD_Water_Station
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.Link_signin = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Header_Password = new System.Windows.Forms.Label();
            this.Label_newUserID = new System.Windows.Forms.Label();
            this.Header_ConfirmPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Header_Firstname = new System.Windows.Forms.Label();
            this.Header_Surname = new System.Windows.Forms.Label();
            this.Label_passwordCheck = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Textbox_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textbox_confirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textbox_firstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Textbox_surname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Button_submit = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // Link_signin
            // 
            this.Link_signin.AutoSize = true;
            this.Link_signin.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_signin.Location = new System.Drawing.Point(228, 571);
            this.Link_signin.Name = "Link_signin";
            this.Link_signin.Size = new System.Drawing.Size(41, 14);
            this.Link_signin.TabIndex = 5;
            this.Link_signin.TabStop = true;
            this.Link_signin.Text = "Sign in";
            this.Link_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_signin_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(98, 571);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 14);
            this.label10.TabIndex = 8;
            this.label10.Text = "Already have an account?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(76, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "User ID";
            // 
            // Header_Password
            // 
            this.Header_Password.AutoSize = true;
            this.Header_Password.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Password.ForeColor = System.Drawing.Color.DimGray;
            this.Header_Password.Location = new System.Drawing.Point(76, 221);
            this.Header_Password.Name = "Header_Password";
            this.Header_Password.Size = new System.Drawing.Size(56, 14);
            this.Header_Password.TabIndex = 5;
            this.Header_Password.Text = "Password";
            // 
            // Label_newUserID
            // 
            this.Label_newUserID.AutoSize = true;
            this.Label_newUserID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_newUserID.Location = new System.Drawing.Point(82, 171);
            this.Label_newUserID.Name = "Label_newUserID";
            this.Label_newUserID.Size = new System.Drawing.Size(89, 19);
            this.Label_newUserID.TabIndex = 6;
            this.Label_newUserID.Text = "0000000000";
            // 
            // Header_ConfirmPassword
            // 
            this.Header_ConfirmPassword.AutoSize = true;
            this.Header_ConfirmPassword.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_ConfirmPassword.ForeColor = System.Drawing.Color.DimGray;
            this.Header_ConfirmPassword.Location = new System.Drawing.Point(76, 277);
            this.Header_ConfirmPassword.Name = "Header_ConfirmPassword";
            this.Header_ConfirmPassword.Size = new System.Drawing.Size(98, 14);
            this.Header_ConfirmPassword.TabIndex = 8;
            this.Header_ConfirmPassword.Text = "Confirm password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(80, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "*User ID is auto-generated";
            // 
            // Header_Firstname
            // 
            this.Header_Firstname.AutoSize = true;
            this.Header_Firstname.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Firstname.ForeColor = System.Drawing.Color.DimGray;
            this.Header_Firstname.Location = new System.Drawing.Point(76, 365);
            this.Header_Firstname.Name = "Header_Firstname";
            this.Header_Firstname.Size = new System.Drawing.Size(58, 14);
            this.Header_Firstname.TabIndex = 13;
            this.Header_Firstname.Text = "Firstname";
            // 
            // Header_Surname
            // 
            this.Header_Surname.AutoSize = true;
            this.Header_Surname.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Surname.ForeColor = System.Drawing.Color.DimGray;
            this.Header_Surname.Location = new System.Drawing.Point(76, 421);
            this.Header_Surname.Name = "Header_Surname";
            this.Header_Surname.Size = new System.Drawing.Size(52, 14);
            this.Header_Surname.TabIndex = 15;
            this.Header_Surname.Text = "Surname";
            // 
            // Label_passwordCheck
            // 
            this.Label_passwordCheck.AutoSize = true;
            this.Label_passwordCheck.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_passwordCheck.ForeColor = System.Drawing.Color.Red;
            this.Label_passwordCheck.Location = new System.Drawing.Point(76, 320);
            this.Label_passwordCheck.Name = "Label_passwordCheck";
            this.Label_passwordCheck.Size = new System.Drawing.Size(155, 15);
            this.Label_passwordCheck.TabIndex = 17;
            this.Label_passwordCheck.Text = "Passwords does not match";
            this.Label_passwordCheck.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SMD_Water_Station.Properties.Resources.kisspng_yocale_logo_business_cards_sales_5ae5f67cc554d1_0431589215250202848083;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(83, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 80);
            this.panel3.TabIndex = 24;
            // 
            // Textbox_password
            // 
            this.Textbox_password.Depth = 0;
            this.Textbox_password.Hint = "";
            this.Textbox_password.Location = new System.Drawing.Point(79, 239);
            this.Textbox_password.MaxLength = 20;
            this.Textbox_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_password.Name = "Textbox_password";
            this.Textbox_password.PasswordChar = '\0';
            this.Textbox_password.SelectedText = "";
            this.Textbox_password.SelectionLength = 0;
            this.Textbox_password.SelectionStart = 0;
            this.Textbox_password.Size = new System.Drawing.Size(215, 23);
            this.Textbox_password.TabIndex = 25;
            this.Textbox_password.TabStop = false;
            this.Textbox_password.UseSystemPasswordChar = true;
            // 
            // Textbox_confirmPassword
            // 
            this.Textbox_confirmPassword.Depth = 0;
            this.Textbox_confirmPassword.Hint = "";
            this.Textbox_confirmPassword.Location = new System.Drawing.Point(79, 295);
            this.Textbox_confirmPassword.MaxLength = 20;
            this.Textbox_confirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_confirmPassword.Name = "Textbox_confirmPassword";
            this.Textbox_confirmPassword.PasswordChar = '\0';
            this.Textbox_confirmPassword.SelectedText = "";
            this.Textbox_confirmPassword.SelectionLength = 0;
            this.Textbox_confirmPassword.SelectionStart = 0;
            this.Textbox_confirmPassword.Size = new System.Drawing.Size(215, 23);
            this.Textbox_confirmPassword.TabIndex = 26;
            this.Textbox_confirmPassword.TabStop = false;
            this.Textbox_confirmPassword.UseSystemPasswordChar = true;
            this.Textbox_confirmPassword.TextChanged += new System.EventHandler(this.Textbox_confirmPassword_TextChanged);
            // 
            // Textbox_firstname
            // 
            this.Textbox_firstname.Depth = 0;
            this.Textbox_firstname.Hint = "";
            this.Textbox_firstname.Location = new System.Drawing.Point(79, 382);
            this.Textbox_firstname.MaxLength = 20;
            this.Textbox_firstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_firstname.Name = "Textbox_firstname";
            this.Textbox_firstname.PasswordChar = '\0';
            this.Textbox_firstname.SelectedText = "";
            this.Textbox_firstname.SelectionLength = 0;
            this.Textbox_firstname.SelectionStart = 0;
            this.Textbox_firstname.Size = new System.Drawing.Size(215, 23);
            this.Textbox_firstname.TabIndex = 27;
            this.Textbox_firstname.TabStop = false;
            this.Textbox_firstname.UseSystemPasswordChar = false;
            // 
            // Textbox_surname
            // 
            this.Textbox_surname.Depth = 0;
            this.Textbox_surname.Hint = "";
            this.Textbox_surname.Location = new System.Drawing.Point(79, 438);
            this.Textbox_surname.MaxLength = 20;
            this.Textbox_surname.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textbox_surname.Name = "Textbox_surname";
            this.Textbox_surname.PasswordChar = '\0';
            this.Textbox_surname.SelectedText = "";
            this.Textbox_surname.SelectionLength = 0;
            this.Textbox_surname.SelectionStart = 0;
            this.Textbox_surname.Size = new System.Drawing.Size(215, 23);
            this.Textbox_surname.TabIndex = 28;
            this.Textbox_surname.TabStop = false;
            this.Textbox_surname.UseSystemPasswordChar = false;
            // 
            // Button_submit
            // 
            this.Button_submit.AutoSize = true;
            this.Button_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_submit.BackColor = System.Drawing.Color.DarkGray;
            this.Button_submit.Depth = 0;
            this.Button_submit.Icon = null;
            this.Button_submit.Location = new System.Drawing.Point(79, 481);
            this.Button_submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_submit.MinimumSize = new System.Drawing.Size(215, 0);
            this.Button_submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_submit.Name = "Button_submit";
            this.Button_submit.Primary = false;
            this.Button_submit.Size = new System.Drawing.Size(215, 36);
            this.Button_submit.TabIndex = 29;
            this.Button_submit.Text = "SUBMIT";
            this.Button_submit.UseVisualStyleBackColor = false;
            this.Button_submit.Click += new System.EventHandler(this.Button_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sign up";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(173, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "Get involved.";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(79, 342);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(215, 5);
            this.materialDivider1.TabIndex = 32;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 599);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_submit);
            this.Controls.Add(this.Textbox_surname);
            this.Controls.Add(this.Textbox_firstname);
            this.Controls.Add(this.Textbox_confirmPassword);
            this.Controls.Add(this.Textbox_password);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Label_passwordCheck);
            this.Controls.Add(this.Header_Surname);
            this.Controls.Add(this.Header_Firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Header_ConfirmPassword);
            this.Controls.Add(this.Link_signin);
            this.Controls.Add(this.Label_newUserID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Header_Password);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(94, 69);
            this.MaximizeBox = false;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMD Water Station";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Signup_FormClosed);
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel Link_signin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Header_Password;
        private System.Windows.Forms.Label Label_newUserID;
        private System.Windows.Forms.Label Header_ConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Header_Firstname;
        private System.Windows.Forms.Label Header_Surname;
        private System.Windows.Forms.Label Label_passwordCheck;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_confirmPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_firstname;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textbox_surname;
        private MaterialSkin.Controls.MaterialFlatButton Button_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.button_submit = new System.Windows.Forms.Button();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_confirmPassword = new System.Windows.Forms.TextBox();
            this.textbox_firstname = new System.Windows.Forms.TextBox();
            this.textbox_surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Link_signin
            // 
            this.Link_signin.AutoSize = true;
            this.Link_signin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_signin.Location = new System.Drawing.Point(242, 571);
            this.Link_signin.Name = "Link_signin";
            this.Link_signin.Size = new System.Drawing.Size(50, 19);
            this.Link_signin.TabIndex = 5;
            this.Link_signin.TabStop = true;
            this.Link_signin.Text = "Sign in";
            this.Link_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_signin_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(71, 571);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Already have an account?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "User ID";
            // 
            // Header_Password
            // 
            this.Header_Password.AutoSize = true;
            this.Header_Password.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Password.ForeColor = System.Drawing.Color.White;
            this.Header_Password.Location = new System.Drawing.Point(58, 219);
            this.Header_Password.Name = "Header_Password";
            this.Header_Password.Size = new System.Drawing.Size(67, 19);
            this.Header_Password.TabIndex = 5;
            this.Header_Password.Text = "Password";
            // 
            // Label_newUserID
            // 
            this.Label_newUserID.AutoSize = true;
            this.Label_newUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_newUserID.Location = new System.Drawing.Point(72, 171);
            this.Label_newUserID.Name = "Label_newUserID";
            this.Label_newUserID.Size = new System.Drawing.Size(89, 20);
            this.Label_newUserID.TabIndex = 6;
            this.Label_newUserID.Text = "0000000000";
            // 
            // Header_ConfirmPassword
            // 
            this.Header_ConfirmPassword.AutoSize = true;
            this.Header_ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_ConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.Header_ConfirmPassword.Location = new System.Drawing.Point(58, 275);
            this.Header_ConfirmPassword.Name = "Header_ConfirmPassword";
            this.Header_ConfirmPassword.Size = new System.Drawing.Size(120, 19);
            this.Header_ConfirmPassword.TabIndex = 8;
            this.Header_ConfirmPassword.Text = "Confirm password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "*User ID is auto-generated";
            // 
            // Header_Firstname
            // 
            this.Header_Firstname.AutoSize = true;
            this.Header_Firstname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Firstname.ForeColor = System.Drawing.Color.White;
            this.Header_Firstname.Location = new System.Drawing.Point(58, 363);
            this.Header_Firstname.Name = "Header_Firstname";
            this.Header_Firstname.Size = new System.Drawing.Size(69, 19);
            this.Header_Firstname.TabIndex = 13;
            this.Header_Firstname.Text = "Firstname";
            // 
            // Header_Surname
            // 
            this.Header_Surname.AutoSize = true;
            this.Header_Surname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Surname.ForeColor = System.Drawing.Color.White;
            this.Header_Surname.Location = new System.Drawing.Point(58, 419);
            this.Header_Surname.Name = "Header_Surname";
            this.Header_Surname.Size = new System.Drawing.Size(63, 19);
            this.Header_Surname.TabIndex = 15;
            this.Header_Surname.Text = "Surname";
            // 
            // Label_passwordCheck
            // 
            this.Label_passwordCheck.AutoSize = true;
            this.Label_passwordCheck.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_passwordCheck.ForeColor = System.Drawing.Color.Red;
            this.Label_passwordCheck.Location = new System.Drawing.Point(58, 320);
            this.Label_passwordCheck.Name = "Label_passwordCheck";
            this.Label_passwordCheck.Size = new System.Drawing.Size(173, 19);
            this.Label_passwordCheck.TabIndex = 17;
            this.Label_passwordCheck.Text = "Passwords does not match";
            this.Label_passwordCheck.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 51);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sign up";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(67, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
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
            this.materialDivider1.Location = new System.Drawing.Point(62, 351);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(250, 5);
            this.materialDivider1.TabIndex = 32;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.button_submit.FlatAppearance.BorderSize = 0;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(62, 481);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(250, 32);
            this.button_submit.TabIndex = 33;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.Button_submit_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.textbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_password.ForeColor = System.Drawing.Color.White;
            this.textbox_password.Location = new System.Drawing.Point(62, 241);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(250, 23);
            this.textbox_password.TabIndex = 34;
            this.textbox_password.UseSystemPasswordChar = true;
            // 
            // textbox_confirmPassword
            // 
            this.textbox_confirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.textbox_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_confirmPassword.ForeColor = System.Drawing.Color.White;
            this.textbox_confirmPassword.Location = new System.Drawing.Point(62, 297);
            this.textbox_confirmPassword.Name = "textbox_confirmPassword";
            this.textbox_confirmPassword.Size = new System.Drawing.Size(250, 23);
            this.textbox_confirmPassword.TabIndex = 35;
            this.textbox_confirmPassword.UseSystemPasswordChar = true;
            this.textbox_confirmPassword.TextChanged += new System.EventHandler(this.Textbox_confirmPassword_TextChanged);
            // 
            // textbox_firstname
            // 
            this.textbox_firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.textbox_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_firstname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_firstname.ForeColor = System.Drawing.Color.White;
            this.textbox_firstname.Location = new System.Drawing.Point(62, 385);
            this.textbox_firstname.Name = "textbox_firstname";
            this.textbox_firstname.Size = new System.Drawing.Size(250, 23);
            this.textbox_firstname.TabIndex = 36;
            // 
            // textbox_surname
            // 
            this.textbox_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.textbox_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_surname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_surname.ForeColor = System.Drawing.Color.White;
            this.textbox_surname.Location = new System.Drawing.Point(62, 441);
            this.textbox_surname.Name = "textbox_surname";
            this.textbox_surname.Size = new System.Drawing.Size(250, 23);
            this.textbox_surname.TabIndex = 37;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(374, 599);
            this.Controls.Add(this.textbox_surname);
            this.Controls.Add(this.textbox_firstname);
            this.Controls.Add(this.textbox_confirmPassword);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
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
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_confirmPassword;
        private System.Windows.Forms.TextBox textbox_firstname;
        private System.Windows.Forms.TextBox textbox_surname;
    }
}
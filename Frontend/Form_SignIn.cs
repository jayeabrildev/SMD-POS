using SMD_Water_Station.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMD_Water_Station
{
    public partial class Signin : Form
    {

        public Signin()
        {
            InitializeComponent();

        }

        //Link: Sign up
        private void Link_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.signIn.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        //Checkbox: Show password
        private void Checkbox_showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Checkbox_showPassword.Checked == true)
            {
                Textbox_password.UseSystemPasswordChar = false;
            }
            else
            {
                Textbox_password.UseSystemPasswordChar = true;
            }
        }

        //Button: Sign in
        private void Button_signin_Click(object sender, EventArgs e)
        {
            User.userID = Textbox_ID.Text.Trim();
            User.password = Textbox_password.Text.Trim();

            if (User.SignIn() == true)
            {
                User.GetAccountDetails();
                FormHandler.signIn.Hide();
                FormHandler.signIn.Textbox_password.Clear();
                FormHandler.ShowMaininterface();
            }
            else
            {
                Label_UserID.ForeColor = Color.Red;
                Label_Password.ForeColor = Color.Red;
                timer1.Enabled = true;
            }
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            Label_UserID.ForeColor = Color.DimGray;
            Label_Password.ForeColor = Color.DimGray;
            timer1.Enabled = false;
        }

        private void Textbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_signin_Click(this, new EventArgs());
            }
        }

    }
}

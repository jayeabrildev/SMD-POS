using SMD_Water_Station.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;
using Models;
using SMD_Water_Station.Frontend;

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
            Form_signup_personal signup = new Form_signup_personal();
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
                Button_Submit_Click(this, new EventArgs());
            }
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userId = Textbox_ID.Text.TrimEnd();
            user.password = Textbox_password.Text.Trim();

            if (user.SignIn() == true)
            {
                User._userID = user.userId;
                FormHandler.signIn.Hide();
                FormHandler.signIn.Textbox_password.Clear();
                MainWindow main = new MainWindow();
                main.Show();
            }
            else
            {
                Label_UserID.ForeColor = Color.Red;
                Label_Password.ForeColor = Color.Red;
                timer1.Enabled = true;
            }
        }
    }
}

using SMD_Water_Station.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

using Models;
namespace SMD_Water_Station
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        //Events
        private void Link_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Signup_Load(object sender, System.EventArgs e)
        {
            Reset();
        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHandler.signIn.Show();
        }

        private void Button_submit_Click(object sender, EventArgs e)
        {
            if (textbox_password.TextLength == 0 || textbox_confirmPassword.TextLength == 0 ||
                textbox_firstname.TextLength == 0 || textbox_surname.TextLength == 0 ||
                textbox_password.Text.Trim() == "" || textbox_confirmPassword.Text.Trim() == "" ||
                textbox_firstname.Text.Trim() == "" || textbox_surname.Text.Trim() == "")
            {
                if (textbox_password.TextLength == 0 || textbox_password.Text.Trim() == "")
                {
                    Header_Password.ForeColor = Color.Red;
                }
                if (textbox_confirmPassword.TextLength == 0 || textbox_confirmPassword.Text.Trim() == "")
                {
                    Header_ConfirmPassword.ForeColor = Color.Red;
                }
                if (textbox_firstname.TextLength == 0 || textbox_firstname.Text.Trim() == "")
                {
                    Header_Firstname.ForeColor = Color.Red;
                }
                if (textbox_surname.TextLength == 0 || textbox_surname.Text.Trim() == "")
                {
                    Header_Surname.ForeColor = Color.Red;
                }
                timer1.Enabled = true;
            }
            else
            {
                if (textbox_password.Text != textbox_confirmPassword.Text)
                {
                    Header_Password.ForeColor = Color.Red;
                    Header_ConfirmPassword.ForeColor = Color.Red;
                    Label_passwordCheck.Visible = true;
                }
                else
                {
                    User user = new User();
                    user.userId = Label_newUserID.Text;
                    user.password = textbox_confirmPassword.Text.Trim();
                    user.firstname = textbox_firstname.Text.TrimEnd();
                    user.surname = textbox_surname.Text.TrimEnd();
                    user.Register();

                    Reset();

                    MessageBox.Show("Registration Successful", "SMD Water Station", MessageBoxButtons.OK);
                }
            }
        }

        private void Textbox_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (textbox_password.Text != textbox_confirmPassword.Text)
            {
                Label_passwordCheck.Visible = true;

            }
            else
            {
                Label_passwordCheck.Visible = false;
            }
        }

        //Methods
        private void Reset()
        {
            textbox_password.Clear();
            textbox_confirmPassword.Clear();
            textbox_firstname.Clear();
            textbox_surname.Clear();

            User user = new User();
            Label_newUserID.Text = user.GenerateUserID();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Header_Password.ForeColor = Color.DimGray;
            Header_ConfirmPassword.ForeColor = Color.DimGray;
            Header_Firstname.ForeColor = Color.DimGray;
            Header_Surname.ForeColor = Color.DimGray;
            timer1.Enabled = false;
        }

        private void CheckInputs()
        {
            if(textbox_firstname.Text.TrimEnd().Length == 0 || textbox_surname.Text.TrimEnd().Length == 0 || textbox_password.Text.TrimEnd().Length == 0
                || textbox_confirmPassword.Text.TrimEnd().Length == 0)
            {
                button_submit.Enabled = false;
            }
            else
            {
                button_submit.Enabled = true;
            }
        }
    }
}

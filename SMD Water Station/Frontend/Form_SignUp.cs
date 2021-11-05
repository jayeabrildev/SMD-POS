using SMD_Water_Station.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            if (Textbox_password.TextLength == 0 || Textbox_confirmPassword.TextLength == 0 ||
                Textbox_firstname.TextLength == 0 || Textbox_surname.TextLength == 0 ||
                Textbox_password.Text.Trim() == "" || Textbox_confirmPassword.Text.Trim() == "" ||
                Textbox_firstname.Text.Trim() == "" || Textbox_surname.Text.Trim() == "")
            {
                if (Textbox_password.TextLength == 0 || Textbox_password.Text.Trim() == "")
                {
                    Header_Password.ForeColor = Color.Red;
                }
                if (Textbox_confirmPassword.TextLength == 0 || Textbox_confirmPassword.Text.Trim() == "")
                {
                    Header_ConfirmPassword.ForeColor = Color.Red;
                }
                if (Textbox_firstname.TextLength == 0 || Textbox_firstname.Text.Trim() == "")
                {
                    Header_Firstname.ForeColor = Color.Red;
                }
                if (Textbox_surname.TextLength == 0 || Textbox_surname.Text.Trim() == "")
                {
                    Header_Surname.ForeColor = Color.Red;
                }
                timer1.Enabled = true;
            }
            else
            {
                if (Textbox_password.Text != Textbox_confirmPassword.Text)
                {
                    Header_Password.ForeColor = Color.Red;
                    Header_ConfirmPassword.ForeColor = Color.Red;
                    Label_passwordCheck.Visible = true;
                }
                else
                {
                    User.newUserID = Label_newUserID.Text;
                    User.newPassword = Textbox_confirmPassword.Text.Trim();
                    User.newFirstname = Textbox_firstname.Text.TrimEnd();
                    User.newSurname = Textbox_surname.Text.TrimEnd();

                    User.Register();

                    Reset();

                    MessageBox.Show("Registration Successful", "SMD Water Station", MessageBoxButtons.OK);
                }
            }
        }

        private void Textbox_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (Textbox_password.Text != Textbox_confirmPassword.Text)
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
            Textbox_password.Clear();
            Textbox_confirmPassword.Clear();
            Textbox_firstname.Clear();
            Textbox_surname.Clear();

            User.newUserID = null;
            User.newPassword = null;
            User.newFirstname = null;
            User.newSurname = null;

            var user = new User();
            Label_newUserID.Text = user.NewUserID();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Header_Password.ForeColor = Color.DimGray;
            Header_ConfirmPassword.ForeColor = Color.DimGray;
            Header_Firstname.ForeColor = Color.DimGray;
            Header_Surname.ForeColor = Color.DimGray;
            timer1.Enabled = false;
        }
    }
}

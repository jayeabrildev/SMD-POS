using MySql.Data.MySqlClient;
using SMD_Water_Station.Classes;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend.DialogBoxes
{
    public partial class ChangePasswordDialog : Form
    {
        bool passwordMatch = false;

        public ChangePasswordDialog()
        {
            InitializeComponent();
        }

        //Methods
        private bool PasswordCheck()
        {
            string query = "SELECT password FROM accounts WHERE userid = '" + User.userID + "'";

            Database.OpenConnection();
            MySqlDataReader reader = Database.Data_Reader(query);

            string currentPassword = "";
            while (reader.Read())
            {
                currentPassword = reader.GetString(0);
            }


            Database.CloseConnection();

            if (currentPassword == Textfield_CurrentPassword.Text.Trim())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (PasswordCheck() == true && passwordMatch == true)
            {
                User.ChangePassword(Textfield_ConfirmPassword.Text.Trim());
                this.Close();
            }
            else
            {
                Label_IncorrectPassword.Visible = true;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label_IncorrectPassword.Visible = false;
            timer1.Enabled = false;
        }



        private void Checkbox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_ShowPassword.Checked == true)
            {
                Textfield_NewPasssword.UseSystemPasswordChar = false;
            }
            else
            {
                Textfield_NewPasssword.UseSystemPasswordChar = true;
            }
        }

        private void Textfield_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (Textfield_NewPasssword.Text.Trim() != Textfield_ConfirmPassword.Text.Trim())
            {
                Label_PasswordsDoNotMatch.Visible = true;
                passwordMatch = false;
            }
            else
            {
                Label_PasswordsDoNotMatch.Visible = false;
                passwordMatch = true;
            }
        }
    }
}

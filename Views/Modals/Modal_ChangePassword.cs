using Models;
using SMD_Water_Station.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_Water_Station.Views.Modals
{
    public partial class Modal_ChangePassword : Form
    {
        User user = new User();
        public Modal_ChangePassword()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modal_ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void textbox_currentPassword_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void Validate()
        {
            user.userId = User._userID;
            user.password = textbox_currentPassword.Text.TrimEnd();

            if (user.SignIn() == true)
            {
                if(textbox_newPass.Text.Length == 0 || textbox_confirmNewPass.Text.Length == 0)
                {
                    button_save.Enabled = false;
                }
                else if (textbox_newPass.Text.TrimEnd() == textbox_confirmNewPass.Text.TrimEnd())
                {
                    button_save.Enabled = true;
                }
            }
            else
            {
                button_save.Enabled = false;
            }
        }

        private void textbox_newPass_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void textbox_confirmNewPass_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ChangePassword(textbox_confirmNewPass.Text.TrimEnd(), User._userID);
            FormHandler.CloseMainInterface();
            FormHandler.signIn.Show();
        }
    }
}

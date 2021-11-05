using Models;
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
    public partial class Modal_EditPersonal : Form
    {
        public string userID;
        public string firstname;
        public string lastname;
        public Modal_EditPersonal()
        {
            InitializeComponent();
        }

        private void Modal_EditPersonal_Load(object sender, EventArgs e)
        {
            userID = User._userID;
            textbox_firstname.Text = firstname;
            textbox_lastname.Text = lastname;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_firstname_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void textbox_lastname_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void ValidateName()
        {
            if (textbox_firstname.Text.TrimEnd() == firstname && textbox_lastname.Text.TrimEnd() == lastname)
            {
                button_save.Enabled = false;
            }
            else
            {
                button_save.Enabled = true;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            User user = new User();
            string newFirstname = textbox_firstname.Text.TrimEnd();
            string newSurname = textbox_lastname.Text.TrimEnd();
            user.UpdateInformation(newFirstname, newSurname, userID);
        }
    }
}

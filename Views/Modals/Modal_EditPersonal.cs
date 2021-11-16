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
        public string address;
        public string contact;
        public string email;


        public Modal_EditPersonal()
        {
            InitializeComponent();
        }

        private void Modal_EditPersonal_Load(object sender, EventArgs e)
        {
            userID = User._userID;
            textbox_firstname.Text = firstname;
            textbox_lastname.Text = lastname;
            textbox_address.Text = address;
            textbox_contactnumber.Text = contact;
            textbox_email.Text = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_firstname_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void textbox_lastname_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void CheckEmpty()
        {
            TextBox[] textboxes = { textbox_firstname, textbox_lastname, textbox_address, textbox_contactnumber, textbox_email };
            foreach (TextBox textbox in textboxes)
            {
                if (textbox.Text.Length == 0 || textbox.Text.TrimEnd() == "") 
                {
                    button_save.Enabled = false;
                }
                else
                {
                    button_save.Enabled = true;
                }
            }
        }

        

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                string newFirstname = textbox_firstname.Text.TrimEnd();
                string newSurname = textbox_lastname.Text.TrimEnd();
                string newAddress = textbox_address.Text.TrimEnd();
                string newContact = textbox_contactnumber.Text.TrimEnd();
                string newEmail = textbox_email.Text.TrimEnd();

                user.UpdateInformation(newFirstname, newSurname, newAddress, newContact, newEmail, userID);
                MessageBox.Show("Updated Successfully", "Message");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

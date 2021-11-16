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

namespace SMD_Water_Station.Frontend
{
    public partial class Form_signup_personal : Form
    {
        User user;

        public Form_signup_personal()
        {
            InitializeComponent();
        }
        //Events
        private void textbox_firstname_TextChanged(object sender, EventArgs e)
        {
            CheckEmpty();
        }

        private void textbox_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            user.password = textbox_confirmPassword.Text.TrimEnd();
            ShowPersonalDetails();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ShowAccountDetails();
        }

        private void textbox_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (textbox_password.Text != textbox_confirmPassword.Text)
            {
                Label_passwordCheck.Visible = true;
                button_next.Enabled = false;

            }
            else
            {
                Label_passwordCheck.Visible = false;
                button_next.Enabled = true;
            }
        }


        private void button_submit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are the informations you entered correct?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(res == DialogResult.OK)
            {
                user.firstname = textbox_firstname.Text.TrimEnd();
                user.surname = textbox_surname.Text.TrimEnd();
                user.contact = textbox_contact.Text.TrimEnd();
                user.address = textbox_address.Text.TrimEnd();
                user.email = textbox_email.Text.TrimEnd();

                if(user.Register() == true)
                {
                    MessageBox.Show("Registration Successful");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "Error");
                }

            }
        }
        
        //Functions
        private void CheckEmpty()
        {
            TextBox[] textboxes = { textbox_firstname, textbox_surname, textbox_address, textbox_contact, textbox_email};
            foreach (TextBox textbox in textboxes)
            {
                if (textbox.Text.Length == 0 || textbox.Text.TrimEnd() == "")
                {
                    button_submit.Enabled = false;
                }
                else
                {
                    button_submit.Enabled = true;
                }
            }
        }
        
        private void ShowAccountDetails()
        {
            panel_personaldetails.Visible = false;
            panel_accountdetails.Visible = true;
        }
        
        private void ShowPersonalDetails()
        {
            panel_personaldetails.Visible = true;
            panel_accountdetails.Visible = false;

            panel_personaldetails.Location = new Point(24, 24);
        }

        private void Form_signup_personal_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            user = new User();
            user.userId = user.GenerateUserID();
            Label_newUserID.Text = user.userId;

            textbox_password.Clear();
            textbox_confirmPassword.Clear();
            textbox_firstname.Clear();
            textbox_surname.Clear();
            textbox_contact.Clear();
            textbox_address.Clear();
            textbox_email.Clear();

            button_next.Enabled = false;
            button_submit.Enabled = false;

            ShowAccountDetails();
        }

        private void Link_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.signIn.Show();
            this.Close();
        }
    }
}

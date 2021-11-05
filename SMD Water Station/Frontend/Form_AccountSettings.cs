using SMD_Water_Station.Classes;
using SMD_Water_Station.Frontend.DialogBoxes;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend
{
    public partial class Form_AccountSettings : Form
    {
        public Form_AccountSettings()
        {
            InitializeComponent();
        }



        //Events
        private void Link_ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordDialog change = new ChangePasswordDialog();
            change.ShowDialog(this);
        }

        private void Link_EditPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditPersonalInformationDialog edit = new EditPersonalInformationDialog();
            edit.ShowDialog(this);
        }

        private void Form_AccountSettings_Load(object sender, EventArgs e)
        {
            Label_UserID.Text = User.userID;
            Label_Fullname.Text = User.GetAccountDetails();
        }
    }
}

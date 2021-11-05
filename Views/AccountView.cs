﻿using Models;
using SMD_Water_Station.Views.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_Water_Station.Views
{
    public partial class AccountView : UserControl
    {
        User user = new User();

        public AccountView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void button_editPersonal_Click(object sender, EventArgs e)
        {
            Modal_EditPersonal editPersonal = new Modal_EditPersonal();
            editPersonal.firstname = user.firstname;
            editPersonal.lastname = user.surname;
            editPersonal.ShowDialog();
            if (editPersonal.DialogResult == DialogResult.OK)
            {
                LoadAccount();
            }
        }

        private void LoadAccount()
        {
            user.GetFullname();
            label_firstname.Text = user.firstname;
            label_lastname.Text = user.surname;
            label_accountID.Text = User._userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modal_ChangePassword changePass = new Modal_ChangePassword();
            changePass.ShowDialog();
        }
    }
}

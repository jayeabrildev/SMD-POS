using SMD_Water_Station.Classes;
using System;
using System.Windows.Forms;

namespace SMD_Water_Station.Frontend.DialogBoxes
{
    public partial class EditPersonalInformationDialog : Form
    {
        public EditPersonalInformationDialog()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Textfield_Firstname.TextLength == 0 || Textfield_Surname.TextLength == 0)
            {
                Label_FillAllFields.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                User.UpdateInformation(Textfield_Firstname.Text.TrimEnd(), Textfield_Surname.Text.TrimEnd());
                PageHandler._accountSettings.Label_Fullname.Text = User.GetAccountDetails();
                FormHandler.MainInterface.Account_name.Text = User.GetAccountDetails();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label_FillAllFields.Visible = false;
            timer1.Enabled = false;
        }

        private void EditPersonalInformationDialog_Load(object sender, EventArgs e)
        {

        }
    }
}

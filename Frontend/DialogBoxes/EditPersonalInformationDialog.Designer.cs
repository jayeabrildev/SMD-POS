namespace SMD_Water_Station.Frontend.DialogBoxes
{
    partial class EditPersonalInformationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPersonalInformationDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.Textfield_Firstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.Textfield_Surname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Button_Save = new MaterialSkin.Controls.MaterialFlatButton();
            this.Label_FillAllFields = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firstname";
            // 
            // Textfield_Firstname
            // 
            this.Textfield_Firstname.Depth = 0;
            this.Textfield_Firstname.Hint = "";
            this.Textfield_Firstname.Location = new System.Drawing.Point(146, 76);
            this.Textfield_Firstname.MaxLength = 30;
            this.Textfield_Firstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_Firstname.Name = "Textfield_Firstname";
            this.Textfield_Firstname.PasswordChar = '\0';
            this.Textfield_Firstname.SelectedText = "";
            this.Textfield_Firstname.SelectionLength = 0;
            this.Textfield_Firstname.SelectionStart = 0;
            this.Textfield_Firstname.Size = new System.Drawing.Size(199, 23);
            this.Textfield_Firstname.TabIndex = 2;
            this.Textfield_Firstname.TabStop = false;
            this.Textfield_Firstname.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // Textfield_Surname
            // 
            this.Textfield_Surname.Depth = 0;
            this.Textfield_Surname.Hint = "";
            this.Textfield_Surname.Location = new System.Drawing.Point(146, 124);
            this.Textfield_Surname.MaxLength = 30;
            this.Textfield_Surname.MouseState = MaterialSkin.MouseState.HOVER;
            this.Textfield_Surname.Name = "Textfield_Surname";
            this.Textfield_Surname.PasswordChar = '\0';
            this.Textfield_Surname.SelectedText = "";
            this.Textfield_Surname.SelectionLength = 0;
            this.Textfield_Surname.SelectionStart = 0;
            this.Textfield_Surname.Size = new System.Drawing.Size(199, 23);
            this.Textfield_Surname.TabIndex = 4;
            this.Textfield_Surname.TabStop = false;
            this.Textfield_Surname.UseSystemPasswordChar = false;
            // 
            // Button_Save
            // 
            this.Button_Save.AutoSize = true;
            this.Button_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Save.Depth = 0;
            this.Button_Save.Icon = null;
            this.Button_Save.Location = new System.Drawing.Point(78, 187);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Save.MinimumSize = new System.Drawing.Size(250, 36);
            this.Button_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Primary = false;
            this.Button_Save.Size = new System.Drawing.Size(250, 36);
            this.Button_Save.TabIndex = 5;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_FillAllFields
            // 
            this.Label_FillAllFields.AutoSize = true;
            this.Label_FillAllFields.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FillAllFields.ForeColor = System.Drawing.Color.Red;
            this.Label_FillAllFields.Location = new System.Drawing.Point(60, 158);
            this.Label_FillAllFields.Name = "Label_FillAllFields";
            this.Label_FillAllFields.Size = new System.Drawing.Size(174, 15);
            this.Label_FillAllFields.TabIndex = 8;
            this.Label_FillAllFields.Text = "Please fill all the required fields";
            this.Label_FillAllFields.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditPersonalInformationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 284);
            this.Controls.Add(this.Label_FillAllFields);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Textfield_Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Textfield_Firstname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPersonalInformationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit personal information";
            this.Load += new System.EventHandler(this.EditPersonalInformationDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_Firstname;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Textfield_Surname;
        private MaterialSkin.Controls.MaterialFlatButton Button_Save;
        private System.Windows.Forms.Label Label_FillAllFields;
        private System.Windows.Forms.Timer timer1;
    }
}
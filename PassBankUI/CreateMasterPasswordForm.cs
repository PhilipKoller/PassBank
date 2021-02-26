using PassBankLibrary;
using PassBankLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassBankUI
{
    public partial class CreateMasterPasswordForm : Form
    {
        public CreateMasterPasswordForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UserModel user = new UserModel();
                user.Name = usernameTextBox.Text;
                user.MasterPassword = masterPasswordTextBox.Text;

                GlobalConfig.Connections.AddUser(user);
                MessageBox.Show("User Added!");
            }
            else
            {
                MessageBox.Show("Form not valid");
            }
        }

        private bool ValidateForm()
        {
            if (usernameTextBox.Text == "")
            {
                return false;
            }
            if (masterPasswordTextBox.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}

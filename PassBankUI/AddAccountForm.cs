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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MessageBox.Show("Account is Being Added!");
            }
            else
            {
                MessageBox.Show("Not Valid");
            }
            
        }
       private bool ValidateForm()
        {
            bool isValid = true;
            if (accountTextBox.Text.Length == 0 || usernameTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}

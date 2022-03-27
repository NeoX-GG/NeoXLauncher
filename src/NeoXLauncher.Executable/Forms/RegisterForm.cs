using NeoXLauncher.Executable.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoXLauncher.Executable.Forms
{
    public partial class RegisterForm : Form
    {
        string Psw = "";
        string ConfirmPsw = "";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TermsCheckBox.Checked = !TermsCheckBox.Checked;
        }

        private void TermsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Open terms
        }

        private void ConditionsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Open conditions
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (TermsCheckBox.CheckState.Equals(CheckState.Checked))
            {
                if (PswTxtBox.Text.Equals(PswConfirmTxtBox.Text))
                {
                    if (ApiConsumption.AccountConsumption.ExistUsername(AccountTxtBox.Text))
                    {
                        //TODO: Message The actual username is used
                        return;
                    }
                    if (ApiConsumption.AccountConsumption.ExistEmail(EmailTxtBox.Text))
                    {
                        //TODO: Message The actual email is used
                        return;
                    }
                    ApiConsumption.AccountConsumption.CreateAccount(AccountTxtBox.Name, EmailTxtBox.Text, PswTxtBox.Text.ToSHA512());
                    return;
                }
                //TODO: Message passwords dont match
                return;
            }
            //TODO: Message Agree Terms
        }

        private void PswTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}

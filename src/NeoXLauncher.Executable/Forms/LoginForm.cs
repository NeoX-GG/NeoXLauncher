using NeoXLauncher.Entities;
using NeoXLauncher.Executable.ApiConsumption;
using NeoXLauncher.Executable.Config;
using NeoXLauncher.Executable.Extension;
using NeoXLauncher.Executable.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoXLauncher.Executable.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            if (TempData.Account != null)
            {
                AccountTxtBox.Text = TempData.Account.Name;
                PswTxtBox.Text = TempData.Account.Password;
                RememberCheckBox.Checked = true;
            }
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Account acc = AccountConsumption.Login(AccountTxtBox.Text, PswTxtBox.Text.ToSHA512());
            if (acc == null)
            {
                //TODO: Message Wrong username or password.
                return;
            }
            TempData.Account = acc;
            if (RememberCheckBox.Checked)
            {
                if (File.Exists(Configuration.CredentialsFileName))
                {
                    File.Delete(Configuration.CredentialsFileName);
                }
                using (StreamWriter writer = File.CreateText(Configuration.CredentialsFileName))
                {
                    writer.WriteLine($"{acc.Name} {PswTxtBox.Text}");
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

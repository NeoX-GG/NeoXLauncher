using NeoXLauncher.Entities;
using NeoXLauncher.Executable.Config;
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
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            if (File.Exists(Configuration.CredentialsFileName))
            {
                using (StreamReader reader = File.OpenText(Configuration.CredentialsFileName))
                {
                    string[] line = reader.ReadLine().Split(' ');
                    TempData.Account = new Account()
                    {
                        Name = line[0],
                        Password = line[1]
                    };
                }
            }
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            new MainForm().Show();
            timer1.Enabled = false;
            return;
            if (circularProgressBar1.Value.Equals(100))
            {
                new RegisterForm().Show();
                timer1.Enabled = false;
                Hide();
                return;
            }
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
        }
    }
}

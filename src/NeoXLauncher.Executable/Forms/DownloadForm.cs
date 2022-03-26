using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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

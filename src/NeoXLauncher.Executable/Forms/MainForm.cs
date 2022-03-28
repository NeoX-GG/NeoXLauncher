using NeoXLauncher.Executable.Forms.Subforms;
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
    public partial class MainForm : Form
    {
        ProfileForm ProfForm = new ProfileForm();
        NewsForm NewForm = new NewsForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            LeftPanel.Visible = !LeftPanel.Visible;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProfForm.TopLevel = false;
            NewForm.TopLevel = false;
            BigPanel.Controls.Add(ProfForm);
            BigPanel.Controls.Add(NewForm);
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            //TODO: All forms closed
            ProfForm.Visible = !ProfForm.Visible;
            NewForm.Visible = false;
        }

        private void NewsBtn_Click(object sender, EventArgs e)
        {
            NewForm.Visible = !NewForm.Visible;
            ProfForm.Visible = false;
        }
    }
}

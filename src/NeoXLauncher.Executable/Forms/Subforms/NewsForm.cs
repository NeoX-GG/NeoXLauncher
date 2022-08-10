using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoXLauncher.Executable.Forms.Subforms
{
    public partial class NewsForm : Form
    {
        int NewId = 0;
        public NewsForm()
        {
            InitializeComponent();
        }

        public void UpdateNewsView()
        {
            //NewsBrowser.Url = new Uri($"https://neox.gg/News/new{NewId}.html");
        }

        private void BackNewsBtn_Click(object sender, EventArgs e)
        {
            NewId -= 1;
            if (NewId < 0)
            {
                NewId = 0;
            }
            UpdateNewsView();
        }

        private void NextNewBtn_Click(object sender, EventArgs e)
        {
            NewId++;
            if (NewId > 5)
            {
                NewId = 5;
            }
            UpdateNewsView();
        }
    }
}

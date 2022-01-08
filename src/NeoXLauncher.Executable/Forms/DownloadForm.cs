using NeoXLauncher.Executable.ApiConsumption;
using NeoXLauncher.Executable.Config;
using NeoXLauncher.Executable.Helpers;
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
            InitializeComponent();
        }

		private void Timer_Tick(object sender, EventArgs e)
		{
			this.LoadProgressBar.Value++;
			this.PercentageLabel.Text = this.LoadProgressBar.Value.ToString() + "%";
			if (LoadProgressBar.Value == 100)
			{
				this.Timer.Enabled = false;
				base.Close();
				if (File.Exists(Configuration.CredentialsFileName))
				{
					using (StreamReader streamReader = new StreamReader(Configuration.CredentialsFileName))
					{
						string[] array = streamReader.ReadToEnd().Split(' ');
						TempData.Account = AccountConsumption.Login(array[0], array[1]);
						if (!AccountHelper.BannedOrClosed() && TempData.Account.IsVerified)
						{
							//TODO: Message here
						}
						return;
					}
				}
				TempData.Account = null;

				if (TempData.Account == null)
                {
					new LoginForm().Show();
					//return;
                }
				new MainForm().Show();
			}
		}
	}
}

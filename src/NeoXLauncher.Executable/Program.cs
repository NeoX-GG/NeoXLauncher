using NeoXLauncher.Executable.Forms;
using System;
using System.Windows.Forms;

namespace NeoXLauncher.Executable
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DownloadForm());
        }
    }
}

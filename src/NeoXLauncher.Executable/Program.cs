﻿using NeoXLauncher.Executable.Forms;
using System;
using System.Threading;
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
            Application.Run(new LoginForm());
        }
    }
}

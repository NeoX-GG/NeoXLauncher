using System;
using System.Windows.Input;

namespace NeoXLauncher.Launcher.Helpers;

public class KeyDownHelper
{
    public static void KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.System && e.SystemKey == Key.F4)
        {
            e.Handled = true;
            Environment.Exit(1);
        }
    }
}

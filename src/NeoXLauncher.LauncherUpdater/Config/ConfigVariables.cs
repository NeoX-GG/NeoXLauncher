using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoXLauncher.LauncherUpdater.Config;

public static class ConfigVariables
{
    public static bool DownloadActive = false;
    public static string MainDownloadUrl = "http://localhost/download/launcher/";
    public static string LocalJsonFile = "launcher.json";
    public static string ActualJsonFile = MainDownloadUrl + LocalJsonFile;
    public static string DownloadUrl = MainDownloadUrl + "files/";
}

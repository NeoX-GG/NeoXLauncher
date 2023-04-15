using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NeoXLauncher.LauncherUpdater.Helpers;

public class ChecksumHelper
{
    public static string GetHash(string filepath)
    {
        using var md5 = MD5.Create();
        using var stream = File.OpenRead(filepath);
        var hash = md5.ComputeHash(stream);
        return BitConverter.ToString(hash).Replace("-", "");
    }
}

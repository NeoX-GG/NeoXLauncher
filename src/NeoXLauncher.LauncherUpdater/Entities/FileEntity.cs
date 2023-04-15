using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoXLauncher.LauncherUpdater.Entities;

public class FileEntity
{
    public string Path { get; set; }
    public string Hash { get; set; }
    public long BytesSize { get; set; }
}

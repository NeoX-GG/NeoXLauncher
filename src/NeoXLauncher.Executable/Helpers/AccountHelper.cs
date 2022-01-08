using NeoXLauncher.Enums;
using NeoXLauncher.Executable.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoXLauncher.Executable.Helpers
{
    public class AccountHelper
    {
        public static bool BannedOrClosed()
        {
            return TempData.Account == null || TempData.Account.AuthorityType.Equals(AuthorityType.Closed) || TempData.Account.AuthorityType.Equals(AuthorityType.Banned);
        }
    }
}

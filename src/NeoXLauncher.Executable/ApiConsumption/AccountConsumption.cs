using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoXLauncher.Entities;

namespace NeoXLauncher.Executable.ApiConsumption
{
    public class AccountConsumption
    {
		public static bool ExistUsername(string username)
		{
			return false;
		}

		public static bool ExistEmail(string email)
		{
			return false;
		}

		public static Account Login(string username, string password)
		{
			return new Account();
		}

		public static bool CreateAccount(string username, string email, string password)
		{
			return true;
		}

		public static bool VerifyAccount(string username, string password, string token)
		{
			return true;
		}
	}
}

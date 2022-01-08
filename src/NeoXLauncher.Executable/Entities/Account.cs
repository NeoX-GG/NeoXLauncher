using System;
using NeoXLauncher.Enums;

namespace NeoXLauncher.Entities
{
	// Token: 0x0200000D RID: 13
	public class Account
	{
		public int Id { get; set; }

		public AuthorityType AuthorityType { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public bool IsVerified { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NeoXLauncher.Executable.Extension
{
    public static class StringExtension
    {
        public static string ToSHA512(this string str)
        {
            using (SHA512 sha512Hash = SHA512.Create())
            {
                byte[] strBytes = Encoding.UTF8.GetBytes(str);
                byte[] hashBytes = sha512Hash.ComputeHash(strBytes);
                return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
        }
    }
}

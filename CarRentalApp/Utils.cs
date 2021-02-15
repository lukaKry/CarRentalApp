using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    public static class Utils
    {
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sb = new StringBuilder();
            foreach (var item in data)
            {
                sb.Append(item.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}

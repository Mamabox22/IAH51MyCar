using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Autosausleihen
{
    public static class Passwort
    {
        public static string EncryptMP5(string passwort)
        {


            MD5 instance = MD5.Create();
            byte[] bytes = ASCIIEncoding.ASCII.GetBytes(passwort);
            byte[] hash = instance.ComputeHash(bytes);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length;i++)
            {
                builder.Append(hash[i].ToString("X2"));
            }
            return builder.ToString();
        }
    }
}

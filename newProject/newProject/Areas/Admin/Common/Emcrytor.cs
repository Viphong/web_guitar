using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace newProject.Areas.Admin.Common
{
    public class Emcrytor
    {
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash form the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length;i++ )
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

                return strBuilder.ToString();
        }
    }
}
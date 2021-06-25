using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace RestaurantOtomasyonV1
{
    class Cryptography
    {
        public string md5Encrypt(string raw)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(raw));
            byte[] result = md5.Hash;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                stringBuilder.Append(result[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}

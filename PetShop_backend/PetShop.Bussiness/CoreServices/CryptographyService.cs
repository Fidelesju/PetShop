using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PetShop_backend.PetShop.Bussiness.CoreServices.Interfaces;

namespace PetShop_backend.PetShop.Bussiness.CoreServices
{
    public class CryptographyService : ICryptographyService
    {
          public string GetMd5Crypto(string input)
        {
            MD5 md5;
            byte[] inputBytes;
            byte[] hashBytes;
            StringBuilder stringBuilder;
            int i;
            int length;
            string text;

            using (md5 = MD5.Create())
            {
                inputBytes = Encoding.ASCII.GetBytes(input);
                hashBytes = md5.ComputeHash(inputBytes);
                stringBuilder = new StringBuilder();

                for (i = 0, length = hashBytes.Length; i < length; i++)
                {
                    text = hashBytes[i].ToString("X2");
                    stringBuilder.Append(text);
                }

                return stringBuilder.ToString();
            }
        }
    }
}
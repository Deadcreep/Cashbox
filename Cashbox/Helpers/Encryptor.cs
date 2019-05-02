using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox.Helpers
{
    public static class Encryptor
    {
        public static string GetMd5Hash(string data)
        {
            using (MD5 mD5 = MD5.Create())
            {
                byte[] bytesData = mD5.ComputeHash(Encoding.UTF8.GetBytes(data));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < bytesData.Length; i++)
                {
                    sBuilder.Append(bytesData[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }
    }
}
    
    


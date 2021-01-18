using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Authentication_Project
{
    class DataEncrypt
    {
        public static int count = 0;
        public static String Create_Salt(String s1, String s2) // s1 >= 5, s2 >= 6
        {
            String s = s2;
            for (int i = 0; i < 5; i++)
            {
                s += s1[i] + "" + s2[i];
            }
            return s;
        }
       public static String Create_MD5(String password)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            return encoded;
        }
    }

}

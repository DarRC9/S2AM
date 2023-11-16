using System;
using System.Security.Cryptography;
using System.Text;

namespace HashUtils
{
    public class HashUser
    {
        private string _hashedSalt, _hashedPassword;
        public string createSalt()
        {
            string strHash = "";
            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString("yyyyMMdd");

            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(date));
                strHash = BitConverter.ToString(hashedBytes);
                _hashedSalt = strHash;
            }

            return strHash;
        }

        public string createPassword()
        {
            string strHash = "";

            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes("12345aA" + _hashedSalt));
                strHash = BitConverter.ToString(hashedBytes);
                _hashedPassword = strHash;
            }

            return strHash;
        }

        public string validatePassword(string password)
        {
            string strHash = "";
            string hashedUserSalt = "";
            string hashedUserPassword = "";
            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString("yyyyMMdd");

            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(date));
                strHash = BitConverter.ToString(hashedBytes);
                hashedUserSalt = strHash;
            }

            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password + hashedUserSalt));
                strHash = BitConverter.ToString(hashedBytes);
                hashedUserPassword = strHash;
            }


            return hashedUserPassword;
        }

    }
}

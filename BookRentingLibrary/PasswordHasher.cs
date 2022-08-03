using System;
using System.Security.Cryptography;

namespace BookRentingLibrary
{
    public static class PasswordHasher
    {
        public static string Hash(string password, byte[] salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            return Convert.ToBase64String(pbkdf2.GetBytes(24));
        }
        public static byte[] GenerateSalt()
        {
            var saltBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return saltBytes;
        }
    }
}

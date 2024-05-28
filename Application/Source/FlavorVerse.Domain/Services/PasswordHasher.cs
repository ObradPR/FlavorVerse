using FlavorVerse.Common;
using System.Security.Cryptography;
using System.Text;

namespace FlavorVerse.Domain.Services
{
    public class PasswordHasher
    {
        public static byte[] GenerateSalt()
        {
            var salt = new byte[Constants.DEFAULT_SALT_LENGTH];            
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        public static byte[] HashPassword(string password, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var combinedBytes = Combine(Encoding.UTF8.GetBytes(password), salt);
                return sha256.ComputeHash(combinedBytes);
            }
        }

        public static byte[] Combine(byte[] first, byte[] second)
        {
            var result = new byte[first.Length + second.Length];

            Buffer.BlockCopy(first, 0, result, 0, first.Length);
            Buffer.BlockCopy(second, 0, result, first.Length, second.Length);

            return result;
        }

        public static bool VerifyPassword(string enteredPassword, byte[] storedHash, byte[] salt)
        {
            var enteredHash = HashPassword(enteredPassword, salt);

            return ConstantTimeEquals(enteredHash, storedHash);
        }

        public static bool ConstantTimeEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            int result = 0;

            for (int i = 0; i < a.Length; i++)
                result |= a[i] ^ b[i];

            return result == 0;
        }
    }
}

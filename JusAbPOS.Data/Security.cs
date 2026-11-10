using System;
using System.Security.Cryptography;
using System.Text;

namespace JusAbPOS.Data
{
    /// <summary>
    /// Matches the abejar seed data:  PasswordHash = SHA-256( Salt + Password ), uppercase hex (64 chars).
    /// </summary>
    public static class PasswordHasher
    {
        public static string Hash(string salt, string password)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes((salt ?? "") + (password ?? "")));
                var sb = new StringBuilder(64);
                foreach (var b in bytes) sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }

        /// <summary>Random 32-character hex salt for creating new users later.</summary>
        public static string NewSalt()
        {
            var bytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create()) rng.GetBytes(bytes);
            var sb = new StringBuilder(32);
            foreach (var b in bytes) sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        /// <summary>Constant-time comparison so response time does not leak how much of the hash matched.</summary>
        public static bool Verify(string password, string salt, string expectedHash)
        {
            var actual = Hash(salt, password);
            var expected = (expectedHash ?? "").ToUpperInvariant();
            if (actual.Length != expected.Length) return false;
            var diff = 0;
            for (var i = 0; i < actual.Length; i++) diff |= actual[i] ^ expected[i];
            return diff == 0;
        }
    }
}

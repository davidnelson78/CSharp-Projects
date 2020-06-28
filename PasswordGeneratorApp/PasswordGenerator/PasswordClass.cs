using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PasswordGenerator
{
    /// <summary>
    /// Class to generate random passwords.
    /// </summary>
    public static class PasswordClass
    {
        public static bool useLower;
        public static bool useUpper;
        public static bool useNumeric;
        public static bool useSpecial;

        /// <summary>
        /// Static function to generate the password.
        /// </summary>
        /// <param name="length">Length of characters want in password.</param>
        /// <returns></returns>
        public static string Generate(int length = 16)
        {
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeric = "0123456789";
            const string special = "!'@#^$+½%&{/[(])}=\\?|_-*:";
            var sb = new StringBuilder();
            if (useLower)
                sb.Append(lowerChars);
            if (useUpper)
                sb.Append(upperChars);
            if (useNumeric)
                sb.Append(numeric);
            if (useSpecial)
                sb.Append(special);
            if (!useLower && !useUpper && !useNumeric && !useSpecial)
            {
                sb.Append(lowerChars);
                sb.Append(upperChars);
                sb.Append(numeric);
                sb.Append(special);
            }
            return GetRandomString(length, sb.ToString());
        }

        private static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length <= 0)
                throw new ArgumentException("Length must be more than 0", nameof(length));
            if (length > int.MaxValue / 8)
                throw new ArgumentException("Length must be less than 255", nameof(length));
            if (characterSet == null)
                throw new ArgumentNullException(nameof(characterSet));
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("Set of characters must not be empty", nameof(characterSet));

            var bytes = new byte[length * 8];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetNonZeroBytes(bytes);

            var sb = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                var index = BitConverter.ToUInt64(bytes, i * 8) % (ulong)characterArray.Length;
                sb.Append(characterArray[index]);
            }

            return sb.ToString();
        }
    }
}
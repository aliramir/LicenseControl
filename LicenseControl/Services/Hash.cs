using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LicenseControl.Services
{
    public static class Hash
    {
        public static string Md5(this string input)
        {
            using var md5 = System.Security.Cryptography.MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = md5.ComputeHash(inputBytes);
            return Convert.ToHexString(hashBytes);
        }
        public static string Md5H(this string input)
        {
            using var md5 = System.Security.Cryptography.MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hashBytes = md5.ComputeHash(inputBytes);
            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }
        public static string Sha1(this string input)
        {
            var enc = Encoding.UTF8;
            var rawMessage = enc.GetBytes(input);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            var result = sha1.ComputeHash(rawMessage);
            var mac = Convert.ToBase64String(result);
            //split the string in 2 and return the first half
            //mac = mac[..(mac.Length / 2)];
            return mac;
        }
        public static string Sha2(this string input)
        {
            using var sha1 = new SHA1Managed();
            var hashSh1 = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));

            // declare stringbuilder
            var sb = new StringBuilder(hashSh1.Length * 2);

            // computing hashSh1
            foreach (var b in hashSh1)
            {
                // "x2"
                sb.Append(b.ToString("X2").ToLower());
            }

            // final output
            //Console.WriteLine($"The SHA1 hash of {input} is: {sb.ToString()}");

            return sb.ToString();
        }
    }
}

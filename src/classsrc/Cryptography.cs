using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordProtector
{
    public static class Cryptography {
        #region Settings

        private static int _iterations = 2;
        private static int _keySize = 256;

        private static string _hash     = "SHA1";
        private static string _salt     = "dgs=-0ete4trbbf34"; // Random
        private static string _vector   = "nv'n=cn-fsff2312"; // Random

        #endregion
        public static string Encrypt(string value, string key) {
            return Encrypt<AesManaged>(value, key);
        }
        public static string Encrypt<T>(string value, string key) 
                where T : SymmetricAlgorithm, new() {

            byte[] vectorBytes = ASCIIEncoding.Default.GetBytes(_vector);
            byte[] saltBytes = ASCIIEncoding.Default.GetBytes(_salt);
            byte[] valueBytes = UTF8Encoding.Default.GetBytes(value);

            byte[] encrypted;
            using (T cipher = new T()) {
                PasswordDeriveBytes _passwordBytes =
                    new PasswordDeriveBytes(key, saltBytes, _hash, _iterations);
                byte[] keyBytes = _passwordBytes.GetBytes(_keySize / 8);

                cipher.Mode = CipherMode.CBC;

                using (ICryptoTransform encryptor = cipher.CreateEncryptor(keyBytes, vectorBytes)) {
                    using (MemoryStream to = new MemoryStream()) {
                        using (CryptoStream writer = new CryptoStream(to, encryptor, CryptoStreamMode.Write)) {
                            writer.Write(valueBytes, 0, valueBytes.Length);
                            writer.FlushFinalBlock();
                            encrypted = to.ToArray();
                        }
                    }
                }
                cipher.Clear();
            }
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string value, string key) {
            return Decrypt<AesManaged>(value, key);
        }
        public static string Decrypt<T>(string value, string key) where T : SymmetricAlgorithm, new() {
            byte[] vectorBytes = ASCIIEncoding.Default.GetBytes(_vector);
            byte[] saltBytes = ASCIIEncoding.Default.GetBytes(_salt);
            byte[] valueBytes = Convert.FromBase64String(value);

            byte[] decrypted;
            int decryptedByteCount = 0;

            using (T cipher = new T()) {
                PasswordDeriveBytes _passwordBytes = new PasswordDeriveBytes(key, saltBytes, _hash, _iterations);
                byte[] keyBytes = _passwordBytes.GetBytes(_keySize / 8);

                cipher.Mode = CipherMode.CBC;

                try {
                    using (ICryptoTransform decryptor = cipher.CreateDecryptor(keyBytes, vectorBytes)) {
                        using (MemoryStream from = new MemoryStream(valueBytes)) {
                            using (CryptoStream reader = new CryptoStream(from, decryptor, CryptoStreamMode.Read)) {
                                decrypted = new byte[valueBytes.Length];
                                decryptedByteCount = reader.Read(decrypted, 0, decrypted.Length);
                            }
                        }
                    }
                } catch (Exception ex) {
                    Error e = new Error(ex.ToString(), 3,null,DateTime.Now);
                    e.InsertError();
                    return String.Empty;
                }

                cipher.Clear();
            }
            return Encoding.UTF8.GetString(decrypted, 0, decryptedByteCount);
        }

    }
}


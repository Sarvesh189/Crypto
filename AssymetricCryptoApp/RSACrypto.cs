using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssymetricCryptoApp
{
    public class RSACrypto
    {
        private string _RsaKey;
        public RSACrypto(string key)
        {
            _RsaKey = key;
        
        }

        public string EncryptText(string plainText)
        {
            RSACryptoServiceProvider cipher = CreateCipherProviderForEncryption();
            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherText = cipher.Encrypt(data, false);
            return Convert.ToBase64String(cipherText);
        }

        public string DecryptText(string cipherText)
        {
            RSACryptoServiceProvider cipher = CreateCipherProviderForDecryption();
            byte[] original = cipher.Decrypt(Convert.FromBase64String(cipherText), false);
            return Encoding.UTF8.GetString(original);
        }

        private RSACryptoServiceProvider CreateCipherProviderForEncryption()
        {
            RSACryptoServiceProvider rsaCipher = new RSACryptoServiceProvider();
            rsaCipher.FromXmlString(_RsaKey);
            return rsaCipher;
        }
        private RSACryptoServiceProvider CreateCipherProviderForDecryption()
        {
            RSACryptoServiceProvider cipher = new RSACryptoServiceProvider();
            cipher.FromXmlString(_RsaKey);
            return cipher;
        }
    }
}

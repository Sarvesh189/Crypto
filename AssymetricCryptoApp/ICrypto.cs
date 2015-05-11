using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssymetricCryptoApp
{
   public interface ICrypto
    {
        string EncryptText(string plainText);
        string DecryptText(string cipherText);
    }

   public class Crypto : ICrypto
   {
       private string _key = string.Empty;
       public Crypto(string key)
       {
           _key = key;
       }
       public string EncryptText(string plainText)
       {
           var key = TripleDESCrypto.CreateNewKey();
           var vector = TripleDESCrypto.CreateNewVector();
           var tripleDesCrypto = new TripleDESCrypto(key,vector);
          var encryptedText = tripleDesCrypto.EncryptText(plainText);
          var rsaCrypto = new RSACrypto(_key);
          var encryptedKey = rsaCrypto.EncryptText(key);
          var encryptedVector = rsaCrypto.EncryptText(vector);
          return encryptedText + "$" + encryptedKey + "$" + encryptedVector;
          tripleDesCrypto = null;
            
       }

       public string DecryptText(string cipherText)
       {
           string[] cipherTexts = cipherText.Split('$');
           var rsaCrypto = new RSACrypto(_key);
           var key = rsaCrypto.DecryptText(cipherTexts[1]);
           var vector = rsaCrypto.DecryptText(cipherTexts[2]);
           var tripleDesCrypto = new TripleDESCrypto(key, vector);
           return tripleDesCrypto.DecryptText(cipherTexts[0]);
       }
   }

}

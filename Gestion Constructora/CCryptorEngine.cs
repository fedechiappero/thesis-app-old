using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Gestion_Constructora
{
   class CCryptorEngine
    {
        private string key;

        public CCryptorEngine()
        {
            key = "ABCDEFGHIJKLMÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz";
        }

        public static string Encriptar(string texto)
        {

            byte[] keyArray;

            byte[] Arreglo_a_Cifrar =
            UTF8Encoding.UTF8.GetBytes(texto);
   

            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();

            CCryptorEngine key = new CCryptorEngine();

            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key.key));

            hashmd5.Clear();
    

            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform =
            tdes.CreateEncryptor();
    
            byte[] ArrayResultado =
            cTransform.TransformFinalBlock(Arreglo_a_Cifrar,
            0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            return Convert.ToBase64String(ArrayResultado,
                    0, ArrayResultado.Length);
        }

        public static string Desencriptar(string textoEncriptado)
        {
            byte[] keyArray;
            byte[] Array_a_Descifrar =
            Convert.FromBase64String(textoEncriptado);


            MD5CryptoServiceProvider hashmd5 =
            new MD5CryptoServiceProvider();

            CCryptorEngine key = new CCryptorEngine();

            keyArray = hashmd5.ComputeHash(
            UTF8Encoding.UTF8.GetBytes(key.key));

            hashmd5.Clear();
    
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform =
            tdes.CreateDecryptor();

            byte[] resultArray =
            cTransform.TransformFinalBlock(Array_a_Descifrar,
            0, Array_a_Descifrar.Length);

            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}

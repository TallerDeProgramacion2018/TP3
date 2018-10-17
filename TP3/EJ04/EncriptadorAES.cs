using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EJ04
{
    public class EncriptadorAES: Encriptador
    {
        private Aes aes;
        
        public EncriptadorAES(string pNombre) : base(pNombre)
        {
            aes = Aes.Create();
        }

        byte[] EncryptStringToBytes_Aes(string plainText)
        {
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = aes.Key;
                aesAlg.IV = aes.IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }

        string DecryptStringFromBytes_Aes(byte[] cipherText)
        {
            

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = aes.Key;
                aesAlg.IV = aes.IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }

        // Este método crea un arreglo de bytes, que es el resultado de la encriptación
        // del metodo AES, luego se crea un arreglo de strings, y a cada byte se le asigna
        // un valor caracter de la tabla ASCII extendida.
        public override string Encriptar(string pCadena)
        {
            byte[] arregloBytes = EncryptStringToBytes_Aes(pCadena);
            char[] arregloCaracteres = new char[arregloBytes.Length];

            for (byte i = 0; i < arregloBytes.Length; i++)
            {
                arregloCaracteres[i] = Convert.ToChar(arregloBytes[i]); 
            }

            return new string(arregloCaracteres);
        }

        // Este método realiza lo contrario, primero definiendo un arreglo de bytes
        // definido en base a la cadena de entrada, y luego se le desencripta mediante
        // el método desencriptar de la clase AES del sistema.
        public override string Desencriptar(string pCadena)
        {
            byte[] arregloBytes = new byte[pCadena.Length];
            for (byte i = 0; i < arregloBytes.Length; i++)
            {
                arregloBytes[i] = Convert.ToByte(pCadena[i]);
            }

            string resultado = DecryptStringFromBytes_Aes(arregloBytes);
            return resultado;
        }
    }
}

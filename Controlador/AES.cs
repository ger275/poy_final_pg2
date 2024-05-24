using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SistemaParaPrediccionDeVentas.Controlador
{
    internal class AES
    {
        public AES()
        {

        }

        public string EncriptarDato(string datoDesencriptado)
        {
            string datoEncriptado = "";

            using (Aes encript = Aes.Create())
            {
                byte[] llave = new byte[16] { 0x0, 0x0, 0x4C, 0x5A, 0x12, 0x17, 0x6, 0x0, 0x15, 0x1F, 0xE, 0x5, 0x14, 0x18, 0x0, 0x0 };
                byte[] i_v = new byte[16];

                datoEncriptado = Encriptar(datoDesencriptado, llave, i_v);
            }

            return datoEncriptado;
        }

        public string DesEncriptarDato(string datoEncriptado)
        {
            string datoDesEncriptado = "";

            using (Aes encript = Aes.Create())
            {
                byte[] llave = new byte[16] { 0x0, 0x0, 0x4C, 0x5A, 0x12, 0x17, 0x6, 0x0, 0x15, 0x1F, 0xE, 0x5, 0x14, 0x18, 0x0, 0x0 };
                byte[] i_v = new byte[16];

                datoDesEncriptado = DesEncriptar(datoEncriptado, llave, i_v);
            }

            return datoDesEncriptado;
        }

        public string Encriptar(string dato, byte[] llave, byte[] iv)
        {
            string encriptado = "";
            //validar los datos de entrada
            if (dato == null || dato.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }
                
            if (llave == null || llave.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }
                
            if (iv == null || iv.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            byte[] encryptedByte;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = llave;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                //crear la función para escribir en memoria el dato encriptado
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Escribir el dato encriptado
                            swEncrypt.Write(dato);
                        }
                        encryptedByte = msEncrypt.ToArray();
                    }
                }
            }

            encriptado = Convert.ToBase64String(encryptedByte);

            //Retornar el dato encriptado
            return encriptado;
        }

        public string DesEncriptar(string datoEncriptado, byte[] llave, byte[] iv)
        {
            byte[] dato;
            dato = Convert.FromBase64String(datoEncriptado);
            //validar los datos de entrada
            if (dato == null || dato.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }
                
            if (llave == null || llave.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }
                
            if (iv == null || iv.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = llave;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                //crer el stream usado para la desencriptacion
                using (MemoryStream msDecrypt = new MemoryStream(dato))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            //leer de la memoria el dato desencriptado y pasarlo a una variable
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            //Retornar el dato desencriptado
            return plaintext;
        }
    }
}

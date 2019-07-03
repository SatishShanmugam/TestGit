using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class EncryptionDecryption
    {
        /// <summary>
        /// Method that encrypt the password
        /// </summary>
        /// <param name="password"></param>
        /// <returns> return encrypted password string</returns>
        public string Encryptdata(string password)
        {
            string encryptpassword = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            encryptpassword = Convert.ToBase64String(encode);
            return encryptpassword;
        }
        /// <summary>
        /// Method that decrypt the password
        /// </summary>
        /// <param name="encryptpassword"></param>
        /// <returns>returns the decrypted password string</returns>
        public string Decryptdata(string encryptpassword)
        {
            string decryptpassword = string.Empty;
            UTF8Encoding encodepassword = new UTF8Encoding();
            Decoder Decode = encodepassword.GetDecoder();
            byte[] toDecode_byte = Convert.FromBase64String(encryptpassword);
            int charCount = Decode.GetCharCount(toDecode_byte, 0, toDecode_byte.Length);
            char[] decoded_characters = new char[charCount];
            Decode.GetChars(toDecode_byte, 0, toDecode_byte.Length, decoded_characters, 0);
            decryptpassword = new String(decoded_characters);
            return decryptpassword;
        }
    }
}

using System.Text;

namespace EncryptionWebApp.Models
{
    /// <summary>
    /// Encrypts input by exchanging a letter with the letter three steps ahead of it in the alphabet, starting over from the beginning for the last letters of the alphabet.
    /// This version uses the Swedish alphabet.
    /// </summary>
    public static class CaesarCipherMethod
    {
        /// <summary>
        /// Encrypts the provided input using the Caesar Cipher method and returns the result.
        /// </summary>
        /// <param name="encryptInput">The <see cref="System.String"/> instance that represents the input to be encrypted.</param>
        /// <returns>A <see cref="System.String"/> instance of the Caesar Cipher encrypted input.</returns>
        public static string Encrypt(string encryptInput)
        {
            string lowercaseCaesar = encryptInput.ToLower();
            StringBuilder encryptSB = new StringBuilder();
            encryptSB.Append(lowercaseCaesar);
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'å', 'ä', 'ö' };

            for (int i = 0; i < encryptSB.Length; i++)
            {
                if (char.IsLetter(encryptSB[i]))
                {
                    int indexOfCurrentChar = Array.IndexOf(alphabet, encryptSB[i]);
                    int indexOfReplacementChar = (indexOfCurrentChar + 3) % 29;
                    char actualReplacementChar = alphabet[indexOfReplacementChar];
                    encryptSB[i] = actualReplacementChar;
                }
            }

            return encryptSB.ToString();
        }

        /// <summary>
        /// Decrypts the provided input using the Caesar Cipher method and returns the result.
        /// </summary>
        /// <param name="decryptInput">The <see cref="System.String"/> instance that represents the input to be decrypted.</param>
        /// <returns>A <see cref="System.String"/> instance of the Caesar Cipher decrypted input.</returns>
        public static string Decrypt(string decryptInput)
        {
            string lowercaseCaesar = decryptInput.ToLower();
            StringBuilder decryptSB = new StringBuilder();
            decryptSB.Append(lowercaseCaesar);
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'å', 'ä', 'ö' };

            for (int i = 0; i < decryptSB.Length; i++)
            {
                if (char.IsLetter(decryptSB[i]))
                {
                    int indexOfCurrentChar = Array.IndexOf(alphabet, decryptSB[i]) + 29;
                    int indexOfReplacementChar = (indexOfCurrentChar - 3) % 29;
                    char actualReplacementChar = alphabet[indexOfReplacementChar];
                    decryptSB[i] = actualReplacementChar;
                }
            }

            return decryptSB.ToString();
        }
    }
}

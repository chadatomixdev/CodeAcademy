using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your secret message:");

            string userInput = Console.ReadLine().ToLower();
            char[] secretMessage = userInput.ToCharArray();

            char[] encrypted = Encrypt(secretMessage, 3);
            string encryptedString = string.Join("", encrypted);

            char[] decrypted =  Decrypt(encrypted, 3);
            string decrypteddString = string.Join("", decrypted);

            Console.WriteLine(encryptedString);
            Console.WriteLine(decrypteddString);
        }

        static char[] Encrypt(char[] secretMessage, int index)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] encryptedMessage = new char[24];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char initChar = secretMessage[i];

                if (char.IsLetterOrDigit(initChar))
                {
                    int charIndex = Array.IndexOf(alphabet, initChar);
                    int newCharIndex = (charIndex + 3) % alphabet.Length;

                    char newChar = alphabet[newCharIndex];

                    encryptedMessage[i] = newChar;
                }
            }

            return encryptedMessage;
        }

        static char[] Decrypt(char[] secretMessage, int index)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] decryptedMessage = new char[24];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char initChar = secretMessage[i];

                if (char.IsLetterOrDigit(initChar))
                {

                    int charIndex = Array.IndexOf(alphabet, initChar);
                    int newCharIndex = (charIndex - 3) % alphabet.Length;

                    char newChar = alphabet[newCharIndex];

                    decryptedMessage[i] = newChar;
                }
            }

            return decryptedMessage;
        }
    }
}
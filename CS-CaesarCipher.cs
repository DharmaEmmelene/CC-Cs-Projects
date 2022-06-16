using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("Enter message to be encrypted: ");
            //capture response from user
            string message = Console.ReadLine();
            //convert to array
            char[] secretMessage = message.ToCharArray();
            //encrypted message array
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char character = secretMessage[i];
                int pos = Array.IndexOf(alphabet, character);
                int newPos = (pos += 3) % alphabet.Length;
                char encodedChar = alphabet[newPos];
                encryptedMessage[i] = encodedChar;
            }
            string encodedString = String.Join("", encryptedMessage);
            Console.WriteLine(encodedString);
        }
    }
}
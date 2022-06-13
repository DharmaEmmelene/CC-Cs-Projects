using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Create a secure password: ");
            //Define variables
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            //capture user input & store in variable
            string userPassword = Console.ReadLine();
            //evaulate standards met and store in variable
            int score = 0;

            if (userPassword.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(userPassword, uppercase))
            {
                score++;
            }
            if (Tools.Contains(userPassword, lowercase))
            {
                score++;
            }
            if (Tools.Contains(userPassword, digits))
            {
                score++;
            }
            if (Tools.Contains(userPassword, specialChars))
            {
                score++;
            }
            Console.WriteLine(score);

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Extremely strong password");
                    break;
                case 3:
                    Console.WriteLine("Stong password");
                    break;
                case 2:
                    Console.WriteLine("Medium strength password");
                    break;
                case 1:
                    Console.WriteLine("Weak password");
                    break;
                default:
                    Console.WriteLine("Password doesn't meet strength standards");
                    break;
            }
        }
    }
}
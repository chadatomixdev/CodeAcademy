using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            var lowercase = new Regex(@"[a-z]");
            var uppercase = new Regex(@"[A-Z]");
            var digits = new Regex(@"[0-9]");
            var specialChars = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            int score = 0;

            //Request that the user enteres a password
            Console.WriteLine("Enter your password to measure password strength");
            string password = Console.ReadLine();

            if (password.Length >= minLength)
                score++;

            if (lowercase.IsMatch(password))
                score++;

            if (uppercase.IsMatch(password))
                score++;

            if (digits.IsMatch(password))
                score++;

            if (specialChars.IsMatch(password))
                score++;

            switch (score)
            {
                case 1:
                    Console.WriteLine("The password is weak");
                    break;
                case 2:
                    Console.WriteLine("The password is medium");
                    break;
                case 3:
                    Console.WriteLine("The password is strong");
                    break;
                case 4:
                    Console.WriteLine("The password is extremely strong");
                    break;
                case 5:
                    Console.WriteLine("The password is extremely strong");
                    break;
                default:
                    Console.WriteLine("The password doesn’t meet any of the standards");
                    break;
            }
        }
    }
}
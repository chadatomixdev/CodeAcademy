using System;

namespace TrueorFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            string[] questions = { "The earth is the fourth planet from the sun?", "The planet Venus has no moons?", "Jupiter is composed mostly of iron?", "The sun is a star of average size?", "A lunar eclipse occurs when the sun passes?" };
            bool[] answers = { false, true, false, true, false };
            bool[] responses = new bool[5];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning questions and answers do not match up.");
            }

            int askingIndex = 0;

            foreach (var question in questions)
            {
                string input = "";
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);

                input = Console.ReadLine();
                isBool = bool.TryParse(input, out inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");

                    input = Console.ReadLine();
                    isBool = bool.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }


            int scoringIndex = 0;
            int score = 0;


            foreach (var answer in answers)
            {
                bool response = responses[scoringIndex];

                Console.WriteLine($"Input: { response } | Answer: { answer }");

                if (answer == response)
                {
                    score++;
                }

                scoringIndex++;
            }

            Console.WriteLine($"You got { score } out of 5 correct!");
        }
    }
}
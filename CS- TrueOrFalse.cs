using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = { "Before becoming queen, Queen Elizabeth was a mechanic", "Mario of Super Mario Bros. fame was once a carpenter", "Lightning never strikes the same place twice", "The moon is just 50% of the mass of Earth", "You can sneeze whilst asleep" };

            bool[] answers = { true, true, false, false, false };

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Error: array lengths are not equal");
            }
            //keep track of questions
            int askingIndex = 0;

            foreach (string question in questions)
            {
                //define variables
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                //prompt for boolean response
                Console.WriteLine("True or false?");

                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            //define variables
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + " ");
                Console.WriteLine($"Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}

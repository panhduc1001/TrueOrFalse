using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?");
      
            // Type your code below
            string[] questions1 = new string[] { "1 plus 1 equals 2", "2 plus 1 equals 4" };
            bool[] answers1 = new bool[] { true, false };

            string[] questions2 = new string[] { "Dogs have 2 legs" };
            bool[] answers2 = new bool[] { false };

            RunQuiz(questions1, answers1);
            RunQuiz(questions2, answers2);

            // Press Enter to close the program
            Console.ReadLine();
        }

        static void RunQuiz(string[] questions, bool[] answers)
        {
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning, questions and answers are not equal!");
                return;
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                bool isBool = false;
                bool inputBool;

                while (!isBool)
                {
                    Console.WriteLine("\n" + question);
                    Console.WriteLine("True or false?");
                    Console.WriteLine("Your answer: ");
                    string input = Console.ReadLine().ToLower();

                    isBool = bool.TryParse(input, out inputBool);

                    if (!isBool)
                    {
                        Console.WriteLine("Please respond with 'true' or 'false'.");
                    }
                    else
                    {
                        responses[askingIndex] = inputBool;
                        askingIndex++;
                    }
                }
            }

            Console.WriteLine("----------------------------");
            foreach (bool response in responses)
            { 
                Console.WriteLine("Response: " + response);
            };

            // Scoring
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score++;
                }

                scoringIndex++;
            }

            Console.WriteLine($"\nYou got {score} out of {questions.Length} correct!");
        }
    }
}


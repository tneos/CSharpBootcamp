using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject
{
    internal class Quiz
    {
        // Array of Question type
        private Question[] _questions;
        private int _score;

        // Constructor
        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1;

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");

                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
        }

        // Display question method
        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            // Display answer
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor(); // resets the foreground(text) color
                Console.WriteLine($". {question.Answers[i]}");
            }

            // Compare user's choice with correct index
            // if (GetUserChoice() == question.CorrectAnswerIndex)
            // {
            //     Console.WriteLine("Correct!");
            // }
            // else
            // {
            //     Console.WriteLine("Incorrect");
            // }
        }

        // Method that takes user's input and returns choice as number
        private int GetUserChoice()
        {
            Console.Write("Your answer(number): ");
            string input = Console.ReadLine() ?? "";
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
                input = Console.ReadLine() ?? "";
            }

            return choice - 1; // adjust to 0-indexed array

        }
    }
}
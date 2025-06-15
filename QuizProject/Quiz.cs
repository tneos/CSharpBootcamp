using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject
{
    internal class Quiz
    {
        // Array of Question type
        private Question[] questions;

        // Constructor
        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        // Display question method
        public void DisplayQuestion(Question question)
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
        }
    }
}
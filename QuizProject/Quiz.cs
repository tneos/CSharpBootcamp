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
            Console.WriteLine(question.QuestionText);
        }
    }
}
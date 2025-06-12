using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizProject
{
    internal class Question
    {
        public string QuestionText { get; set; }

        public string[] Answers { get; set; }

        public int CorrectAnswerIndex { get; set; }


        // Constructor
        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        // Method that checks if answer is correct
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
         
    }
}
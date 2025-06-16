namespace QuizProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of new instances of Question class
            Question[] questions = new Question[]{
               new Question("What is the capital of Norway?",
               new string[]{"Paris", "Helsinki", "Oslo", "Stocholm"},
               2
               ),
               new Question("Who is the author of the book with the title 'Never'?",
               new string[]{"Paula Hawkins", "Ken Follett", "Stephen King", "Martina Cole"},
               1
               ),
               new Question("What year the American Revolution started?",
               new string[]{"1776", "1789", "1775", "1796"},
               2
               ),
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}

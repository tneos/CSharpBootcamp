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
               )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.DisplayQuestion(questions[0]);

            Console.ReadLine();
        }
    }
}

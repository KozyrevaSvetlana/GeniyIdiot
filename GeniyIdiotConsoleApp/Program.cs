using System;
using System.Collections.Generic;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя");
            string userInput = Console.ReadLine();
            var user = new User(userInput);
            var questions = QuestionsStoreage.Get();
            var countQuestions = questions.Count;
            var random = new Random();
            for (int i = 0; i < countQuestions; i++)
            {
                int randomQuestionIndex = random.Next(0, questions.Count);
                Console.WriteLine($"Вопрос №{i + 1}.");
                Console.WriteLine(questions[randomQuestionIndex].Text);
                int userAnswer = GetUserAnswer();
                int rightAnswer = questions[randomQuestionIndex].Answer;
                if (userAnswer == rightAnswer)
                {
                    user.AcceptRightAnswer();
                }
                questions.RemoveAt(randomQuestionIndex);
            }
            DiagnoseCalculator.Calculate(user, countQuestions);
            Console.WriteLine($"Количество правильных ответов: {user.CounRightAnswers}");
            Console.WriteLine($"Ваш диагноз: {user.Diagnose}");
            UserResultsStoreage.Append(user);
            Console.WriteLine("Хотите посмотреть предыдущие результаты?Введите да или нет");
            var input = Console.ReadLine().ToLower().Trim();
            Console.WriteLine();
            if (input=="да"|| input == "lf")
            {
                var users = UserResultsStoreage.GetAll();
                ViewStatistics(users);
            }
        }
        private static void ViewStatistics(List<User> users)
        {
            Console.WriteLine("{0,-30}{1,-40}{2,-30}", "Имя","Кол-во правильных ответов","Диагноз" );
            foreach (var user in users)
            {
                Console.WriteLine("{0,-30}{1,-40}{2,-30}", user.Name, user.CounRightAnswers, user.Diagnose);
            }
        }
        private static int GetUserAnswer()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите число");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Введите число до 10^9 ");
                }
            }
        }

    }
}

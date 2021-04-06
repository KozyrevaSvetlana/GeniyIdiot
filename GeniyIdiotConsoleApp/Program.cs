using GeniyIdiotCommoClassLibrary;
using System;
using System.Collections.Generic;

namespace GeniyIdiotCommonClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя");
            string userInput = Console.ReadLine();
            while (!User.IsValid(userInput))
            {
                Console.WriteLine("Введите Ваше имя. Можно использовать только буквы и цифры");
                userInput = Console.ReadLine();
            }
            var user = new User(userInput);
            var game = new Game(user);
            while (!game.End())
            {
                var rightQuestion = game.PopRandomQuestion();
                Console.WriteLine(game.GetNumberQuestion());
                Console.WriteLine(rightQuestion.Text);
                int userAnswer = GetUserAnswer();
                game.AcceptAwswer(userAnswer);
            }
            Console.WriteLine(game.CalculateDiagnose());
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

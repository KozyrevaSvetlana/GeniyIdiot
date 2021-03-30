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
            var questions = GetQuestions();
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
            CalculateDiagnose(user, countQuestions);
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
        private static List<Question> GetQuestions()
        {
            var questions = new List<Question>();
            questions.Add(new Question("Сколько будет два плюс два умноженное на два?",6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?",9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?",25));
            questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?",60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?",2));
            return questions;
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
        private static string[] GetDiagnoses()
        {
            var diagnoses = new string[6];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";
            return diagnoses;
        }
        private static void CalculateDiagnose(User user, int countQuestions)
        {
            double percentRightAnswers = (double)user.CounRightAnswers * 100 / countQuestions;
            string[] diagnoses = GetDiagnoses();
            if (percentRightAnswers == 0)
            {
                user.Diagnose = diagnoses[0];
                return;
            }
            if (percentRightAnswers <= 20)
            {
                user.Diagnose = diagnoses[1];
                return;
            }
            if (percentRightAnswers <= 40)
            {
                user.Diagnose = diagnoses[2];
                return;
            }
            if (percentRightAnswers <= 60)
            {
                user.Diagnose = diagnoses[3];
                return;
            }
            if (percentRightAnswers <= 80)
            {
                user.Diagnose = diagnoses[4];
                return;
            }
            if (percentRightAnswers <= 100)
            {
                user.Diagnose = diagnoses[5];
                return;
            }
            return;
        }
    }
}

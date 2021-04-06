using GeniyIdiotCommonClassLibrary;
using System;
using System.Collections.Generic;

namespace GeniyIdiotCommoClassLibrary
{
    public class Game
    {
        private List<Question> questions;
        private int allQuestionsCount;
        private Question rightQuestion;
        private User user;
        private int questionNumber = 0;
        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStoreage.Get();
            allQuestionsCount = questions.Count;
        }
        public Question PopRandomQuestion()
        {
            var random = new Random();
            int randomIndex = random.Next(0, questions.Count);
            rightQuestion = questions[randomIndex];
            questions.RemoveAt(randomIndex);
            questionNumber++;
            return rightQuestion;
        }
        public bool End()
        {
            return questions.Count == 0;
        }
        public void AcceptAwswer(int userAnswer)
        {
            int rightAnswer = rightQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
        }
        public string CalculateDiagnose()
        {
            DiagnoseCalculator.Calculate(user, allQuestionsCount);
            return $"{user.Name}, количество правильных ответов: {user.CounRightAnswers}. Ваш диагноз: {user.Diagnose}";
        }
        public string GetNumberQuestion()
        {
            return $"Вопрос №{questionNumber}";
        }
    }
}

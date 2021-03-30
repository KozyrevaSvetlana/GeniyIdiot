using System.Collections.Generic;

namespace GeniyIdiotConsoleApp
{
    public class QuestionsStoreage
    {
        public static List<Question> Get()
        {
            var questions = new List<Question>();
            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
            return questions;
        }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeniyIdiotCommonClassLibrary
{
    public class QuestionsStoreage
    {
        public static string Path = "Questions.json";
        public static List<Question> Get()
        {
            var questions = new List<Question>();
            if (!FileProvider.Exists(Path))
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                Save(questions);
            }
            else
            {
                var fileData = FileProvider.Get(Path);
                questions = JsonConvert.DeserializeObject<List<Question>> (fileData);
            }
            return questions;

        }
        public static void Add(Question newQuestion)
        {
            var questions = Get();
            questions.Add(newQuestion);
            Save(questions);
        }
        private static void Save(List<Question> questions)
        {
            var serializedData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(Path, serializedData);
        }
    }
}

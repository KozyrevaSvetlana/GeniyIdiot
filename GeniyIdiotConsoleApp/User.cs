
namespace GeniyIdiotConsoleApp
{
    public class User
    {
        public string Name;
        public int CounRightAnswers;
        public string Diagnose;
        public User(string name)
        {
            Name = name;
            CounRightAnswers = 0;
            Diagnose = "Неизвестно";
        }

        public void AcceptRightAnswer()
        {
            CounRightAnswers++;
        }
        public static bool IsValid(string userInput)
        {
            if (userInput==string.Empty)
            {
                return false;
            }
            for (int i = 0; i < userInput.Length; i++)
            {
                if (!char.IsLetterOrDigit(userInput[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

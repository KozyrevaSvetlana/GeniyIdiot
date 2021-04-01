

namespace GeniyIdiotCommonClassLibrary
{
    public class DiagnoseCalculator
    {
        public static string[] Get()
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
        public static void Calculate(User user, int countQuestions)
        {
            double percentRightAnswers = (double)user.CounRightAnswers * 100 / countQuestions;
            string[] diagnoses = Get();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

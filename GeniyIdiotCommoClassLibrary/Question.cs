using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotCommonClassLibrary
{
    public class Question
    {
        public string Text;
        public int Answer;

        public Question(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }


        public string Print()
        {
            return $"Вопрос :{Text}";
        }
    }
}

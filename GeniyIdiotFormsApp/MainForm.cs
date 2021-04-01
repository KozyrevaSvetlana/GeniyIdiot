using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniyIdiotConsoleApp;

namespace GeniyIdiotFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Question rightQuestion;
        private int countQuestions;
        private User user = new User("Неизвестно");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = QuestionsStoreage.Get();
            countQuestions = questions.Count;
            ShowNextQuestion();

        }

        public void ShowNextQuestion()
        {
            var random = new Random();
            int randomQuestionIndex = random.Next(0, questions.Count);
            rightQuestion = questions[randomQuestionIndex];
            quetionTextLabel.Text = rightQuestion.Text;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            int rightAnswer = rightQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
            questions.Remove(rightQuestion);
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
            var endGame = questions.Count == 0;
            if (endGame)
            {
                DiagnoseCalculator.Calculate(user, countQuestions);
                MessageBox.Show($"{user.Name}, количество правильных ответов: {user.CounRightAnswers}. Ваш диагноз: {user.Diagnose}");
                return;
            }
            ShowNextQuestion();
        }
    }
}

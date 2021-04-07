using System;
using System.Windows.Forms;
using GeniyIdiotCommoClassLibrary;
using GeniyIdiotCommonClassLibrary;

namespace GeniyIdiotFormsApp
{
    public partial class MainForm : Form
    {
        private Game game;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var user = new User("Неизвестно");
            var userInfoForm = new UserInfoForm(user);
            var result = userInfoForm.ShowDialog(this);
            while (result != DialogResult.OK)
            {
                var resultUser = MessageBox.Show("Вы действительно хотите выйти?", "Exit", MessageBoxButtons.YesNo);
                if (resultUser == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    result = userInfoForm.ShowDialog(this);
                }
            }
            game = new Game(user);
            ShowNextQuestion();
        }

        public void ShowNextQuestion()
        {
            var rightQuestion = game.PopRandomQuestion();
            quetionTextLabel.Text = rightQuestion.Text;
            quetionNumberLabel.Text = game.GetNumberQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            game.AcceptAwswer(userAnswer);
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
            if (game.End())
            {
                var diagnose = game.CalculateDiagnose();
                MessageBox.Show(diagnose);
                userAnswerTextBox.Enabled = false;
                nextButton.Enabled = false;
                return;
            }
            ShowNextQuestion();
        }
    }
}

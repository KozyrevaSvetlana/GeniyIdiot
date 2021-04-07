using System;
using System.Windows.Forms;
using GeniyIdiotCommoClassLibrary;
using GeniyIdiotCommonClassLibrary;

namespace GeniyIdiotFormsApp
{
    public partial class MainForm : Form
    {
        private Game game;
        private User user;
        public bool okUserName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User("Неизвестно");
            var userInfoForm = new UserInfoForm(user);

            var result = userInfoForm.ShowDialog(this);
            while (result != DialogResult.OK)
            {
                var resultUser = MessageBox.Show("Вы действительно хотите выйти?", "Exit", MessageBoxButtons.YesNo);
                if (resultUser == DialogResult.Yes)
                {
                    Application.Exit();
                    break;
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
                UserResultsStoreage.Append(user);
                userAnswerTextBox.Enabled = false;
                nextButton.Enabled = false;
                return;
            }
            ShowNextQuestion();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите начать игру заново?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Restart();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new UserResultsForm();
            resultsForm.ShowDialog(this);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из игры?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}

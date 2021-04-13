using GeniyIdiotCommonClassLibrary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GeniyIdiotFormsApp
{
    public partial class UserInfoForm : Form
    {
        private User user;
        public UserInfoForm(User user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            if (inputTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите имя");
                user.Name = string.Empty;
            }
            else
            {
                    user.Name = inputTextBox.Text;
                    Close();
            }
        }

        private void inputTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (Regex.IsMatch(inputTextBox.Text, "[^0-9a-zA-Zа-яА-Я]"))
            {
                MessageBox.Show("Недопустимое имя. Оно должно содержать только буквы и/или цифры");
                inputTextBox.Text = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1);
                inputTextBox.SelectionStart = inputTextBox.Text.Length;
            }
        }

        private void UserInfoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                okButton.PerformClick();
            }
        }
    }
}

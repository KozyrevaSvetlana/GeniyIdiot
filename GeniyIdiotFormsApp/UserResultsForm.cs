using GeniyIdiotCommonClassLibrary;
using System;
using System.Windows.Forms;

namespace GeniyIdiotFormsApp
{
    public partial class UserResultsForm : Form
    {
        public UserResultsForm()
        {
            InitializeComponent();
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultsStoreage.GetAll();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.CounRightAnswers, result.Diagnose);
            }
        }
    }
}

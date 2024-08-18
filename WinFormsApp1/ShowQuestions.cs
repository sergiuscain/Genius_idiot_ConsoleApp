using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusIdiot_WinForms
{
    public partial class ShowQuestions : Form
    {
        QuestionStorage questionStorage = new QuestionStorage();
        string pathOfQuestions = "questions.txt";
        public ShowQuestions()
        {
            InitializeComponent();


        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            
             
                string question = yourQuestionTextBox.Text;
                string answer = yourAnswerTextBox.Text;
                questionStorage.AddQuest(pathOfQuestions, question, Convert.ToInt32( answer));
            
             

        }

        private void ShowQuestions_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("questions.txt"))
                {
                    questionStorage.ReadQuestions("questions.txt");
                    foreach (var questionAndAnswer in questionStorage)
                    {
                        if (questionAndAnswer != null)
                        {
                            ResultsGridView.Rows.Add(questionAndAnswer.question, questionAndAnswer.answer);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error reading questions from file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

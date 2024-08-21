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
        public ShowQuestions()
        {
            InitializeComponent();
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
                string question = yourQuestionTextBox.Text;
                string answer = yourAnswerTextBox.Text;
            if (int.TryParse(answer, out int answerInt))
            {
                questionStorage.AddQuestToTxtFile(question, Convert.ToInt32(answerInt));
                ResultsGridView.Rows.Add(question, answerInt);
            }
            else
                MessageBox.Show("В поле ответа вводится число!!");
            
        }

        private void ShowQuestions_Load(object sender, EventArgs e)
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
    }
}

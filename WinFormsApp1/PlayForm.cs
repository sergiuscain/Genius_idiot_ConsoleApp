using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace GeniusIdiot_WinForms
{
    public partial class PlayForm : Form
    {
        Form formtoopen;
        bool isStarted = false;
        string pathOfQuestions = "questions.txt";
        int countQuestion;
        int questionNumber = 1;
        QuestionStorage questions = new QuestionStorage();
        Player player = new Player();
        int randomQuestionIndex;
        int countQuestions;

        public PlayForm(Form main)
        {
            InitializeComponent();
            MainMenuForm.ActiveForm.Hide();
            formtoopen = main;
            questions.ReadQuestions(pathOfQuestions);
            countQuestions = questions.questions.Count;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            MainMenuForm.ActiveForm.Show();
            this.Close();
        }


        private void nextQuestion_Click(object sender, EventArgs e)
        {
            string userAnswerStr = userAnswerTextBox.Text;
            if (questions.questions.Count < 1)
                player.calculateDiagnose(questions.questions.Count);
            if (int.TryParse(userAnswerStr, out int userAnswer))
            {
                int rightAnswer = questions.questions[randomQuestionIndex].answer;
                if (Convert.ToInt32(userAnswer) == rightAnswer)
                {
                    player.countRightAnswers++;
                }
                questions.questions.RemoveAt(randomQuestionIndex);
                if (questions.questions.Count < 1)
                {
                    player.calculateDiagnose(countQuestions);
                    player.SaveResults();
                    formtoopen.Show();
                    MainMenuForm.ActiveForm.Show();
                    this.Close();
                }
                else
                {
                    randomQuestionIndex = new Random().Next(0, questions.Count());
                    textQuestLabel.Text = questions.questions[randomQuestionIndex].question;
                } 
            }
            else
            {
                MessageBox.Show("Введите число!!");
            }
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            NameForm nameForm = new NameForm();
            nameForm.ShowDialog();
            player.name = nameForm.nameTextBox.Text;
            randomQuestionIndex = new Random().Next(0, questions.Count());
            textQuestLabel.Text = questions.questions[randomQuestionIndex].question;
        }
    }
}

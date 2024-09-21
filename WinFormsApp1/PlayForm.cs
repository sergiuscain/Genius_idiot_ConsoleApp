using WinFormsApp1;
using Timer = System.Windows.Forms.Timer;

namespace GeniusIdiot_WinForms
{
    public partial class PlayForm : Form
    {
        Form mainForm;
        bool isStarted = false;
        //string pathOfQuestions = "questions.json";
        int questionNumber = 1;
        QuestionStorage questions = new QuestionStorage();
        Player player;
        int randomQuestionIndex;
        int countQuestions;
        Timer timer = new Timer();
        private int responseTime = 4; //время на ответ. Если оно истекает, ответ считается неверным.
        private int freeTime = 0;
        Timer updateTimerInfo = new Timer();

        public PlayForm(Form main)
        {
            InitializeComponent();
            MainMenuForm.ActiveForm.Hide();
            mainForm = main;
            //questions.ReadQuestionsFromTxtFile();
            questions.ReadQuestionsFromJSONFile();
            countQuestions = questions.questions.Count;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            MainMenuForm.ActiveForm.Show();
            this.Close();
        }


        private void nextQuestion_Click(object sender, EventArgs e)
        {
            Next_Button();
        }

        private void Next_Button()
        {
            timer.Stop();
            string userAnswerStr = userAnswerTextBox.Text;
            if (questions.questions.Count < 1)
            {
                GameOver();
            }
            if (int.TryParse(userAnswerStr, out int userAnswer))
            {
                int rightAnswer = questions.questions[randomQuestionIndex].answer;
                if (userAnswer == rightAnswer)
                {
                    player.countRightAnswers++;
                }
                questions.questions.RemoveAt(randomQuestionIndex);
                if (questions.questions.Count < 1)
                {
                    GameOver();
                }
                else
                {
                    NextQuestion();
                }
            }
            else
            {
                MessageBox.Show("Введите число!!");
            }
        }

        private void GameOver()
        {
            player.calculateDiagnose(countQuestions);
            //player.SaveResultsAsTxtFile();
            player.SaveResultsAsJSONFile();
            mainForm.Show();
            MainMenuForm.ActiveForm.Show();
            this.Close();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            NameForm nameForm = new NameForm();
            nameForm.ShowDialog();
            player = new Player();
            player.name = nameForm.nameTextBox.Text;
            timer.Interval = responseTime * 1000;
            timer.Tick += Failed_Timer_Tick;
            updateTimerInfo.Interval = 100;
            updateTimerInfo.Tick += UpdateTimerInfo_Tick;
            NextQuestion();
        }

        private void UpdateTimerInfo_Tick(object? sender, EventArgs e)
        {
            if (freeTime <= 0)
                updateTimerInfo.Stop();
            else
            {
                freeTime -= 110;
                freeTime_label.Text = $"Время на ответ:{freeTime / 100}";
            }
        }

        private void Failed_Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Ты медленно думаешь. Засчитан неверный ответ.");
            questions.questions.RemoveAt(randomQuestionIndex);
            NextQuestion();

        }

        private void NextQuestion()
        {
            if (questions.questions.Count < 1)
                GameOver();
            else
            {
                randomQuestionIndex = new Random().Next(0, questions.Count());
                textQuestLabel.Text = questions.questions[randomQuestionIndex].question;
                timer.Start();
                userAnswerTextBox.Clear();
                freeTime = responseTime * 1000;
                updateTimerInfo.Start();
            }
        }

        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Next_Button();
            }
        }

        private void userAnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Next_Button();
            }
        }
    }
}

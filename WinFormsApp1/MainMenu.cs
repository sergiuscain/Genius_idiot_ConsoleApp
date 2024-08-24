using GeniusIdiot_WinForms;

namespace WinFormsApp1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowQuestionsButton_Click(object sender, EventArgs e)
        {
            var  showQuestions = new ShowQuestions();
            showQuestions.ShowDialog();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(File.Exists(QuestionStorage.pathOfJSONQuestions)) //Если JSON файл с вопросами существует
            {
                if(new FileInfo(QuestionStorage.pathOfJSONQuestions).Length < 5) //если он пустой
                {
                    QuestionStorage.SaveQuestionsAsJSONFile(QuestionStorage.standartQuestions);
                    MessageBox.Show("Файл с вопросами не найден!\nДобовляем стандартные вопросы... ");
                }
                else //иначе начинаем игру
                {
                    var playForm = new PlayForm(this);
                    playForm.ShowDialog();
                }
            }
            else //Если файла не сушествует, создаем его и добавляем туда список стандартных вопросов(хранятся в QuestionStorage.standartQuestions)
            {
                QuestionStorage.SaveQuestionsAsJSONFile(QuestionStorage.standartQuestions);
                MessageBox.Show("Файл с вопросами не найден!\nДобовляем стандартные вопросы... ");
            }
        }

        private void ShowResultsButton_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
    }
}

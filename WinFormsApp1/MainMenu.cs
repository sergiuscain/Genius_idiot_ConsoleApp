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
            if(File.Exists(QuestionStorage.pathOfJSONQuestions)) //���� JSON ���� � ��������� ����������
            {
                if(new FileInfo(QuestionStorage.pathOfJSONQuestions).Length < 5) //���� �� ������
                {
                    QuestionStorage.SaveQuestionsAsJSONFile(QuestionStorage.standartQuestions);
                    MessageBox.Show("���� � ��������� �� ������!\n��������� ����������� �������... ");
                }
                else //����� �������� ����
                {
                    var playForm = new PlayForm(this);
                    playForm.ShowDialog();
                }
            }
            else //���� ����� �� ����������, ������� ��� � ��������� ���� ������ ����������� ��������(�������� � QuestionStorage.standartQuestions)
            {
                QuestionStorage.SaveQuestionsAsJSONFile(QuestionStorage.standartQuestions);
                MessageBox.Show("���� � ��������� �� ������!\n��������� ����������� �������... ");
            }
        }

        private void ShowResultsButton_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
    }
}

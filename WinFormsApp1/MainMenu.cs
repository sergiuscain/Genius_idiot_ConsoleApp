using GeniusIdiot_WinForms;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
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
            var playForm = new PlayForm();
            playForm.ShowDialog();
        }

        private void ShowResultsButton_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
    }
}

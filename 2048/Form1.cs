namespace _2048
{
    public partial class MainMenu_Form : Form
    {
        public MainMenu_Form()
        {
            InitializeComponent();
        }

        private void showTableOfRecords_Button_Click(object sender, EventArgs e)
        {

        }

        private void play_Button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text.Length > 0)
            {
                PlayForm playForm = new PlayForm(this, name_textBox.Text);
                playForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("������� ���!");
            }
        }

        private void settings_Button_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

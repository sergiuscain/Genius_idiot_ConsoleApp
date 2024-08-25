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
                Player player = new Player(name_textBox.Text);
                PlayForm playForm = new PlayForm(this);
                playForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("¬ведите им€!");
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

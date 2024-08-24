using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class PlayForm : Form
    {
        Form mainMenuForm;
        public static int mapSize = 4;
        private int blockSize = 80;

        public PlayForm(Form backForm)
        {
            InitializeComponent();
            mainMenuForm = backForm;
            MainMenu_Form.ActiveForm.Hide();
        }

        private void PlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenuForm.Show();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            CreateMap(mapSize);
        }

        private void CreateMap(int mapSize)
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    Label label = new Label();
                    label.Text = "0";
                    label.Location = new Point(25 + (blockSize +6) * j, 60 + (blockSize +6) * i);
                    label.Size = new Size(blockSize, blockSize);
                    label.BackColor = Color.Azure;
                    this.Controls.Add(label);
                }
            }
        }
    }
}

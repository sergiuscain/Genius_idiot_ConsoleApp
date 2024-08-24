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
        public static int mapSize
        {
            get { return mapSize; }
            set
            {
                if (value < 2)
                {
                    MessageBox.Show("The map cannot be less than two blocks.");
                }
                else if (value > 10)
                {
                    MessageBox.Show("The map cannot be more than 10 blocks.");
                }
                else
                {
                    mapSize = value;
                }
            }
        }
        public static int blockSize
        {
            get { return blockSize; }
            set
            {
                if (value < 10)
                {
                    MessageBox.Show("The block size cannot be less than 10 pixels.");
                }
                else if (value > 200)
                {
                    MessageBox.Show("The block size cannot be more than 200 pixels.");
                }
                else
                {
                    blockSize = value;
                }

            }
        }

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

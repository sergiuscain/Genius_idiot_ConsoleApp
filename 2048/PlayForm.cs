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
        private static int _mapSize = 4;
        private static int _blockSize = 80;
        Random random = new Random();
        Label[,] map = new Label[mapSize, mapSize];
        string[] numbers = { "2","4"};
        public static int mapSize
        {
            get
            {
                return _mapSize;
            }
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
                    _mapSize = value;
                }
            }
        }
        public static int blockSize
        {
            get { return _blockSize; }
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
                    _blockSize = value;
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
            CreateRandomBlock();
        }

        private void CreateRandomBlock()
        {
            int randomX = random.Next(0, _mapSize);
            int randomY = random.Next(0, _mapSize);
            if (map[randomX, randomY].Text == "")
            {
                map[randomX, randomY].Text = numbers[random.Next(2)];
              
            }
        }


        private void CreateMap(int _mapSize)
        {
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                   var  newLable =  createLabel(i, j);
                    map[i,j] = newLable;
                }
            }
        }

        private Label createLabel(int indexRow, int indexColumn)
        {
            Label label = new Label();
            label.Text = (indexRow * mapSize + indexColumn).ToString();
            label.Location = new Point(25 + (_blockSize + 6) * indexColumn, 60 + (_blockSize + 6) * indexRow);
            label.Size = new Size(_blockSize, _blockSize);
            label.BackColor = Color.Azure;
            Controls.Add(label);
            map[indexRow, indexColumn] = label;
            return label;
        }
    }
}

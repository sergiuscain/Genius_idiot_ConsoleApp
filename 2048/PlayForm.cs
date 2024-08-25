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
        Label[,] map = new Label[_mapSize, _mapSize];
        string[] numbers = { "2", "4" };
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
            while (true)
            {
                int randomX = random.Next(0, _mapSize);
                int randomY = random.Next(0, _mapSize);
                if (map[randomX, randomY].Text == "")
                {
                    map[randomX, randomY].Text = numbers[random.Next(2)];
                    break;
                }
            }
        }


        private void CreateMap(int _mapSize)
        {
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    var newLable = createLabel(i, j);
                    map[i, j] = newLable;
                }
            }
        }

        private Label createLabel(int indexRow, int indexColumn)
        {
            Label label = new Label();
            //label.Text = (indexRow * mapSize + indexColumn).ToString();
            label.Location = new Point((_blockSize + 6) * indexColumn, 40 + (_blockSize + 6) * indexRow);
            label.Size = new Size(_blockSize, _blockSize);
            label.BackColor = Color.Azure;
            Controls.Add(label);
            map[indexRow, indexColumn] = label;
            return label;
        }

        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = 0; j < _mapSize; j++)
                    {
                        if (map[i, j].Text != "")
                        {
                            for (int k = j +1 ; k < _mapSize; k++)
                            {
                                if (map[i, k].Text != "")
                                {
                                    if (map[k, j].Text == map[i, k].Text)
                                    {
                                        map[i, j].Text = (int.Parse(map[i, j].Text) * 2).ToString();
                                        map[i, k].Text = "";
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = 0; j < _mapSize; j++)
                    {
                        if (map[i, j].Text == "")
                        {
                            for (int k = j + 1; k < _mapSize; k++)
                            {
                                if (map[i, k].Text != "")
                                {
                                    map[i, j].Text = map[i, k].Text;
                                    map[i, k].Text = "";
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = _mapSize - 1; j >= 0; j--)
                    {
                        if (map[i, j].Text != "")
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (map[i, k].Text != "")
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        map[i, j].Text = (int.Parse(map[i, j].Text) * 2).ToString();
                                        map[i, k].Text = "";
                                    }
                                    break;
                                }
                            }
                        }
                    }
               }
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = _mapSize - 1; j >= 0; j--)
                    {
                        if (map[i, j].Text == "")
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (map[i,k].Text != "")
                                {
                                    map[i, j].Text = map[i, k].Text;
                                    map[i, k].Text = "";
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (map[i, j].Text != "")
                        {
                            for (int k = j + 1; k < _mapSize; k++)
                            {
                                if (map[i, k].Text != "")
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        map[i, j].Text = (int.Parse(map[i, j].Text) * 2).ToString();
                                        map[i, k].Text = "";
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = _mapSize - 1; i >= 0; i--)
                {
                    for (int j = 0; j < _mapSize; j++)
                    {
                        if (map[i, j].Text == "")
                        {
                            for (int k = j + 1; k < _mapSize; k++)
                            {
                                map[i, j].Text = map[i, k].Text;
                                map[i, k].Text = "";
                                break;
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    for (int i = 0; i < _mapSize; i++)
                    {
                        if (map[i, j].Text != "")
                        {
                            for (int k = i + 1; k < _mapSize; k++)
                            {
                                if (map[k, j].Text != "")
                                {
                                    if (map[i, j].Text == map[k, j].Text)
                                    {
                                        map[i, j].Text = (int.Parse(map[i, j].Text) * 2).ToString();
                                        map[k, j].Text = "";
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < _mapSize; j++)
                {
                    for (int i = 0; i < _mapSize; i++)
                    {
                        if (map[i, j].Text == "")
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if ((map[k, j].Text != "")) 
                                { 
                                map[i, j].Text = map[k, j].Text;
                                map[k, j].Text = "";
                                break;
                                }
                            }
                        }
                    }
                }
            }
            if(!mapOverLoad())
            CreateRandomBlock();
            if (mapOverLoad())
            {
                MessageBox.Show("mapOverLoad!");
                
            }
        }

        private bool mapOverLoad()
        {
            int freeBlocks = 0;
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    if (this.map[i, j].Text  == "")
                        freeBlocks++;
                }
            }
            return freeBlocks <= 0;
        }
    }
}

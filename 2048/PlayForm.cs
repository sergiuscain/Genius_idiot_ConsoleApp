using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

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
        Player player;
        int record;
        public static string pathOfRecord = $"record.txt";
        public string pathOfCurrenRecord = "";
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

        public PlayForm(Form backForm, string name)
        {
            InitializeComponent();
            mainMenuForm = backForm;
            MainMenu_Form.ActiveForm.Hide();
            player = new Player(name);
        }

        private void PlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenuForm.Show();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            pathOfCurrenRecord = $"record{mapSize}.txt";
            CreateMap(mapSize);
            CreateRandomBlock();
            record = SaveResults.GetRecord(pathOfCurrenRecord);
            ShowScore();
            SetColor();
        }

        private void SetColor()
        {
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    switch(map[i,j].Text)
                    {
                        case "":
                            map[i,j].BackColor = Color.White; break;
                        case "2":
                            map[i, j].BackColor = Color.FromArgb(210, 242, 187); break;
                        case "4":
                            map[i, j].BackColor = Color.FromArgb(194, 232, 168); break;
                        case "8":
                            map[i, j].BackColor = Color.FromArgb(149, 198, 115); break;
                        case "16":
                            map[i, j].BackColor = Color.FromArgb(109, 158, 75); break;
                        case "32":
                            map[i, j].BackColor = Color.FromArgb(67, 148, 94); break;
                        case "64":
                            map[i, j].BackColor = Color.FromArgb(44, 122, 71); break;
                        case "128":
                            map[i, j].BackColor = Color.FromArgb(33, 108, 97); break;
                        case "256":
                            map[i, j].BackColor = Color.FromArgb(34, 101, 110); break;
                        case "512":
                            map[i, j].BackColor = Color.FromArgb(34, 80, 110); break;
                        case "1024":
                            map[i, j].BackColor = Color.FromArgb(34, 42, 110); break;
                        case "2048":
                            map[i,j].BackColor = Color.FromArgb(26, 20, 107); break;
                        case "4096":
                            map[i, j].BackColor = Color.FromArgb(161, 104, 255); break;
                        case "8192":
                            map[i, j].BackColor = Color.FromArgb(160, 84, 240); break;
                        case "16384":
                            map[i, j].BackColor = Color.FromArgb(193, 56, 221); break;
                        case "32768":
                            map[i, j].BackColor = Color.FromArgb(208, 35, 178); break;
                        case "65536":
                            map[i, j].BackColor = Color.FromArgb(196, 33, 121); break;
                        case "131072":
                            map[i, j].BackColor = Color.FromArgb(184, 18, 73); break;
                        case "262144":
                            map[i, j].BackColor = Color.FromArgb(163, 12, 62); break;
                        case "524288":
                            map[i, j].BackColor = Color.FromArgb(125, 5, 39); break;
                        case "1048576":
                            map[i, j].BackColor = Color.FromArgb(87, 2, 11); break;
                        default:
                            map[i, j].BackColor = Color.FromArgb(39, 0, 4); break;
                    }
                }
            }
        }

        private void CreateRandomBlock()
        {
            while (true)
            {
                int randomX = random.Next(0, _mapSize);
                int randomY = random.Next(0, _mapSize);
                if (map[randomX, randomY].Text == "")
                {
                    string number;
                    int a = random.Next(100);
                    if (a < 70)
                        number = numbers[0];
                    else
                        number = numbers[1];
                    map[randomX, randomY].Text = number;
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
                MoveLeft();
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Right && e.KeyCode != Keys.Left)
            {
                return;
            }

            if (GameOver())
            {
                MessageBox.Show("Game Over!");
            }
            if (MapOverload())
            {

            }
            else 
            { 
            CreateRandomBlock();
            ShowScore();
            SetColor();
            }
        }

        private bool MapOverload()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (map[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool GameOver()
        {
           for(int i = 0; i <mapSize; i++)
            {
                for (int j = 0; j <mapSize; j++)
                {
                    if (map[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }
                for (int i = 0; i < mapSize-1; i++)
            {
                for (int j = 0; j < mapSize-1; j++)
                {
                    if ((map[i, j].Text == map[i, j+1].Text || map[i,j].Text == map[i+1, j].Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void MoveUp()
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
                                    player._score += int.Parse(map[i, j].Text) * 2;
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

        private void MoveDown()
        {
            for (int j = 0; j < _mapSize; j++)
            {
                for (int i = _mapSize - 1; i >= 0; i--)
                {
                    if (map[i, j].Text != "")
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (map[k, j].Text != "")
                            {
                                if (map[i, j].Text == map[k, j].Text)
                                {
                                    player._score += int.Parse(map[i, j].Text) * 2;
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
                for (int i = _mapSize - 1; i >= 0; i--)
                {
                    if (map[i, j].Text == "")
                    {
                        for (int k = i - 1; k >= 0; k--)
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

        private void MoveRight()
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
                                    player._score += int.Parse(map[i, j].Text) * 2;
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

        private void MoveLeft()
        {
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    if (map[i, j].Text != "")
                    {
                        for (int k = j + 1; k < _mapSize; k++)
                        {
                            if (map[i, k].Text != "")
                            {
                                if (map[i, j].Text == map[i, k].Text)
                                {
                                    player._score += int.Parse(map[i, j].Text) * 2;
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

        private void ShowScore()
        {
            scoreLabel.Text = "Score: " + player._score;
            if (player._score > record)
            {
                record = player._score;
                recordLabel.Text = "Record: " + record;
                SaveResults.ReWriteRecord(record, pathOfCurrenRecord);
            }
            else
            {
                recordLabel.Text = "Record: " + record;
            }
        }
       
    }
}
//Мур
﻿using System;
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
        public static string pathOfRecord = "record.txt";
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
            CreateMap(mapSize);
            CreateRandomBlock();
            record = GetRecord();
            ShowScore();
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
                                    if (map[i, j].Text == map[i, k].Text)
                                    {
                                        player._score += int.Parse(map[i,j].Text)*2;
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
                                        player._score += int.Parse(map[i,j].Text)*2;
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
                for (int j = 0; j < _mapSize; j++)
                {
                    for (int i = _mapSize-1; i >= 0; i--)
                    {
                        if (map[i, j].Text != "")
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (map[k, j].Text != "")
                                {
                                    if (map[i, j].Text == map[k, j].Text)
                                    {
                                        player._score += int.Parse(map[i,j].Text)*2;
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
                     for (int i = _mapSize-1; i >= 0; i--)
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
                                        player._score += int.Parse(map[i,j].Text)*2;
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
            if(!MapOverLoad())
                CreateRandomBlock();
            ShowScore();
        }

        private bool MapOverLoad()
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
            return freeBlocks < 1;
        }
        private void ShowScore()
        {
            scoreLabel.Text = "Score: " + player._score;
            if (player._score > record)
            {
                record = player._score;
                recordLabel.Text = "Record: " + record;
                ReWriteRecord(record);
            }
            else
            {
                recordLabel.Text = "Record: " + record;
            }
        }
        private int GetRecord()
        {
            if (File.Exists(pathOfRecord))
            {
                string record = File.ReadAllText(pathOfRecord);
                return int.Parse(record);
            }
            else
            {
                File.WriteAllText(pathOfRecord, "0"); 
                return 0;
            }
        }
        private void ReWriteRecord(int record)
        {
            File.WriteAllText(pathOfRecord, record.ToString());
        }
        public static void RecordReSet()
        {
            File.WriteAllText(pathOfRecord, "0");
        }
    }
}

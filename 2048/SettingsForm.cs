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
    public partial class SettingsForm : Form
    {
        string currentMapSize = "";
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void reSet_Button_Click(object sender, EventArgs e)
        {
            string pathOfRecord = $"record{currentMapSize}.txt";
            if (currentMapSize == string.Empty)
            {
                MessageBox.Show("Выберите размер карты");
            }
            else
            {
                SaveResults.RecordReSet(pathOfRecord);
            }
        }

        private void button3x3_Click(object sender, EventArgs e)
        {
            currentMapSize = "3";
            PlayForm.mapSize = 3;
        }

        private void button4x4_Click(object sender, EventArgs e)
        {
            currentMapSize = "4";
            PlayForm.mapSize = 4;
        }

        private void button5x5_Click(object sender, EventArgs e)
        {
            currentMapSize = "5";
            PlayForm.mapSize = 5;
        }

        private void button6x6_Click(object sender, EventArgs e)
        {
            currentMapSize = "6";
            PlayForm.mapSize = 6;
        }
    }
}

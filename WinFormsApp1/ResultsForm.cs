using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusIdiot_WinForms
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            //LoadResultsFromTxtFile();
            LoadResultsFromJsonFile();

        }

        private void LoadResultsFromTxtFile()
        {
            if (File.Exists(Player.pathOfTxtResults))
            {
                StreamReader reader = new StreamReader(Player.pathOfTxtResults, Encoding.UTF8);
                while (!reader.EndOfStream)
                {
                    String[] lines = reader.ReadLine().Split("~");
                    resultsGridView.Rows.Add(lines);
                }
                reader.Close();
            }
            else
            {
                File.Create(Player.pathOfTxtResults).Close();
            }
        }

        private void LoadResultsFromJsonFile()
        {
            if (File.Exists(Player.pathOfJSONResults))
            {
                if (new FileInfo(Player.pathOfJSONResults).Length > 2)
                {
                    string jsonData = File.ReadAllText(Player.pathOfJSONResults); //json файл в виде строки. 
                    List<Player> list = JsonConvert.DeserializeObject<List<Player>>(jsonData);
                    foreach (Player p in list)
                    {
                        string[] lines = { p.name, p.countRightAnswers.ToString(), p.diagnose };
                        resultsGridView.Rows.Add(lines);
                    }
                }
                else
                {
                    File.Create(Player.pathOfJSONResults).Close();
                }
            }
        }

        private void resultsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

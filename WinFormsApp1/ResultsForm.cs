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
        string path = Player.pathOfTxtResults;
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path, Encoding.UTF8);
                while (!reader.EndOfStream)
                {
                    String[] lines = reader.ReadLine().Split("~");
                    resultsGridView.Rows.Add(lines);
                }
                reader.Close();
            }
            else
            {
                File.Create(path).Close();
                MessageBox.Show("Отсутствуют результаты.");
            }
            
        }
    }
}

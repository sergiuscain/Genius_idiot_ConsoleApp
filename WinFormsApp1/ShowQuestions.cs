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
    public partial class ShowQuestions : Form
    {
        public ShowQuestions()
        {
            InitializeComponent();

        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            string question ="b" ;
            string answer = "a";
            ResultsGridView.Rows.Add(question, answer);
        }
    }
}

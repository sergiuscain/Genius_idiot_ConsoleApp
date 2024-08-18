using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot_WinForms
{
    internal class Player
    {
        public int countRightAnswers;
        public string name;
        public string diagnose;
        public static string path = "results.txt";
        public Player()
        {
            countRightAnswers = 0;
        }
        public void calculateDiagnose(int countQuestions)
        {
            int precentOfRightAnswer = (countRightAnswers * 100) / countQuestions;
            if (precentOfRightAnswer <= 20)
                diagnose = "Кретин";
            else if (precentOfRightAnswer <= 40)
                diagnose = "Идиот";
            else if (precentOfRightAnswer <= 50)
                diagnose = "Дурак";
            else if (precentOfRightAnswer <= 75)
                diagnose = "Нормальный";
            else if (precentOfRightAnswer <= 95)
                diagnose = "Талант";
            else
                diagnose = "Гений";
            MessageBox.Show(diagnose);
        }

        internal void SaveResults()
        {
            if (File.Exists(path))
            {
                StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);
                writer.WriteLine($"{name}~{countRightAnswers}~{diagnose}");
                writer.Close();
            }
            else
            {
                File.Create(path).Close();
                SaveResults();
            }
        }
    }
}

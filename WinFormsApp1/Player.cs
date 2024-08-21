using Newtonsoft.Json;
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
        public static string pathOfTxtResults = "results.txt";
        public static string pathOfJSONResults = "results.json";
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

        internal void SaveResultsAsTxtFile()
        {
            if (File.Exists(pathOfTxtResults))
            {
                StreamWriter writer = new StreamWriter(pathOfTxtResults, true, Encoding.UTF8);
                writer.WriteLine($"{name}~{countRightAnswers}~{diagnose}");
                writer.Close();
            }
            else
            {
                File.Create(pathOfTxtResults).Close();
                SaveResultsAsTxtFile();
            }
        }

        internal void SaveResultsAsJSONFile()
        {
            if (File.Exists(pathOfJSONResults))
            {
                if (new FileInfo(pathOfJSONResults).Length > 2)
                {
                    string jSONData = File.ReadAllText(pathOfJSONResults); //json файл в виде строки. 
                    List<Player> list = JsonConvert.DeserializeObject<List<Player>>(jSONData);
                    list.Add(this);
                    string newJSONData = JsonConvert.SerializeObject(list);
                    File.WriteAllText(pathOfJSONResults, newJSONData);
                }
                else
                {
                    string newJSONData = JsonConvert.SerializeObject(new List<Player> { this });
                    File.WriteAllText(pathOfJSONResults, newJSONData);
                }
            }
            else
            {
                File.Create(pathOfJSONResults).Close();
                SaveResultsAsJSONFile();
            }
        }
    }
}

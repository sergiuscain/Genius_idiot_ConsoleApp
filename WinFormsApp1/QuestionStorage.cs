using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot_WinForms
{
    public class QuestionStorage : IEnumerable<Question> , IEnumerator<Question>
    {
        public static string pathOfTxtQuestions = "questions.txt";
        public static string pathOfJSONQuestions = "questions.json";
        public QuestionStorage()
        {
            questions = new List<Question>();
        }

        public List<Question> questions;
        private int index = -1;

        public Question Current => questions[index];

        object IEnumerator.Current => questions[index];

        public void Dispose()
        {
            
        }


        public IEnumerator<Question> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            index++;
            return index < questions.Count;
        }

        public void Reset()
        {
            index = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void ReadQuestions(string path)
        {
            StreamReader reader = new StreamReader(path, Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                String[] lines = reader.ReadLine().Split("~");
                questions.Add(new Question(lines[0], Convert.ToInt32(lines[1])));
            }
            reader.Close();
        }

        internal void AddQuestToTxtFile(string question, int answer)
        {
            if (File.Exists(pathOfTxtQuestions))
            {
                StreamWriter writer = new StreamWriter(pathOfTxtQuestions, true, Encoding.UTF8);
                writer.WriteLine($"{question}~{answer}");
                writer.Close();
            }
            else
            {
                File.Create(pathOfTxtQuestions).Close();
                AddQuestToTxtFile(question, answer);
            }
            
        }

        internal void AddQuestToJSONFile(string question, int answer)
        {
            if (File.Exists(pathOfJSONQuestions))
            {
                if(new FileInfo(pathOfJSONQuestions).Length > 1)
                {
                    string jSONData = File.ReadAllText(pathOfJSONQuestions); //json файл в виде строки. 
                    List<Question> list = JsonConvert.DeserializeObject<List<Question>>(jSONData);
                    list.Add(new Question(question, answer));
                    string newJSONData = JsonConvert.SerializeObject(list);
                    File.WriteAllText(pathOfJSONQuestions, newJSONData);
                }
            }
            else
            {
                File.Create(pathOfJSONQuestions).Close();
                AddQuestToTxtFile(question, answer);
            }

        }
    }

}

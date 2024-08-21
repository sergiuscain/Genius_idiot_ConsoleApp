using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public void ReadQuestionsFromTxtFile()
        {
            StreamReader reader = new StreamReader(pathOfTxtQuestions, Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                String[] lines = reader.ReadLine().Split("~");
                questions.Add(new Question(lines[0], Convert.ToInt32(lines[1])));
            }
            reader.Close();
        }

        public void ReadQuestionsFromJSONFile()
        {
            if(File.Exists(pathOfJSONQuestions))
            {
                if(new FileInfo(pathOfJSONQuestions).Length > 2)
                {
                    string jSONData = File.ReadAllText(pathOfJSONQuestions); //json файл в виде строки.
                    List<Question> list = JsonConvert.DeserializeObject<List<Question>>(jSONData);
                    questions.AddRange(list);
                }
            }
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
                if(new FileInfo(pathOfJSONQuestions).Length > 2)
                {
                    string jSONData = File.ReadAllText(pathOfJSONQuestions); //json файл в виде строки. 
                    List<Question> list = JsonConvert.DeserializeObject<List<Question>>(jSONData);
                    list.Add(new Question(question, answer));
                    string newJSONData = JsonConvert.SerializeObject(list);
                    File.WriteAllText(pathOfJSONQuestions, newJSONData);
                }
                else
                {
                    string jSONData = JsonConvert.SerializeObject(new List<Question> { new Question(question, answer) });
                    File.WriteAllText(pathOfJSONQuestions, jSONData);
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

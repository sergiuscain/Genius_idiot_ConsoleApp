using System.Text;

namespace Genius_idiot_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> questionsAndAnswers = new Dictionary<string,string>();
            questionsAndAnswers.Add("Сколько будет два плюс два, умноженное на два?", "6");
            questionsAndAnswers.Add("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", "9");
            questionsAndAnswers.Add("Укол делают каждые пол часа, сколько нужно минут для трех уколов ?", "60");
            questionsAndAnswers.Add("Пять свечей горело, две потухли. Сколько свечей осталось ?", "2");
            questionsAndAnswers.Add("У человека на пяти руках 30 пальцев, сколько пальцев на 2 руках?", "12");
            while (true)
            {
            loop:
                Console.WriteLine("Что-бы посмотреть все результаты, нажмите 0. Что-бы добавить новый вопрос: 2. Либо любую другую клавишу, что-бы продолжить.");
                string command = Console.ReadLine();
                if (command == "0")
                    LookResults();
                else if (command == "1")
                {
                    Console.WriteLine("Введите вопрос, затем, на новой строке ответ");
                    questionsAndAnswers.Add(Console.ReadLine(), Console.ReadLine());
                }    
                List<string> questions = TakeQuestions(questionsAndAnswers);
                List<string> answers = TakeAnswers(questionsAndAnswers);
                int RightAnswerCount = 0;
                int numberOfQuestion = 1;
                Random rnd = new Random();
                Console.WriteLine("Как вас зовут ?");
                string name = Console.ReadLine();
                while (questions.Count > 0)
                {
                    int indexOfCurrectQuestion = rnd.Next(questions.Count);
                    Console.WriteLine($"Вопрос N{numberOfQuestion++}: {questions[indexOfCurrectQuestion]}");
                    string YourAnswer = TakeYourAnswer();
                    if (YourAnswer == "10010")
                        goto loop;
                    if (YourAnswer == answers[indexOfCurrectQuestion])
                        RightAnswerCount++;
                    questions.RemoveAt(indexOfCurrectQuestion);
                    answers.RemoveAt(indexOfCurrectQuestion);
                }
                string diagnose = MakeDiagnosis(RightAnswerCount, name, questionsAndAnswers.Count);
                Console.WriteLine($"Ваш диагноз: {diagnose}!!");
                Console.WriteLine("Что-бы сохранить рузультат и выйти, нажмите 1, что-бы пройти тест повторно - 2, что-бы выйти без сохранения - 3");

                while (true)
                {
                    string answer = TakeYourAnswer();
                    if (answer == "2")
                    {
                        Console.WriteLine($"Вы согласились пройти тест повторно");
                        break;
                    }
                    else if (answer == "3")
                    {
                        Console.WriteLine($"Вы отказались пройти тест повторно");
                        return;
                    }
                    else if(answer == "1")
                    {
                        SaveResult(diagnose, name, RightAnswerCount) ;
                        Console.WriteLine("Рузультат сохранен!!");
                        break;
                    }
                    Console.WriteLine("Вы вели не корректный ответ, попробуйте снова");
                }
            }
        }

        private static void LookResults()
        {
            StreamReader reader = new StreamReader("results.txt", Encoding.UTF8);
            Console.WriteLine("Имя\t\tКол-во правильных ответов\tДиагноз");
            while (!reader.EndOfStream)
            {
                String[] lines = reader.ReadLine().Split('~');
                Console.WriteLine($"{lines[0]}\t\t{lines[2]}\t\t\t\t{lines[1]}");
            }
            reader.Close();
        }

        private static void SaveResult(string diagnose, string name, int RightAnswersCount)
        {
            StreamWriter writer = new StreamWriter("results.txt",true, Encoding.UTF8);
            writer.WriteLine($"{name}~{diagnose}~{RightAnswersCount}");
            writer.Close();
        }

        public static List<string> TakeQuestions(Dictionary<string,string> questionsAndAnswers)
        {
            List<string> questions = new List<string>();
            for (int i = 0; i < questionsAndAnswers.Count; i++)
            {
                questions.Add(questionsAndAnswers.Keys.ElementAt(i));
            }
            return questions;
        }
        public static List<string> TakeAnswers(Dictionary<string,string> questionsAndAnswers)
        {
            List<string> answers = new List<string>();
            for (int i = 0; i < questionsAndAnswers.Count; i++)
            {
                answers.Add(questionsAndAnswers.Values.ElementAt(i));
            }
            return answers;
        }
        public static string TakeYourAnswer()
        {
            while (true)
            {
                string yourAnswer = Console.ReadLine();
                if (int.TryParse(yourAnswer, out int answer))
                    return answer.ToString();

                Console.WriteLine("Вы вели не корректный ответ, попробуйте снова");
            }
        }
        public static string MakeDiagnosis(int rightAnswerCount, string name, int answersCount)
        {
            int precentOfRightAnswer = (rightAnswerCount * 100) / (answersCount);
            string diagnose = "";
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
            return diagnose;
        }
        
    }
}

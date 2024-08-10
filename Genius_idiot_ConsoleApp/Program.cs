namespace Genius_idiot_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                loop:
                List<string> questions = TakeQuestions();
                List<string> answers = TakeAnswers();
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
                MakeDiagnosis(RightAnswerCount, name);

                Console.WriteLine("Пройти тест повторно ?\nВведите Yes/Y если согласны и No/N, если не согласны");
                while (true)
                {
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "yes")
                    {
                        Console.WriteLine($"Вы согласились пройти тест повторно");
                        break;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        Console.WriteLine($"Вы отказались пройти тест повторно");
                        return;
                    }
                    Console.WriteLine("Вы вели не корректный ответ, попробуйте снова");
                }
            }
        }
        public static List<string> TakeQuestions()
        {
            return new List<string>()
            {
                "Сколько будет два плюс два, умноженное на два?",
                "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?",
                "На двух руках 12 пальцев, сколько палцев на 5 руках?",
                "Укол делают каждые пол часа, сколько нужно минут для трех уколов ?",
                "Пять свечей горело, две потухли. Сколько свечей осталось ?"
            };
        }
        public static List<string> TakeAnswers()
        {
            return new List<string>()
            {
                "6",
                "9",
                "30",
                "60",
                "2"
            };
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
        public static void MakeDiagnosis(int RightAnswerCount, string name)
        {
            string[] diagnosis =
            {
                "Идиот",
                "Кретин",
                "Дурак",
                "Нормальный",
                "Талант",
                "Гений",
            };
            Console.WriteLine($"{name}, ваш диагноз: {diagnosis[RightAnswerCount]}");
        }
    }
}
//

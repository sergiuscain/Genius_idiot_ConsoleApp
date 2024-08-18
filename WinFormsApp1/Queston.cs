using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot_WinForms
{
    public class Question
    {
        public string question;
        public int answer;
        public Question(string question, int answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}

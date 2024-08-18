using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot_WinForms
{
    internal class Question
    {
        string question;
        int answer;
        public Question(string question, int answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    public class Question
    {
        public string questionText { get; set; }
        public string[] WrongAnswers { get; } = new string[3];
        public string rightAnswer { get; set; }
    }
}

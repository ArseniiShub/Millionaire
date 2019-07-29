using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    public class Question
    {
        public Question()
        {
        }
        public Question(IList<string> lines)
        {
            QuestionText = lines[0];
            RightAnswer = lines[1];
            WrongAnswer1 = lines[2];
            WrongAnswer2 = lines[3];
            WrongAnswer3 = lines[4];
        }
        public string QuestionText { get; set; }       
        public string RightAnswer { get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
        public string WrongAnswer3 { get; set; }
        public IEnumerable<string> GetQuestionData()
        {
            yield return QuestionText;
            yield return RightAnswer;
            yield return WrongAnswer1;
            yield return WrongAnswer2;
            yield return WrongAnswer3;
        }
    }
}

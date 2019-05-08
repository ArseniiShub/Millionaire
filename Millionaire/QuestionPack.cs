using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    [Serializable]
    public class QuestionPack
    {

        public string packName;
        public Question[] questions = new Question[GameRules.questionNumber + GameRules.replacerNumber];
    }
}

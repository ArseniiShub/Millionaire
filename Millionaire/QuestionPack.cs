using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Millionaire
{
    [Serializable]
    public class QuestionPack 
    {
        public int id;
        public string packName;
        public bool isCompleted = false;
        public int timesPlayed;
        public Question[] questions = new Question[GameRules.questionNumber];
        public Question[] replacerQuestions = new Question[GameRules.replacerNumber];
    }
}

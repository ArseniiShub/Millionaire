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
        [NonSerialized]
        public static int questionNumber = 15;//To GameRules
        [NonSerialized]
        public static int replacersNumber = 3;//To GameRules

        public string packName;
        public Question[] questions = new Question[questionNumber + replacersNumber];
    }
}

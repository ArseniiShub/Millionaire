using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    class QuestionController
    {
        public QuestionController(IDataProvider dataProvider, IGameRules gameRules)
        {
            GameRules = gameRules;
            DataProvider = dataProvider;
            timer.Tick += new EventHandler(Timer_Tick);
            TimeLeftToAnswer = GameRules.TimeToAnswer;
            questionPack = new QuestionPack(gameRules);
        }
        #region Timer
        public Timer timer = new Timer() { Interval = 1000 };
        public int TimeLeftToAnswer { get; set; }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeLeftToAnswer--;

            if (TimeLeftToAnswer == 0)
            {
                throw new NotImplementedException();
                timer.Stop();
                //GameOver
            } 
        }
        #endregion
        public IGameRules GameRules { get; set; }
        public IDataProvider DataProvider;
        public List<string> packNameList = new List<string>();
        public QuestionType CurrentQuestionState { get; set; } = QuestionType.Default;
        public int CurrentIndex { get; set; }

        private QuestionPack questionPack;
        public string CurrentProgress
        {
            get
            {
                switch (CurrentQuestionState)
                {
                    case QuestionType.Default: return $"{CurrentIndex + 1} / {GameRules.QuestionNumber}";
                    case QuestionType.ReplacerQuestion: return $"{CurrentIndex + 1} / {GameRules.ReplacerNumber}";
                    default: throw new NotImplementedException("Unknown Question Type");
                }
            }
        }

        public void SetQuestionController(int currentQuestionIndex, QuestionType questionType)
        {
            SetQuestionController(currentQuestionIndex);
            CurrentQuestionState = questionType;
        }
        public void SetQuestionController(int currentQuestionIndex)
        {
            CurrentIndex = currentQuestionIndex;
        }

        public bool IsRightAnswer(string answer)
        {
            switch (CurrentQuestionState)
            {
                case QuestionType.Default: return answer == questionPack.questions[CurrentIndex].RightAnswer;
                case QuestionType.ReplacerQuestion: return answer == questionPack.replacerQuestions[CurrentIndex].RightAnswer;
                default: throw new NotImplementedException("Unknown Question Type");
            }
        }

        public void SavePackName(string name)
        {
            questionPack.PackName = name;
        }

        public Question GetCurrentQuestion()
        {
            switch (CurrentQuestionState)
            {
                case QuestionType.Default:
                    return questionPack.questions[CurrentIndex];
                case QuestionType.ReplacerQuestion:
                    return questionPack.replacerQuestions[CurrentIndex];
                default: throw new Exception("Unknown Question Type");
            }
        }

        public void SaveCurrentQuestion(Question question)
        {
            switch (CurrentQuestionState)
            {
                case QuestionType.Default:
                    questionPack.questions[CurrentIndex] = question;
                    break;
                case QuestionType.ReplacerQuestion:
                    questionPack.replacerQuestions[CurrentIndex] = question;
                    break;
                default:
                    throw new Exception("Unknown Question Type");
            }
        }

        public string GetPackName()
        {
            return questionPack.PackName;
        }

        public void SaveFile()
        {
            questionPack.IsCompleted = true;
            DataProvider.SaveQuestionPack(questionPack, packNameList);
            packNameList.Add(questionPack.PackName);
        }

        public void DeleteFile(string fileName)
        {
            DataProvider.DeleteQuestionPack(fileName);
            packNameList.Remove(fileName);
        }

        public void LoadQuestionPack(string packName)
        {
            questionPack = DataProvider.GetQuestionPack(packName);
        }

        public void RefreshPackNameList()
        {
            packNameList.Clear();
            foreach (var item in DataProvider.GetQuestionPacksList())
            {
                packNameList.Add(item.PackName);
            }
        }
    }
}

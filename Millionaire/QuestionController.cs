using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class QuestionController
    {
        QuestionPack questionPack = new QuestionPack();
        //List<IHint>
        //IGameRules gameRules { get; set; }
        public static IDataProvider DataProvider;
        public static List<string> packNameList = new List<string>();
        public QuestionType CurrentQuestionState { get; set; } = QuestionType.Default;

        public int CurrentIndex { get; set; }

        public string CurrentProgress
        {
            get
            {
                switch (CurrentQuestionState)
                {
                    case QuestionType.Default: return $"{CurrentIndex + 1} / {GameRules.questionNumber}";
                    case QuestionType.ReplacerQuestion: return $"{CurrentIndex + 1} / {GameRules.replacerNumber}";
                    default: throw new NotImplementedException("Unknown Question Type");
                }
            }
        }

        public void SetQuestionController(int currentQuestionIndex, QuestionType questionType)
        {
            CurrentIndex = currentQuestionIndex;
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
            questionPack.packName = name;
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
            return questionPack.packName;
        }

        public void SaveFile()
        {
            questionPack.isCompleted = true;
            DataProvider.SaveQuestionPack(questionPack, packNameList);
            packNameList.Add(questionPack.packName);
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

        public static void RefreshPackNameList()
        {
            packNameList.Clear();
            foreach (var item in DataProvider.GetQuestionPacksList())
            {
                packNameList.Add(item.packName);
            }
        }
    }
}

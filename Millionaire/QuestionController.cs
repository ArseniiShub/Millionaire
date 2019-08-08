using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    static class QuestionController //Фабрика? Переделать в динамический класс
    {
        static QuestionPack questionPack = new QuestionPack();
        //List<IHint>
        //IGameRules gameRules { get; set; }
        public static IDataProvider DataProvider;
        public static List<string> packNameList = new List<string>();
        public static QuestionType CurrentQuestionState { get; set; } = QuestionType.Default;

        public static void Clear()
        {
            questionPack = new QuestionPack();
            CurrentQuestion.index = 0;
            CurrentQuestionState = QuestionType.Default;
        }

        public static class CurrentQuestion //Change
        {
            public static int index = 0;

            public static bool IsFirst()
            {
                return index == 0;
            }
            public static bool IsLast()
            {
                return index == questionNumber - 1;
            }
        }

        static int questionNumber = GameRules.questionNumber;

        public static string GetCurrentProgress() //Заменить на свойство
        {
            return $"{CurrentQuestion.index + 1} / {questionNumber}";
        }

        public static void SetCounter(int currentQuestion, int questionNumber)
        {
            CurrentQuestion.index = currentQuestion - 1;
            QuestionController.questionNumber = questionNumber;
        }

        public static bool IsRightAnswer(string answer)
        {
            switch (CurrentQuestionState)
            {
                case QuestionType.Default: return answer == questionPack.questions[CurrentQuestion.index].RightAnswer;
                case QuestionType.ReplacerQuestion: return answer == questionPack.replacerQuestions[CurrentQuestion.index].RightAnswer;
                default: throw new NotImplementedException("Unknown Question Type");
            }
        }

        public static void SavePackName(string name)
        {
            questionPack.packName = name;
        }

        public static Question GetCurrentQuestion()
        {
            switch (CurrentQuestionState)
            {
                case QuestionType.Default:
                    return questionPack.questions[CurrentQuestion.index];
                case QuestionType.ReplacerQuestion:
                    return questionPack.replacerQuestions[CurrentQuestion.index];
                default: throw new Exception("Unknown Question Type");
            }
        }

        public static void SaveCurrentQuestion(Question question)
        {
            switch (CurrentQuestionState)
            {
                case QuestionType.Default:
                    questionPack.questions[CurrentQuestion.index] = question;
                    break;
                case QuestionType.ReplacerQuestion:
                    questionPack.replacerQuestions[CurrentQuestion.index] = question;
                    break;
                default:
                    throw new Exception("Unknown Question Type");
            }
        }

        public static string GetPackName()
        {
            return questionPack.packName;
        }

        public static void SaveFile()
        {
            questionPack.isCompleted = true;
            DataProvider.SaveQuestionPack(questionPack, packNameList);
            packNameList.Add(questionPack.packName);
        }

        public static void DeleteFile(string fileName)
        {
            DataProvider.DeleteQuestionPack(fileName);
            packNameList.Remove(fileName);
        }

        public static void LoadQuestionPack(string packName)
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

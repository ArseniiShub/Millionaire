using Millionaire.GameRules;
using System;

namespace Millionaire
{
    [Serializable]
    public class QuestionPack
    {
        public QuestionPack(IGameRules gameRules)
        {
            questions = new Question[gameRules.QuestionNumber];
            replacerQuestions = new Question[gameRules.ReplacerNumber];
        }
        public QuestionPack()
        {
            IGameRules gameRules = new DefaultGameRules();
            questions = new Question[gameRules.QuestionNumber];
            replacerQuestions = new Question[gameRules.ReplacerNumber];
        }

        public string PackName { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int TimesPlayed { get; set; } = 0;

        public Question[] questions;
        public Question[] replacerQuestions;
    }
}

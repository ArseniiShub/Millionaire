using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire.GameRules
{
    class DefaultGameRules : IGameRules
    {
        public int QuestionNumber { get; } = 15;
        public int ReplacerNumber { get; } = 3;
        public int TimeToAnswer { get; } = 60;
        public int AdditionalTimeToAnswer { get; } = 120;

        public int GetCurrentPrize(int currentQuestionNum)
        {
            switch (currentQuestionNum)
            {
                case 0: case 1: case 2: case 3: return currentQuestionNum * 100;
                case 4: return 500;
                case 5: case 6: case 7: case 8: case 9: case 10: case 11: return GetCurrentPrize(currentQuestionNum - 1) * 2;
                case 12: return 125000;
                default: return GetCurrentPrize(currentQuestionNum - 1) * 2;
            }
        }

        public int GetFinalPrize(int currentQuestionNum)
        {
            if (currentQuestionNum == 15)
                return 1000000;
            else if (currentQuestionNum >= 10)
                return 32000;
            else if (currentQuestionNum >= 5)
                return 1000;
            else return 0;
        }
    }
}

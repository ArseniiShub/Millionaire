using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    public interface IGameRules
    {
        int QuestionNumber { get; }
        int ReplacerNumber { get; }
        int TimeToAnswer { get; }
        int AdditionalTimeToAnswer { get; }
        int GetCurrentPrize(int currentQuestionNum);
        int GetFinalPrize(int currentQuestionNum);
    }
}

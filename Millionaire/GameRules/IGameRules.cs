namespace Millionaire.GameRules
{
    public interface IGameRules
    {
        int QuestionNumber { get; }
        int ReplacerNumber { get; }
        int TimeToAnswer { get; }
        int AdditionalTimeToAnswer { get; }
        bool HintsAvailable { get; }
        int GetCurrentPrize(int currentQuestionNum);
        int GetFinalPrize(int currentQuestionNum);
        int GetReplacerQuestionIndex(int currentQuesitonIndex);
    }
}

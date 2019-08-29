using System.Collections.Generic;

namespace Millionaire.DataService
{
    public interface IDataProvider
    {
        QuestionPack GetQuestionPack(string packName);
        //bool TryGetQuestionPack(out QuestionPack questionPack, int id);
        List<QuestionPack> GetQuestionPacksList();

        void DeleteQuestionPack(string fileName);
        void SaveQuestionPack(QuestionPack questionPack, IList<string> nameList);
    }
}

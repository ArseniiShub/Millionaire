using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    public interface IDataProvider
    {
        Dictionary<int, string> GetQuestionPackList();
        bool TryGetQuestionPackList(out Dictionary<int, string> quizList);

        QuestionPack GetQuestionPack(int id);
        bool TryGetQuestionPack(out QuestionPack questionPack, int id);

        void SaveQuestionPack(QuestionPack questionPack);
        void SaveQuestionPackList(string packName);
    }
}

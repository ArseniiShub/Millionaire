using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    public interface IDataProvider
    {
        QuestionPack GetQuestionPack(string packName);
        //bool TryGetQuestionPack(out QuestionPack questionPack, int id);
        List<QuestionPack> GetQuestionPacksList();

        void DeleteQuestionPack(string fileName);
        void SaveQuestionPack(QuestionPack questionPack);
    }
}

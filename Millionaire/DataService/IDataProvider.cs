using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    public interface IDataProvider
    {
        QuestionPack GetQuestionPack(int id);
        bool TryGetQuestionPack(out QuestionPack questionPack, int id);

        void SaveQuestionPack(QuestionPack questionPack);
    }
}

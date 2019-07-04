using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Millionaire
{
    class XmlDataProvider : IDataProvider
    {
        private readonly string packListFilePath;
        public XmlDataProvider(string packListFilePath = "PackNames.xml")
        {
            this.packListFilePath = packListFilePath;
        }

        public QuestionPack GetQuestionPack(int id)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(QuestionPack));
            using (FileStream fs = new FileStream($"QuestionPacks\\{id}.xml", FileMode.Open))
            {
                return (QuestionPack)formatter.Deserialize(fs);
            }
        }

        public bool TryGetQuestionPack(out QuestionPack questionPack, int id)
        {
            bool isFine;
            try
            {
                questionPack = GetQuestionPack(id);
                isFine = true;
            }
            catch
            {
                questionPack = null;
                isFine = false;
            }
            return isFine;
        }

        public void SaveQuestionPack(QuestionPack questionPack)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(QuestionPack));
            using (FileStream fs = new FileStream($"QuestionPacks\\{questionPack.id}.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, questionPack);
            }
        }
    }
}

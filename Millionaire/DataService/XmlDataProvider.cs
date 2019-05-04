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
        public Dictionary<int, string> GetQuestionPackList()
        {
            var quizList = new Dictionary<int, string>();
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(packListFilePath);

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                var id = Int32.Parse(node.ChildNodes[0].InnerText);
                var name = node.ChildNodes[1].InnerText;
                quizList.Add(id, name);
            }

            return quizList;
        }

        public bool TryGetQuestionPackList(out Dictionary<int,string> quizList)
        {
            bool isFine;
            try
            {
                quizList = GetQuestionPackList();
                isFine = true;
            }
            catch
            {
                quizList = null;
                isFine = false;
            }
            return isFine;
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
            using (FileStream fs = new FileStream($"QuestionPacks\\{questionPack.packName}.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, questionPack);
            }
        }

        public void SaveQuestionPackList(string packName)
        {

            XElement questionPackDocument;
            
            if (TryGetQuestionPackList(out Dictionary<int, string> questionPackList))
            {
                questionPackDocument = XElement.Load(packListFilePath);

                var newElement = new XElement
                    (
                        "QuestionPackInfo",
                        new XElement("Id", questionPackList.Last().Key + 1),
                        new XElement("Name", packName)
                    );

                questionPackDocument.Add(newElement);
            }
            else
            {
                var newElement = new XElement
                    (
                        "QuestionPackInfo",
                        new XElement("Id", 1),
                        new XElement("Name", packName)
                    );
                questionPackDocument = new XElement("QuestionPackList", newElement);
            }

            questionPackDocument.Save(packListFilePath);
        }   
    }
}

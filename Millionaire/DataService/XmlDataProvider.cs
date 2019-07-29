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
        public readonly string questionsPath;
        public XmlDataProvider(string questionsPath = "QuestionPacks")
        {
            this.questionsPath = questionsPath;
        }

        public QuestionPack GetQuestionPack(string packName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(QuestionPack));
            using (FileStream fs = new FileStream($"QuestionPacks\\{packName}.xml", FileMode.Open))
            {
                return (QuestionPack)formatter.Deserialize(fs);
            }
        }

        public List<QuestionPack> GetQuestionPacksList()
        {
            List<QuestionPack> packList = new List<QuestionPack>();
            QuestionPack _questionPack;
            XmlSerializer formatter = new XmlSerializer(typeof(QuestionPack));
            DirectoryInfo dir = new DirectoryInfo(questionsPath);
            
            foreach (var item in dir.GetFiles())
            {
                using (FileStream fs = new FileStream(item.FullName, FileMode.Open))
                {
                    _questionPack = (QuestionPack)formatter.Deserialize(fs);
                    packList.Add(_questionPack);
                }
            }
            return packList;
        }

        public void SaveQuestionPack(QuestionPack questionPack, IList<string> namelist) //Change name:ist name
        {
            DirectoryInfo dir = new DirectoryInfo(questionsPath);
            string fileName;
            if (CheckIfNameAvaliable(questionPack.packName, namelist))
                fileName = $"{questionPack.packName}";
            else
                fileName = questionPack.packName + " (1)";
            if (!CheckIfNameAvaliable(fileName, namelist))
            {
                int conflictAddition = Convert.ToInt32(String.Concat(fileName.SkipWhile(x => x != '(').Skip(1).TakeWhile(y => y != ')')));
                while (!CheckIfNameAvaliable($"{questionPack.packName} ({conflictAddition})", namelist))
                {
                    conflictAddition++;
                }
                fileName = $"{questionPack.packName} ({conflictAddition})";
            }
            questionPack.packName = fileName;
            try
            {
                questionPack.id = QuestionController.idNameDict.Keys.Max() + 1;
            }
            catch
            {
                questionPack.id = 0;
            }
            
            XmlSerializer formatter = new XmlSerializer(typeof(QuestionPack));
            using (FileStream fs = new FileStream($"{questionsPath}\\{fileName}.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, questionPack);
            }
        }

        public void DeleteQuestionPack(string fileName)
        {
            File.Delete($"{questionsPath}\\{fileName}.xml");
        }

        private bool CheckIfNameAvaliable(string name, IList<string> nameList)
        {
            return !nameList.Contains(name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Millionaire.DataService
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
            if (CheckIfNameAvaliable(questionPack.PackName, namelist))
                fileName = $"{questionPack.PackName}";
            else
                fileName = questionPack.PackName + " (1)";
            if (!CheckIfNameAvaliable(fileName, namelist))
            {
                int conflictAddition = Convert.ToInt32(String.Concat(fileName.SkipWhile(x => x != '(').Skip(1).TakeWhile(y => y != ')')));
                while (!CheckIfNameAvaliable($"{questionPack.PackName} ({conflictAddition})", namelist))
                {
                    conflictAddition++;
                }
                fileName = $"{questionPack.PackName} ({conflictAddition})";
            }
            questionPack.PackName = fileName;
            
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

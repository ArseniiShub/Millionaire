using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Millionaire
{
    public partial class ConstructForm : Form
    {
        string questionsPath = "QuestionPacks";
        IDataProvider DataProvider;
        QuestionPack questionPack = new QuestionPack();

        public ConstructForm(IDataProvider dataProvider)
        {
            DataProvider = dataProvider;
            InitializeComponent();
        }

        private void ConstructForm_Load(object sender, EventArgs e) //Load pack names
        {
            DirectoryInfo dir = new DirectoryInfo(questionsPath);
            XmlSerializer formatter = new XmlSerializer(typeof(QuestionPack));
            foreach (var item in dir.GetFiles())
            {
                using (FileStream fs = new FileStream(item.FullName, FileMode.Open))
                    PackList.Items.Add(((QuestionPack)formatter.Deserialize(fs)).packName);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InitialGroupBox.Visible = false;
            PackNameGroupBox.Visible = true;
        }

        private void NameEnteredButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(InputPackNameTextBox.Text))
            {
                MessageBox.Show("Введите название набора!");
                return;
            }
            foreach (var item in PackList.Items)
                if (item.ToString() == InputPackNameTextBox.Text)
                {
                    MessageBox.Show("Такое имя уже занято!");
                    return;
                }
            questionPack.packName = InputPackNameTextBox.Text;
            PackNameGroupBox.Visible = false;
            QuestionsGroupBox.Visible = true;
            UpdateCounter(CounterLabel1, 0);
        }

        private void NextQuestionButton1_Click(object sender, EventArgs e)
        {
            if(QuestionController.CurrentQuestion.IsLast())
            {
                SaveTextBoxes1();
                ClearTextBoxes(QuestionsGroupBox);
                QuestionsGroupBox.Visible = false;
                ReplacerQuestionGroupBox.Visible = true;
                QuestionController.Set(1, GameRules.replacerNumber);
                UpdateCounter(CounterLabel2, 0);
                return;
            }

            if (IsBoxesEmpty(QuestionsGroupBox))
                MessageBox.Show("Заполните все поля!");
            else
            {
                SaveTextBoxes1();
                ClearTextBoxes(QuestionsGroupBox);
                UpdateCounter(CounterLabel1, 1);
                FillTextBoxes1();
            }
        }

        private void PrevQuestionButton1_Click(object sender, EventArgs e)
        {
            if (QuestionController.CurrentQuestion.IsFirst())
            {
                PackNameGroupBox.Visible = true;
                QuestionsGroupBox.Visible = false;
            }
            else
            {
                ClearTextBoxes(QuestionsGroupBox);
                UpdateCounter(CounterLabel1, -1);
                FillTextBoxes1();
            }
        }

        private void ClearTextBoxes(GroupBox groupBox)
        {
            foreach (var item in groupBox.Controls)
            {
                try
                {
                    ((TextBox)item).Text = null;
                }
                catch { }   
            }
        }

        private void FillTextBoxes1()
        {
            try
            {
                InputQuestionBox.Text = questionPack.questions[QuestionController.CurrentQuestion.index].questionText;
                InputRightAnswerBox.Text = questionPack.questions[QuestionController.CurrentQuestion.index].rightAnswer;
                InputWrongAnswerBox1.Text = questionPack.questions[QuestionController.CurrentQuestion.index].wrongAnswers[0];
                InputWrongAnswerBox2.Text = questionPack.questions[QuestionController.CurrentQuestion.index].wrongAnswers[1];
                InputWrongAnswerBox3.Text = questionPack.questions[QuestionController.CurrentQuestion.index].wrongAnswers[2];
            }
            catch { }
        }

        private void FillTextBoxes2()
        {
            try
            {
                InputRepQuestionBox.Text = questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].questionText;
                InputRepRightAnswerBox.Text = questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].rightAnswer;
                InputRepWrongAnswerBox1.Text = questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].wrongAnswers[0];
                InputRepWrongAnswerBox2.Text = questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].wrongAnswers[1];
                InputRepWrongAnswerBox3.Text = questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].wrongAnswers[2];
            }
            catch { }
        }

        private bool IsBoxesEmpty(GroupBox groupBox)
        {
            foreach (var item in groupBox.Controls)
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(((TextBox)item).Text))
                        return true;
                }
                catch { }
            }
            return false;
        }

        private void SaveTextBoxes1()
        {
            questionPack.questions[QuestionController.CurrentQuestion.index] = new Question();
            questionPack.questions[QuestionController.CurrentQuestion.index].questionText = InputQuestionBox.Text;
            questionPack.questions[QuestionController.CurrentQuestion.index].rightAnswer = InputRightAnswerBox.Text;
            questionPack.questions[QuestionController.CurrentQuestion.index].wrongAnswers[0] = InputWrongAnswerBox1.Text;
            questionPack.questions[QuestionController.CurrentQuestion.index].wrongAnswers[1] = InputWrongAnswerBox2.Text;
            questionPack.questions[QuestionController.CurrentQuestion.index].wrongAnswers[2] = InputWrongAnswerBox3.Text;
        }

        private void SaveTextBoxes2()
        {
            questionPack.replacerQuestions[QuestionController.CurrentQuestion.index] = new Question();
            questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].questionText = InputRepQuestionBox.Text;
            questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].rightAnswer = InputRepRightAnswerBox.Text;
            questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].wrongAnswers[0] = InputRepWrongAnswerBox1.Text;
            questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].wrongAnswers[1] = InputRepWrongAnswerBox2.Text;
            questionPack.replacerQuestions[QuestionController.CurrentQuestion.index].wrongAnswers[2] = InputRepWrongAnswerBox3.Text;
        }

        private void UpdateCounter(Label counter, int currentQuestionNumberChanged)
        {
            QuestionController.CurrentQuestion.index += currentQuestionNumberChanged;
            counter.Text = QuestionController.GetCurrentProgress();
        }

        private void NextQuestionButton2_Click(object sender, EventArgs e)
        {
            if (QuestionController.CurrentQuestion.IsLast())
            {
                questionPack.isCompleted = true;
                DataProvider.SaveQuestionPack(questionPack);
                MessageBox.Show("Сохранено!");
                Close();
            }
            if (IsBoxesEmpty(ReplacerQuestionGroupBox))
                MessageBox.Show("Заполните все поля!");
            else
            {
                SaveTextBoxes2();
                ClearTextBoxes(ReplacerQuestionGroupBox);
                UpdateCounter(CounterLabel2, 1);
                FillTextBoxes2();
            }
        }

        private void PrevQuestionButton2_Click(object sender, EventArgs e)
        {
            if (QuestionController.CurrentQuestion.IsFirst())
            {
                PackNameGroupBox.Visible = false;
                QuestionsGroupBox.Visible = true;
                QuestionController.Set(15, 15);
                FillTextBoxes1();
            }
            else
            {
                SaveTextBoxes2();
                ClearTextBoxes(ReplacerQuestionGroupBox);
                UpdateCounter(CounterLabel2, - 1);
                FillTextBoxes2();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PackList.SelectedItem != null)
            {
                DirectoryInfo dir = new DirectoryInfo(questionsPath);
                XmlSerializer formatter = new XmlSerializer(typeof(QuestionPack));
                string fileToRemove = "";
                foreach (var item in dir.GetFiles())
                {
                    using (FileStream fs = new FileStream(item.FullName, FileMode.Open))
                    {
                        string _packName = ((QuestionPack)formatter.Deserialize(fs)).packName;
                        if (_packName == PackList.SelectedItem.ToString())
                            fileToRemove = item.Name;
                    }
                }
                File.Delete($"{questionsPath}\\{fileToRemove}");
                PackList.Items.RemoveAt(PackList.SelectedIndex);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(); //TODO
        }
    }
}

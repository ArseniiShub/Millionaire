using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Millionaire
{
    public partial class ConstructForm : Form //Visual
    {
        QuestionController questionController;
        public ConstructForm(IDataProvider dataProvider, IGameRules gameRules)
        {
            questionController = new QuestionController(dataProvider, gameRules);
            questionController.RefreshPackNameList();
            InitializeComponent();
            PackList.Items.AddRange(questionController.packNameList.ToArray());
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

            questionController.SavePackName(InputPackNameTextBox.Text);
            PackNameGroupBox.Visible = false;
            QuestionsGroupBox.Visible = true;
            questionController.SetQuestionController(0);
            UpdateCounter(CounterLabel1, 0);
            FillTextBoxes(QuestionsGroupBox);
        }

        private void NextQuestionButton1_Click(object sender, EventArgs e)
        {
            if (IsBoxesEmpty(QuestionsGroupBox))
            {
                //MessageBox.Show("Заполните все поля!");
                //return;
            }
            questionController.SaveCurrentQuestion(new Question(QuestionsGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
            ClearTextBoxes(QuestionsGroupBox);
            if (questionController.CurrentIndex == questionController.GameRules.QuestionNumber - 1)
            {
                QuestionsGroupBox.Visible = false;
                ReplacerQuestionGroupBox.Visible = true;
                questionController.SetQuestionController(0, QuestionType.ReplacerQuestion);
                UpdateCounter(CounterLabel2, 0);
                FillTextBoxes(ReplacerQuestionGroupBox);
            }
            else
            {
                UpdateCounter(CounterLabel1, 1);
                FillTextBoxes(QuestionsGroupBox);
            }
        }

        private void PrevQuestionButton1_Click(object sender, EventArgs e)
        {
            if (questionController.CurrentIndex == 0)
            {
                PackNameGroupBox.Visible = true;
                QuestionsGroupBox.Visible = false;
            }
            else
            {
                questionController.SaveCurrentQuestion(new Question(QuestionsGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
                ClearTextBoxes(QuestionsGroupBox);
                UpdateCounter(CounterLabel1, -1);
                FillTextBoxes(QuestionsGroupBox);
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

        private void FillTextBoxes(GroupBox groupBox)
        {
            if (questionController.GetCurrentQuestion() == null)
                return;

            var source = questionController.GetCurrentQuestion().GetQuestionData().ToList();
            var dest = groupBox.Controls.OfType<TextBox>().ToList();
            for (int i = 0; i < dest.Count; i++)
                dest[i].Text = source[i];
        }

        private bool IsBoxesEmpty(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<TextBox>().Any(x => String.IsNullOrEmpty(x.Text));
        }

        private void UpdateCounter(Label counter, int currentQuestionNumberChanged)
        {
            questionController.CurrentIndex += currentQuestionNumberChanged;
            counter.Text = questionController.CurrentProgress;
        }

        private void NextQuestionButton2_Click(object sender, EventArgs e)
        {
            if (IsBoxesEmpty(ReplacerQuestionGroupBox))
            {
                //MessageBox.Show("Заполните все поля!");
                //return;
            }
            if (questionController.CurrentIndex == questionController.GameRules.ReplacerNumber - 1)
            {
                questionController.SaveCurrentQuestion(new Question(ReplacerQuestionGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
                MessageBox.Show("Сохранено!");
                questionController.SaveFile();
                PackList.Items.Add(questionController.GetPackName());
                Close();
            }
            else
            {
                questionController.SaveCurrentQuestion(new Question(ReplacerQuestionGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
                ClearTextBoxes(ReplacerQuestionGroupBox);
                UpdateCounter(CounterLabel2, 1);
                FillTextBoxes(ReplacerQuestionGroupBox);
            }
        }

        private void PrevQuestionButton2_Click(object sender, EventArgs e)
        {
            questionController.SaveCurrentQuestion(new Question(ReplacerQuestionGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
            if (questionController.CurrentIndex == 0)
            {
                PackNameGroupBox.Visible = false;
                QuestionsGroupBox.Visible = true;
                questionController.SetQuestionController(14, QuestionType.Default);
                FillTextBoxes(QuestionsGroupBox);
            }
            else
            {
                ClearTextBoxes(ReplacerQuestionGroupBox);
                UpdateCounter(CounterLabel2, - 1);
                FillTextBoxes(ReplacerQuestionGroupBox);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PackList.SelectedItem != null)
            {
                questionController.DeleteFile(PackList.SelectedItem.ToString());
                PackList.Items.RemoveAt(PackList.SelectedIndex); 
            }
            else
                MessageBox.Show("Выберите набор для удаления");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PackList.SelectedItem != null)
            {
                questionController.LoadQuestionPack(PackList.SelectedItem.ToString());
                InputPackNameTextBox.Text = questionController.GetPackName();
                InitialGroupBox.Visible = false;
                PackNameGroupBox.Visible = true;
                DeleteButton_Click(sender, e);
            }
            else
                MessageBox.Show("Выберите набор для редактирования");
        }
    }
}

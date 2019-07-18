using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Millionaire
{
    public partial class ConstructForm : Form //Visual
    {
        public ConstructForm()
        {
            InitializeComponent();
        }

        private void ConstructForm_Load(object sender, EventArgs e)
        {
            foreach (var item in QuestionController.idNameDict)
            {
                PackList.Items.Add(item.Value);
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

            QuestionController.SavePackName(InputPackNameTextBox.Text);
            PackNameGroupBox.Visible = false;
            QuestionsGroupBox.Visible = true;
            QuestionController.SetCounter(1, GameRules.questionNumber);
            UpdateCounter(CounterLabel1, 0);
            FillTextBoxes(QuestionsGroupBox, QuestionType.Default);
        }

        private void NextQuestionButton1_Click(object sender, EventArgs e)
        {
            if(QuestionController.CurrentQuestion.IsLast())
            {
                QuestionController.SaveCurrentQuestion(QuestionType.Default, QuestionsGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray());
                ClearTextBoxes(QuestionsGroupBox);
                QuestionsGroupBox.Visible = false;
                ReplacerQuestionGroupBox.Visible = true;
                QuestionController.SetCounter(1, GameRules.replacerNumber);
                UpdateCounter(CounterLabel2, 0);
                FillTextBoxes(ReplacerQuestionGroupBox, QuestionType.ReplacerQuestion);
                return;
            }

            //if (IsBoxesEmpty(QuestionsGroupBox))
            //    MessageBox.Show("Заполните все поля!");
            else
            {
                QuestionController.SaveCurrentQuestion(QuestionType.Default, QuestionsGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray());
                ClearTextBoxes(QuestionsGroupBox);
                UpdateCounter(CounterLabel1, 1);
                FillTextBoxes(QuestionsGroupBox, QuestionType.Default);
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
                FillTextBoxes(QuestionsGroupBox, QuestionType.Default);
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

        private void FillTextBoxes(GroupBox groupBox, QuestionType questionType)
        {
            var temp = QuestionController.GetCurrentQuestion(questionType);
            for (int i = 0; i < groupBox.Controls.OfType<TextBox>().ToArray().Length; i++)
            {
                groupBox.Controls.OfType<TextBox>().ToArray()[i].Text = temp[i];
            }
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

        private void UpdateCounter(Label counter, int currentQuestionNumberChanged)
        {
            QuestionController.CurrentQuestion.index += currentQuestionNumberChanged;
            counter.Text = QuestionController.GetCurrentProgress();
        }

        private void NextQuestionButton2_Click(object sender, EventArgs e)
        {
            if (QuestionController.CurrentQuestion.IsLast())
            {
                MessageBox.Show("Сохранено!");
                QuestionController.SaveFile();
                PackList.Items.Add(QuestionController.GetPackName());
                Close();
            }
            //if (IsBoxesEmpty(ReplacerQuestionGroupBox))
            //    MessageBox.Show("Заполните все поля!");
            else
            {
                QuestionController.SaveCurrentQuestion(QuestionType.ReplacerQuestion, ReplacerQuestionGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray());
                ClearTextBoxes(ReplacerQuestionGroupBox);
                UpdateCounter(CounterLabel2, 1);
                FillTextBoxes(ReplacerQuestionGroupBox, QuestionType.ReplacerQuestion);
            }
        }

        private void PrevQuestionButton2_Click(object sender, EventArgs e)
        {
            if (QuestionController.CurrentQuestion.IsFirst())
            {
                PackNameGroupBox.Visible = false;
                QuestionsGroupBox.Visible = true;
                QuestionController.SetCounter(15, 15);
                FillTextBoxes(QuestionsGroupBox, QuestionType.Default);
            }
            else
            {
                QuestionController.SaveCurrentQuestion(QuestionType.ReplacerQuestion, ReplacerQuestionGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray());
                ClearTextBoxes(ReplacerQuestionGroupBox);
                UpdateCounter(CounterLabel2, - 1);
                FillTextBoxes(ReplacerQuestionGroupBox, QuestionType.ReplacerQuestion);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PackList.SelectedItem != null)
            {
                QuestionController.DeleteFile(PackList.SelectedItem.ToString(), PackList.SelectedIndex);
                PackList.Items.RemoveAt(PackList.SelectedIndex); 
            }
            else
                MessageBox.Show("Выберите набор для удаления");
        }

        private void EditButton_Click(object sender, EventArgs e) //TODO: Move logic
        {
            if (PackList.SelectedItem != null)
            {
                QuestionController.LoadQuestionPack(PackList.SelectedItem.ToString());
                InputPackNameTextBox.Text = QuestionController.GetPackName();
                InitialGroupBox.Visible = false;
                PackNameGroupBox.Visible = true;
                DeleteButton_Click(sender, e);
            }
            else
                MessageBox.Show("Выберите набор для редактирования");
        }
    }
}

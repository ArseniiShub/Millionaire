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
            PackList.Items.AddRange(QuestionController.packNameList.ToArray());
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
            FillTextBoxes(QuestionsGroupBox);
        }

        private void NextQuestionButton1_Click(object sender, EventArgs e)
        {
            if (IsBoxesEmpty(QuestionsGroupBox))
            {
                //MessageBox.Show("Заполните все поля!");
                //return;
            }
            QuestionController.SaveCurrentQuestion(new Question(QuestionsGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
            ClearTextBoxes(QuestionsGroupBox);
            if (QuestionController.CurrentQuestion.IsLast())
            {
                QuestionsGroupBox.Visible = false;
                ReplacerQuestionGroupBox.Visible = true;
                QuestionController.SetCounter(1, GameRules.replacerNumber);
                UpdateCounter(CounterLabel2, 0);
                QuestionController.CurrentQuestionState = QuestionType.ReplacerQuestion;
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
            if (QuestionController.CurrentQuestion.IsFirst())
            {
                PackNameGroupBox.Visible = true;
                QuestionsGroupBox.Visible = false;
            }
            else
            {
                QuestionController.SaveCurrentQuestion(new Question(QuestionsGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
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
            if (QuestionController.GetCurrentQuestion() == null)
                return;

            var source = QuestionController.GetCurrentQuestion().GetQuestionData().ToList();
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
            QuestionController.CurrentQuestion.index += currentQuestionNumberChanged;
            counter.Text = QuestionController.GetCurrentProgress();
        }

        private void NextQuestionButton2_Click(object sender, EventArgs e)
        {
            if (IsBoxesEmpty(ReplacerQuestionGroupBox))
            {
                //MessageBox.Show("Заполните все поля!");
                //return;
            }
            if (QuestionController.CurrentQuestion.IsLast())
            {
                QuestionController.SaveCurrentQuestion(new Question(ReplacerQuestionGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
                MessageBox.Show("Сохранено!");
                QuestionController.SaveFile();
                PackList.Items.Add(QuestionController.GetPackName());
                Close();
            }
            else
            {
                QuestionController.SaveCurrentQuestion(new Question(ReplacerQuestionGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
                ClearTextBoxes(ReplacerQuestionGroupBox);
                UpdateCounter(CounterLabel2, 1);
                FillTextBoxes(ReplacerQuestionGroupBox);
            }
        }

        private void PrevQuestionButton2_Click(object sender, EventArgs e)
        {
            if (QuestionController.CurrentQuestion.IsFirst())
            {
                PackNameGroupBox.Visible = false;
                QuestionsGroupBox.Visible = true;
                QuestionController.SetCounter(15, 15);
                QuestionController.CurrentQuestionState = QuestionType.Default;
                FillTextBoxes(QuestionsGroupBox);
            }
            else
            {
                QuestionController.SaveCurrentQuestion(new Question(ReplacerQuestionGroupBox.Controls.OfType<TextBox>().Select(x => x.Text).ToArray()));
                ClearTextBoxes(ReplacerQuestionGroupBox);
                UpdateCounter(CounterLabel2, - 1);
                FillTextBoxes(ReplacerQuestionGroupBox);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PackList.SelectedItem != null)
            {
                QuestionController.DeleteFile(PackList.SelectedItem.ToString());
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

        private void ConstructForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuestionController.Clear();
        }
    }
}

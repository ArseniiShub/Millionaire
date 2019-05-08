using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Millionaire
{
    public partial class ConstructForm : Form
    {
        IDataProvider DataProvider;
        QuestionPack questionPack;
        public int currentQuestion = 0;

        public ConstructForm(IDataProvider dataProvider)
        {
            DataProvider = dataProvider;
            InitializeComponent();
        }

        private void EnableBoxes(bool b)
        {
            rightAnswerBox.Enabled = b;
            rightAnswerLabel.Enabled = b;
            wrongAnswerLabel.Enabled = b;
            wrongAnswerBox1.Enabled = b;
            wrongAnswerBox2.Enabled = b;
            wrongAnswerBox3.Enabled = b;
            prevButton.Visible = b;
        }

        private void ChangeTopLabelText(string newText)
        {
            TopLabel.Text = newText;
        }

        private bool IsBoxesEmpty()
        {
            return string.IsNullOrWhiteSpace(TopTextBox.Text) || string.IsNullOrWhiteSpace(rightAnswerBox.Text) ||
                string.IsNullOrWhiteSpace(wrongAnswerBox1.Text) || string.IsNullOrWhiteSpace(wrongAnswerBox2.Text) ||
                string.IsNullOrWhiteSpace(wrongAnswerBox3.Text);
        }

        private void SaveTextBoxes()
        {
            questionPack.questions[currentQuestion - 1] = new Question();
            questionPack.questions[currentQuestion - 1].questionText = TopTextBox.Text;
            questionPack.questions[currentQuestion - 1].rightAnswer = rightAnswerBox.Text;
            questionPack.questions[currentQuestion - 1].WrongAnswers[0] = wrongAnswerBox1.Text;
            questionPack.questions[currentQuestion - 1].WrongAnswers[1] = wrongAnswerBox2.Text;
            questionPack.questions[currentQuestion - 1].WrongAnswers[2] = wrongAnswerBox3.Text;
        }

        private void ClearTextBoxes()
        {
            TopTextBox.Text = null;
            rightAnswerBox.Text = null;
            wrongAnswerBox1.Text = null;
            wrongAnswerBox2.Text = null;
            wrongAnswerBox3.Text = null;
        }

        private void UpdateCounter(int currentQuestion)
        {
            counterLabel.Text = $"{currentQuestion}/{GameRules.questionNumber}";
        }

        private void CounterVisibility(bool isVisible)
        {
            counterLabel.Visible = isVisible;
        }

        private void nextButton_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TopTextBox.Text))
                MessageBox.Show("Введите название набора!");
            else
            {
                questionPack = new QuestionPack();
                questionPack.packName = TopTextBox.Text;
                EnableBoxes(true);
                UpdateCounter(++currentQuestion);
                ClearTextBoxes();
                ChangeTopLabelText("Введите вопрос");
                nextButton.Click -= nextButton_Click1;
                nextButton.Click += nextButton_Click2;
            }
        }

        private void nextButton_Click2(object sender, EventArgs e)
        {
            if (currentQuestion < GameRules.questionNumber)
            {
                if (IsBoxesEmpty())
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }
                SaveTextBoxes();
                ClearTextBoxes();
                UpdateCounter(++currentQuestion);
                return;
            }
            SaveTextBoxes();
            UpdateCounter(++currentQuestion);
            ChangeTopLabelText("Введите дополнительный простой вопрос");
            ClearTextBoxes();
            CounterVisibility(false);
            prevButton.Visible = false;
            nextButton.Click -= nextButton_Click2;
            nextButton.Click += nextButton_Click3;
        }

        private void nextButton_Click3(object sender, EventArgs e)
        {
            var strings = new string[] { "", "Введите дополнительный сложный вопрос", "Введите дополнительный вопрос средней сложности" };
            if (currentQuestion < (GameRules.replacerNumber + GameRules.questionNumber))
            {
                if (IsBoxesEmpty())
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }
                SaveTextBoxes();
                ClearTextBoxes();
                ChangeTopLabelText(strings[GameRules.replacerNumber + GameRules.questionNumber - currentQuestion]);
                currentQuestion++;
                return;
            }
            DataProvider.SaveQuestionPackList(questionPack.packName);
            DataProvider.SaveQuestionPack(questionPack);
            MessageBox.Show("Сохранено!");
            this.Close();
        }
        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 1)
            {
                UpdateCounter(--currentQuestion);
                TopTextBox.Text = questionPack.questions[currentQuestion - 1].questionText;
                rightAnswerBox.Text = questionPack.questions[currentQuestion - 1].rightAnswer;
                wrongAnswerBox1.Text = questionPack.questions[currentQuestion - 1].WrongAnswers[0];
                wrongAnswerBox2.Text = questionPack.questions[currentQuestion - 1].WrongAnswers[1];
                wrongAnswerBox3.Text = questionPack.questions[currentQuestion - 1].WrongAnswers[2];
            }
        }
    }
}

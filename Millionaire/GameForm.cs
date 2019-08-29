using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using Millionaire.DataService;
using Millionaire.GameRules;

namespace Millionaire
{
    public partial class GameForm : Form
    {
        QuestionController questionController;
        public GameForm(IDataProvider dataProvider, IGameRules gameRules)
        {
            questionController = new QuestionController(dataProvider, gameRules);
            questionController.RefreshPackNameList();
            InitializeComponent();
            CreateRadio();
            questionController.timer.Tick += new EventHandler(Timer_Tick);
        }

        private void CreateRadio()
        {
            int YPosition = 1;
            foreach (var item in questionController.packNameList)
            {
                RadioButton radioButton = new RadioButton { Text = $"{item}", Location = new Point(10, YPosition++ * 20)};
                choosePackGroupBox.Controls.Add(radioButton);
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            var selectedButton = choosePackGroupBox.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            questionController.LoadQuestionPack(selectedButton.Text);
            if (string.IsNullOrWhiteSpace(playerNameBox.Text))
                return;
            initialPanel.Visible = false;
            gamePanel.Visible = true;
            questionController.SetQuestionController(-1, QuestionType.Default);
            NewQuestion();
        }

        private void NewQuestion()
        {
            if (questionController.CurrentIndex == questionController.GameRules.QuestionNumber)
                Victory();

            questionController.CurrentQuestionState = QuestionType.Default;
            ResetAnswersState();
            UpdateCounter(counterLabel, 1);
            FillQuestionData(answersPanel, questionController.GetCurrentQuestion());
            ShuffleAnswers();
            timerLabel.Text = questionController.GameRules.TimeToAnswer.ToString();
            questionController.TimeLeftToAnswer = questionController.GameRules.TimeToAnswer;
            questionController.timer.Start();
            prizeLabel.Text = $"Текущий выигрыш: {questionController.GameRules.GetCurrentPrize(questionController.CurrentIndex)} рублей";
        }

        private void FillQuestionData(Panel panel, Question question)
        {
            if (questionController.GetCurrentQuestion() != null)
            {
                var questionAsList = question.GetQuestionData().ToList();
                panel.Controls[0].Text = questionAsList[0];
                for (int i = 1; i < panel.Controls.Count; i++)
                {
                    panel.Controls[i].Text = questionAsList[i];
                }
            }
        }

        private void UpdateCounter(Label counter, int currentQuestionNumberChanged)
        {
            questionController.CurrentIndex += currentQuestionNumberChanged;
            counter.Text = questionController.CurrentProgress;
        }

        private void ResetAnswersState()
        {
            foreach (var item in answersPanel.Controls.OfType<Button>())
            {
                item.Visible = true;
                item.Enabled = true;
                item.BackColor = SystemColors.Control;
            }
        }

        async private void AnswerButtonClick(object sender, EventArgs e)
        {
            answersPanel.Enabled = false;
            questionController.timer.Stop();
            if (questionController.IsRightAnswer(((Button)sender).Text))
            {
                ((Button)sender).BackColor = Color.ForestGreen;
                await Task.Delay(3000);
                ((Button)sender).BackColor = Color.LightGray;
                answersPanel.Enabled = true;
                NewQuestion();
            }
            else
            {
                ((Button)sender).BackColor = Color.Red;
                answersPanel.Controls.OfType<Button>().Where(x => questionController.IsRightAnswer(x.Text)).FirstOrDefault().BackColor = Color.ForestGreen;
                await Task.Delay(3000);
                GameOver();
            }     
        }

        private void ShuffleAnswers()
        {
            int answersCount = answersPanel.Controls.OfType<Button>().Count();
            for (int i = 0; i < answersCount; i++)
            {
                int j;
                do
                {
                    j = rand.Next(0, answersCount);
                } while (j == i);

                string temp = answersPanel.Controls.OfType<Button>().ToList()[j].Text;
                answersPanel.Controls.OfType<Button>().ToList()[j].Text = answersPanel.Controls.OfType<Button>().ToList()[i].Text;
                answersPanel.Controls.OfType<Button>().ToList()[i].Text = temp;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void Victory()
        {
            throw new NotImplementedException();
        }

        private void GameOver()
        {
            throw new NotImplementedException();
        }

        private void AddTimeHint_Click(object sender, EventArgs e)
        {
        }

        private void Hint2_Click(object sender, EventArgs e)
        {
        }

        private void Hint1_Click(object sender, EventArgs e)
        {
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = questionController.TimeLeftToAnswer.ToString();
        }
    }
}

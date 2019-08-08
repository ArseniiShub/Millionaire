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

namespace Millionaire
{
    public partial class GameForm : Form
    {
        QuestionController questionController = new QuestionController();
        public GameForm()
        {
            InitializeComponent();
            CreateRadio();
            timer.Interval = 1000;
        }

        private void CreateRadio()
        {
            int YPosition = 1;
            foreach (var item in QuestionController.packNameList)
            {
                RadioButton radioButton = new RadioButton { Text = $"{item}", Location = new Point(10, YPosition++ * 20)};
                choosePackGroupBox.Controls.Add(radioButton);
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
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
            if (questionController.CurrentIndex == GameRules.questionNumber)
                Victory();

            AnswersVisibility(true);
            UpdateCounter(counterLabel, 1);
            FillQuestionData(answersPanel);
            Shuffle();
            timerLabel.Text = GameRules.timeToAnswer.ToString();
            timer.Start();
            prizeLabel.Text = $"Текущий выигрыш: {Prize.GetCurrentPrize(questionController.CurrentIndex)} рублей";
        }

        private void FillQuestionData(Panel panel)
        {
            if (questionController.GetCurrentQuestion() != null)
            {
                var question = questionController.GetCurrentQuestion().GetQuestionData().ToList();
                panel.Controls[0].Text = question[0];
                for (int i = 1; i < panel.Controls.Count; i++)
                {
                    panel.Controls[i].Text = question[i];
                }
            }
        }

        private void UpdateCounter(Label counter, int currentQuestionNumberChanged)
        {
            questionController.CurrentIndex += currentQuestionNumberChanged;
            counter.Text = questionController.CurrentProgress;
        }

        private void AnswersVisibility(bool b)
        {
            foreach (var item in answersPanel.Controls.OfType<Button>())
            {
                item.Visible = b;
            }
        }

        async private void answerButtonClick(object sender, EventArgs e)
        {
            answersPanel.Enabled = false;
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

        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = answersPanel.Controls.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(1, i);

                string tmp = answersPanel.Controls[j].Text;
                answersPanel.Controls[j].Text = answersPanel.Controls[i].Text;
                answersPanel.Controls[i].Text = tmp;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
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

        private void hint4_Click(object sender, EventArgs e)
        {
        }

        private void hint2_Click(object sender, EventArgs e)
        {
        }

        private void hint1_Click(object sender, EventArgs e)
        {
        }

        private void Timer_Tick(object sender, EventArgs e) //QC timer -> обработчик -> здесь
        {
            timerLabel.Text = (Convert.ToInt32(timerLabel.Text) - 1).ToString();
            if (Convert.ToInt32(timerLabel.Text) == 0)
            {
                timer.Stop();
                MessageBox.Show("Время вышло!"); //IInteractiveService
                GameOver();
            }
        }
    }
}

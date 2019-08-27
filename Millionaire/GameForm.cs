﻿using System;
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

            AnswersVisibility(true);
            UpdateCounter(counterLabel, 1);
            FillQuestionData(answersPanel);
            Shuffle();
            timerLabel.Text = questionController.GameRules.TimeToAnswer.ToString();
            questionController.TimeLeftToAnswer = questionController.GameRules.TimeToAnswer;
            questionController.timer.Start();
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

        private void Hint4_Click(object sender, EventArgs e)
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

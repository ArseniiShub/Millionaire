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
        public GameForm(IDataProvider dataProvider)
        {
            InitializeComponent();
            DataProvider = dataProvider;
            CreateRadio();
        }
        public IDataProvider DataProvider { get; set; }

        int currentQuestion = -1;
        QuestionPack questionPack;

        private void CreateRadio()
        {
            if (DataProvider.TryGetQuestionPackList(out Dictionary<int, string> quizList))
            {
                int YPosition = 1;
                foreach (var quizInfo in quizList)
                {
                    RadioButton radioButton = new RadioButton { Text = $"{quizInfo.Value}", Location = new Point(10, YPosition++ * 20), Tag = quizInfo.Key };
                    choosePackGroupBox.Controls.Add(radioButton);
                }
            }
            else
            {
                MessageBox.Show("ErrorCreatingRadio");//Выход?
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var selectedButton = choosePackGroupBox.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            int id = Convert.ToInt32(selectedButton.Tag);
            if (DataProvider.TryGetQuestionPack(out QuestionPack questionPack, id))
                this.questionPack = questionPack;

            if (string.IsNullOrWhiteSpace(playerNameBox.Text))
                return;
            initialPanel.Visible = false;
            gamePanel.Visible = true;
            timerLabel.Text = "60";
            timer.Enabled = true;
            NewQuestion();
        }

        private void NewQuestion()
        {
            AnswersVisibility(true);
            currentQuestion++;
            if (currentQuestion >= questionPack.questions.Length)
                Victory();
            questionNumLabel.Text = $"{currentQuestion + 1} / {questionPack.questions.Length}"; 
            questionLabel.Text = questionPack.questions[currentQuestion].questionText;
            answersPanel.Controls[0].Text = questionPack.questions[currentQuestion].rightAnswer;
            answersPanel.Controls[1].Text = questionPack.questions[currentQuestion].WrongAnswers[0];
            answersPanel.Controls[2].Text = questionPack.questions[currentQuestion].WrongAnswers[1];
            answersPanel.Controls[3].Text = questionPack.questions[currentQuestion].WrongAnswers[2];
            Shuffle();
            timerLabel.Text = "60";
            prizeLabel.Text = $"Текущий выигрыш: {Prize.GetCurrentPrize(currentQuestion)} рублей";
        }

        private void AnswersVisibility(bool b)
        {
            foreach (var item in answersPanel.Controls)
            {
                ((Button)item).Visible = b;
            }
        }

        async private void answerButtonClick(object sender, EventArgs e)
        {
            if (((Button)sender).Text == questionPack.questions[currentQuestion].rightAnswer)
            {
                ((Button)sender).BackColor = Color.ForestGreen;
                await Task.Delay(3000);
                ((Button)sender).BackColor = helpButton.BackColor;
                NewQuestion();
            }
            else if(hint2.Enabled)
                GameOver();
            hint2.Enabled = true;
                
        }

        private void Shuffle()
        {
            Random rand = new Random();

            for (int i = answersPanel.Controls.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                
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

        private void timer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = (Convert.ToInt32(timerLabel.Text) - timer.Interval / 1000).ToString();
            if (timerLabel.Text == "-1")
                GameOver();
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
            hint4.Visible = false;
            timerLabel.Text = (Convert.ToInt32(timerLabel.Text) + 120).ToString();
        }

        private void hint2_Click(object sender, EventArgs e)
        {
            hint2.Enabled = false;
            hint2.Visible = false;
        }

        private void hint1_Click(object sender, EventArgs e)
        {
            hint1.Visible = false;
            for (int i = 0, n = 0; n < 2; i++)
            {
                if (!(answersPanel.Controls[i].Text != questionPack.questions[currentQuestion].rightAnswer))
                    continue;
                answersPanel.Controls[i].Visible = false;
                n++;
            }
        }
    }
}

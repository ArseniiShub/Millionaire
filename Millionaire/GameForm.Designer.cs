using System;

namespace Millionaire
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.initialPanel = new System.Windows.Forms.Panel();
            this.choosePackGroupBox = new System.Windows.Forms.GroupBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.answersPanel = new System.Windows.Forms.Panel();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.hint4 = new System.Windows.Forms.Button();
            this.hint3 = new System.Windows.Forms.Button();
            this.hint2 = new System.Windows.Forms.Button();
            this.hint1 = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.questionNumLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.initialPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.answersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(52, 80);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(101, 13);
            this.playerNameLabel.TabIndex = 1;
            this.playerNameLabel.Text = "Введите ваше имя";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(55, 110);
            this.playerNameBox.MaxLength = 20;
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(154, 20);
            this.playerNameBox.TabIndex = 2;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(356, 396);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(98, 23);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // initialPanel
            // 
            this.initialPanel.Controls.Add(this.choosePackGroupBox);
            this.initialPanel.Controls.Add(this.startGameButton);
            this.initialPanel.Controls.Add(this.playerNameBox);
            this.initialPanel.Controls.Add(this.playerNameLabel);
            this.initialPanel.Location = new System.Drawing.Point(0, 0);
            this.initialPanel.Name = "initialPanel";
            this.initialPanel.Size = new System.Drawing.Size(850, 650);
            this.initialPanel.TabIndex = 5;
            // 
            // choosePackGroupBox
            // 
            this.choosePackGroupBox.Location = new System.Drawing.Point(570, 43);
            this.choosePackGroupBox.Name = "choosePackGroupBox";
            this.choosePackGroupBox.Size = new System.Drawing.Size(205, 331);
            this.choosePackGroupBox.TabIndex = 5;
            this.choosePackGroupBox.TabStop = false;
            this.choosePackGroupBox.Text = "Выберете набор вопросов";
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = global::Millionaire.Properties.Resources.Game;
            this.gamePanel.Controls.Add(this.answersPanel);
            this.gamePanel.Controls.Add(this.helpButton);
            this.gamePanel.Controls.Add(this.hint4);
            this.gamePanel.Controls.Add(this.hint3);
            this.gamePanel.Controls.Add(this.hint2);
            this.gamePanel.Controls.Add(this.hint1);
            this.gamePanel.Controls.Add(this.timerLabel);
            this.gamePanel.Controls.Add(this.prizeLabel);
            this.gamePanel.Controls.Add(this.questionNumLabel);
            this.gamePanel.Controls.Add(this.questionLabel);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(850, 650);
            this.gamePanel.TabIndex = 6;
            this.gamePanel.Visible = false;
            // 
            // answersPanel
            // 
            this.answersPanel.BackColor = System.Drawing.Color.White;
            this.answersPanel.Controls.Add(this.answerButton4);
            this.answersPanel.Controls.Add(this.answerButton2);
            this.answersPanel.Controls.Add(this.answerButton3);
            this.answersPanel.Controls.Add(this.answerButton1);
            this.answersPanel.Location = new System.Drawing.Point(100, 455);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(650, 100);
            this.answersPanel.TabIndex = 6;
            // 
            // answerButton4
            // 
            this.answerButton4.Location = new System.Drawing.Point(368, 59);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(250, 25);
            this.answerButton4.TabIndex = 0;
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.answerButtonClick);
            // 
            // answerButton2
            // 
            this.answerButton2.Location = new System.Drawing.Point(368, 18);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(250, 25);
            this.answerButton2.TabIndex = 0;
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.answerButtonClick);
            // 
            // answerButton3
            // 
            this.answerButton3.Location = new System.Drawing.Point(34, 59);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(250, 25);
            this.answerButton3.TabIndex = 0;
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.answerButtonClick);
            // 
            // answerButton1
            // 
            this.answerButton1.Location = new System.Drawing.Point(34, 18);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(250, 25);
            this.answerButton1.TabIndex = 0;
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.answerButtonClick);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(100, 615);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(25, 25);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // hint4
            // 
            this.hint4.BackgroundImage = global::Millionaire.Properties.Resources.AddTime;
            this.hint4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hint4.Location = new System.Drawing.Point(770, 580);
            this.hint4.Name = "hint4";
            this.hint4.Size = new System.Drawing.Size(60, 60);
            this.hint4.TabIndex = 4;
            this.hint4.UseVisualStyleBackColor = true;
            this.hint4.Click += new System.EventHandler(this.hint4_Click);
            // 
            // hint3
            // 
            this.hint3.BackgroundImage = global::Millionaire.Properties.Resources.Change1;
            this.hint3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hint3.Location = new System.Drawing.Point(690, 580);
            this.hint3.Name = "hint3";
            this.hint3.Size = new System.Drawing.Size(60, 60);
            this.hint3.TabIndex = 4;
            this.hint3.UseVisualStyleBackColor = true;
            // 
            // hint2
            // 
            this.hint2.BackgroundImage = global::Millionaire.Properties.Resources.Mistake;
            this.hint2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hint2.Location = new System.Drawing.Point(610, 580);
            this.hint2.Name = "hint2";
            this.hint2.Size = new System.Drawing.Size(60, 60);
            this.hint2.TabIndex = 4;
            this.hint2.UseVisualStyleBackColor = true;
            this.hint2.Click += new System.EventHandler(this.hint2_Click);
            // 
            // hint1
            // 
            this.hint1.BackgroundImage = global::Millionaire.Properties.Resources._50;
            this.hint1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hint1.Location = new System.Drawing.Point(530, 580);
            this.hint1.Name = "hint1";
            this.hint1.Size = new System.Drawing.Size(60, 60);
            this.hint1.TabIndex = 4;
            this.hint1.UseVisualStyleBackColor = true;
            this.hint1.Click += new System.EventHandler(this.hint1_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(20, 627);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 13);
            this.timerLabel.TabIndex = 3;
            // 
            // prizeLabel
            // 
            this.prizeLabel.Location = new System.Drawing.Point(690, 43);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(140, 50);
            this.prizeLabel.TabIndex = 0;
            this.prizeLabel.Text = "label1";
            // 
            // questionNumLabel
            // 
            this.questionNumLabel.AutoSize = true;
            this.questionNumLabel.Location = new System.Drawing.Point(20, 40);
            this.questionNumLabel.Name = "questionNumLabel";
            this.questionNumLabel.Size = new System.Drawing.Size(35, 13);
            this.questionNumLabel.TabIndex = 0;
            this.questionNumLabel.Text = "label1";
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(20, 380);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(810, 15);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.initialPanel);
            this.Name = "GameForm";
            this.Text = "Who wants to be a Millionaire?";
            this.initialPanel.ResumeLayout(false);
            this.initialPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.answersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Panel initialPanel;
        private System.Windows.Forms.GroupBox choosePackGroupBox;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button hint4;
        private System.Windows.Forms.Button hint3;
        private System.Windows.Forms.Button hint2;
        private System.Windows.Forms.Button hint1;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.Label questionNumLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel answersPanel;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer;
    }
}
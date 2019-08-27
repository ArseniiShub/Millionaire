using System;
using System.Windows.Forms;

namespace Millionaire
{
    partial class ConstructForm
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
            this.PackList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PacksLabel = new System.Windows.Forms.Label();
            this.InitialGroupBox = new System.Windows.Forms.GroupBox();
            this.PackNameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameEnteredButton = new System.Windows.Forms.Button();
            this.InputPackNameTextBox = new System.Windows.Forms.TextBox();
            this.InputPackNameLabel = new System.Windows.Forms.Label();
            this.QuestionsGroupBox = new System.Windows.Forms.GroupBox();
            this.InputQuestionBox = new System.Windows.Forms.TextBox();
            this.InputRightAnswerBox = new System.Windows.Forms.TextBox();
            this.InputWrongAnswerBox1 = new System.Windows.Forms.TextBox();
            this.InputWrongAnswerBox2 = new System.Windows.Forms.TextBox();
            this.InputWrongAnswerBox3 = new System.Windows.Forms.TextBox();
            this.CounterLabel1 = new System.Windows.Forms.Label();
            this.InputWrongAnswersLabel1 = new System.Windows.Forms.Label();
            this.InputRightAnswerLabel1 = new System.Windows.Forms.Label();
            this.InputQuestionLabel1 = new System.Windows.Forms.Label();
            this.NextQuestionButton1 = new System.Windows.Forms.Button();
            this.PrevQuestionButton1 = new System.Windows.Forms.Button();
            this.ReplacerQuestionGroupBox = new System.Windows.Forms.GroupBox();
            this.InputRepQuestionBox = new System.Windows.Forms.TextBox();
            this.InputRepRightAnswerBox = new System.Windows.Forms.TextBox();
            this.InputRepWrongAnswerBox1 = new System.Windows.Forms.TextBox();
            this.InputRepWrongAnswerBox2 = new System.Windows.Forms.TextBox();
            this.InputRepWrongAnswerBox3 = new System.Windows.Forms.TextBox();
            this.CounterLabel2 = new System.Windows.Forms.Label();
            this.WrongAnswersLabel2 = new System.Windows.Forms.Label();
            this.RightAnswerLabel2 = new System.Windows.Forms.Label();
            this.InputQuestionLabel2 = new System.Windows.Forms.Label();
            this.NextQuestionButton2 = new System.Windows.Forms.Button();
            this.PrevQuestionButton2 = new System.Windows.Forms.Button();
            this.InitialGroupBox.SuspendLayout();
            this.PackNameGroupBox.SuspendLayout();
            this.QuestionsGroupBox.SuspendLayout();
            this.ReplacerQuestionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PackList
            // 
            this.PackList.FormattingEnabled = true;
            this.PackList.Location = new System.Drawing.Point(13, 52);
            this.PackList.Name = "PackList";
            this.PackList.Size = new System.Drawing.Size(285, 355);
            this.PackList.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(313, 52);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(155, 36);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(313, 94);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(155, 36);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(313, 136);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(155, 36);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PacksLabel
            // 
            this.PacksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PacksLabel.Location = new System.Drawing.Point(13, 13);
            this.PacksLabel.Name = "PacksLabel";
            this.PacksLabel.Size = new System.Drawing.Size(294, 30);
            this.PacksLabel.TabIndex = 2;
            this.PacksLabel.Text = "Наборы";
            this.PacksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitialGroupBox
            // 
            this.InitialGroupBox.Controls.Add(this.EditButton);
            this.InitialGroupBox.Controls.Add(this.DeleteButton);
            this.InitialGroupBox.Controls.Add(this.AddButton);
            this.InitialGroupBox.Controls.Add(this.PackList);
            this.InitialGroupBox.Controls.Add(this.PacksLabel);
            this.InitialGroupBox.Location = new System.Drawing.Point(0, -6);
            this.InitialGroupBox.Name = "InitialGroupBox";
            this.InitialGroupBox.Size = new System.Drawing.Size(480, 427);
            this.InitialGroupBox.TabIndex = 3;
            this.InitialGroupBox.TabStop = false;
            // 
            // PackNameGroupBox
            // 
            this.PackNameGroupBox.Controls.Add(this.NameEnteredButton);
            this.PackNameGroupBox.Controls.Add(this.InputPackNameTextBox);
            this.PackNameGroupBox.Controls.Add(this.InputPackNameLabel);
            this.PackNameGroupBox.Location = new System.Drawing.Point(0, -6);
            this.PackNameGroupBox.Name = "PackNameGroupBox";
            this.PackNameGroupBox.Size = new System.Drawing.Size(480, 427);
            this.PackNameGroupBox.TabIndex = 3;
            this.PackNameGroupBox.TabStop = false;
            // 
            // NameEnteredButton
            // 
            this.NameEnteredButton.BackgroundImage = global::Millionaire.Properties.Resources.ArrowRight;
            this.NameEnteredButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NameEnteredButton.Location = new System.Drawing.Point(415, 390);
            this.NameEnteredButton.Name = "NameEnteredButton";
            this.NameEnteredButton.Size = new System.Drawing.Size(50, 25);
            this.NameEnteredButton.TabIndex = 2;
            this.NameEnteredButton.UseVisualStyleBackColor = true;
            this.NameEnteredButton.Click += new System.EventHandler(this.NameEnteredButton_Click);
            // 
            // InputPackNameTextBox
            // 
            this.InputPackNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPackNameTextBox.Location = new System.Drawing.Point(147, 64);
            this.InputPackNameTextBox.MaxLength = 25;
            this.InputPackNameTextBox.Name = "InputPackNameTextBox";
            this.InputPackNameTextBox.Size = new System.Drawing.Size(183, 21);
            this.InputPackNameTextBox.TabIndex = 1;
            // 
            // InputPackNameLabel
            // 
            this.InputPackNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputPackNameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPackNameLabel.Location = new System.Drawing.Point(3, 16);
            this.InputPackNameLabel.Name = "InputPackNameLabel";
            this.InputPackNameLabel.Size = new System.Drawing.Size(474, 54);
            this.InputPackNameLabel.TabIndex = 0;
            this.InputPackNameLabel.Text = "Введите название набора";
            this.InputPackNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionsGroupBox
            // 
            this.QuestionsGroupBox.Controls.Add(this.InputQuestionBox);
            this.QuestionsGroupBox.Controls.Add(this.InputRightAnswerBox);
            this.QuestionsGroupBox.Controls.Add(this.InputWrongAnswerBox1);
            this.QuestionsGroupBox.Controls.Add(this.InputWrongAnswerBox2);
            this.QuestionsGroupBox.Controls.Add(this.InputWrongAnswerBox3);
            this.QuestionsGroupBox.Controls.Add(this.CounterLabel1);
            this.QuestionsGroupBox.Controls.Add(this.InputWrongAnswersLabel1);
            this.QuestionsGroupBox.Controls.Add(this.InputRightAnswerLabel1);
            this.QuestionsGroupBox.Controls.Add(this.InputQuestionLabel1);
            this.QuestionsGroupBox.Controls.Add(this.NextQuestionButton1);
            this.QuestionsGroupBox.Controls.Add(this.PrevQuestionButton1);
            this.QuestionsGroupBox.Location = new System.Drawing.Point(0, -6);
            this.QuestionsGroupBox.Name = "QuestionsGroupBox";
            this.QuestionsGroupBox.Size = new System.Drawing.Size(480, 427);
            this.QuestionsGroupBox.TabIndex = 3;
            this.QuestionsGroupBox.TabStop = false;
            this.QuestionsGroupBox.Visible = false;
            // 
            // InputQuestionBox
            // 
            this.InputQuestionBox.Location = new System.Drawing.Point(100, 60);
            this.InputQuestionBox.Name = "InputQuestionBox";
            this.InputQuestionBox.Size = new System.Drawing.Size(300, 20);
            this.InputQuestionBox.TabIndex = 5;
            // 
            // InputRightAnswerBox
            // 
            this.InputRightAnswerBox.Location = new System.Drawing.Point(100, 180);
            this.InputRightAnswerBox.Name = "InputRightAnswerBox";
            this.InputRightAnswerBox.Size = new System.Drawing.Size(300, 20);
            this.InputRightAnswerBox.TabIndex = 6;
            // 
            // InputWrongAnswerBox1
            // 
            this.InputWrongAnswerBox1.Location = new System.Drawing.Point(100, 270);
            this.InputWrongAnswerBox1.Name = "InputWrongAnswerBox1";
            this.InputWrongAnswerBox1.Size = new System.Drawing.Size(300, 20);
            this.InputWrongAnswerBox1.TabIndex = 6;
            // 
            // InputWrongAnswerBox2
            // 
            this.InputWrongAnswerBox2.Location = new System.Drawing.Point(100, 312);
            this.InputWrongAnswerBox2.Name = "InputWrongAnswerBox2";
            this.InputWrongAnswerBox2.Size = new System.Drawing.Size(300, 20);
            this.InputWrongAnswerBox2.TabIndex = 6;
            // 
            // InputWrongAnswerBox3
            // 
            this.InputWrongAnswerBox3.Location = new System.Drawing.Point(100, 355);
            this.InputWrongAnswerBox3.Name = "InputWrongAnswerBox3";
            this.InputWrongAnswerBox3.Size = new System.Drawing.Size(300, 20);
            this.InputWrongAnswerBox3.TabIndex = 6;
            // 
            // CounterLabel1
            // 
            this.CounterLabel1.AutoSize = true;
            this.CounterLabel1.Location = new System.Drawing.Point(36, 401);
            this.CounterLabel1.Name = "CounterLabel1";
            this.CounterLabel1.Size = new System.Drawing.Size(0, 13);
            this.CounterLabel1.TabIndex = 3;
            // 
            // InputWrongAnswersLabel1
            // 
            this.InputWrongAnswersLabel1.Location = new System.Drawing.Point(0, 225);
            this.InputWrongAnswersLabel1.Name = "InputWrongAnswersLabel1";
            this.InputWrongAnswersLabel1.Size = new System.Drawing.Size(480, 15);
            this.InputWrongAnswersLabel1.TabIndex = 4;
            this.InputWrongAnswersLabel1.Text = "Введите 3 неверных варианта ответа";
            this.InputWrongAnswersLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputRightAnswerLabel1
            // 
            this.InputRightAnswerLabel1.Location = new System.Drawing.Point(0, 125);
            this.InputRightAnswerLabel1.Name = "InputRightAnswerLabel1";
            this.InputRightAnswerLabel1.Size = new System.Drawing.Size(480, 15);
            this.InputRightAnswerLabel1.TabIndex = 4;
            this.InputRightAnswerLabel1.Text = "Введите правильный вариант ответа";
            this.InputRightAnswerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputQuestionLabel1
            // 
            this.InputQuestionLabel1.Location = new System.Drawing.Point(0, 25);
            this.InputQuestionLabel1.Name = "InputQuestionLabel1";
            this.InputQuestionLabel1.Size = new System.Drawing.Size(480, 15);
            this.InputQuestionLabel1.TabIndex = 4;
            this.InputQuestionLabel1.Text = "Введите вопрос";
            this.InputQuestionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextQuestionButton1
            // 
            this.NextQuestionButton1.BackgroundImage = global::Millionaire.Properties.Resources.ArrowRight;
            this.NextQuestionButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextQuestionButton1.Location = new System.Drawing.Point(415, 390);
            this.NextQuestionButton1.Name = "NextQuestionButton1";
            this.NextQuestionButton1.Size = new System.Drawing.Size(50, 25);
            this.NextQuestionButton1.TabIndex = 4;
            this.NextQuestionButton1.UseVisualStyleBackColor = true;
            this.NextQuestionButton1.Click += new System.EventHandler(this.NextQuestionButton1_Click);
            // 
            // PrevQuestionButton1
            // 
            this.PrevQuestionButton1.BackgroundImage = global::Millionaire.Properties.Resources.ArrowLeft;
            this.PrevQuestionButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrevQuestionButton1.Location = new System.Drawing.Point(355, 390);
            this.PrevQuestionButton1.Name = "PrevQuestionButton1";
            this.PrevQuestionButton1.Size = new System.Drawing.Size(50, 25);
            this.PrevQuestionButton1.TabIndex = 4;
            this.PrevQuestionButton1.UseVisualStyleBackColor = true;
            this.PrevQuestionButton1.Click += new System.EventHandler(this.PrevQuestionButton1_Click);
            // 
            // ReplacerQuestionGroupBox
            // 
            this.ReplacerQuestionGroupBox.Controls.Add(this.InputRepQuestionBox);
            this.ReplacerQuestionGroupBox.Controls.Add(this.InputRepRightAnswerBox);
            this.ReplacerQuestionGroupBox.Controls.Add(this.InputRepWrongAnswerBox1);
            this.ReplacerQuestionGroupBox.Controls.Add(this.InputRepWrongAnswerBox2);
            this.ReplacerQuestionGroupBox.Controls.Add(this.InputRepWrongAnswerBox3);
            this.ReplacerQuestionGroupBox.Controls.Add(this.CounterLabel2);
            this.ReplacerQuestionGroupBox.Controls.Add(this.WrongAnswersLabel2);
            this.ReplacerQuestionGroupBox.Controls.Add(this.RightAnswerLabel2);
            this.ReplacerQuestionGroupBox.Controls.Add(this.InputQuestionLabel2);
            this.ReplacerQuestionGroupBox.Controls.Add(this.NextQuestionButton2);
            this.ReplacerQuestionGroupBox.Controls.Add(this.PrevQuestionButton2);
            this.ReplacerQuestionGroupBox.Location = new System.Drawing.Point(0, -6);
            this.ReplacerQuestionGroupBox.Name = "ReplacerQuestionGroupBox";
            this.ReplacerQuestionGroupBox.Size = new System.Drawing.Size(480, 427);
            this.ReplacerQuestionGroupBox.TabIndex = 3;
            this.ReplacerQuestionGroupBox.TabStop = false;
            this.ReplacerQuestionGroupBox.Visible = false;
            // 
            // InputRepQuestionBox
            // 
            this.InputRepQuestionBox.Location = new System.Drawing.Point(100, 60);
            this.InputRepQuestionBox.Name = "InputRepQuestionBox";
            this.InputRepQuestionBox.Size = new System.Drawing.Size(300, 20);
            this.InputRepQuestionBox.TabIndex = 5;
            // 
            // InputRepRightAnswerBox
            // 
            this.InputRepRightAnswerBox.Location = new System.Drawing.Point(100, 180);
            this.InputRepRightAnswerBox.Name = "InputRepRightAnswerBox";
            this.InputRepRightAnswerBox.Size = new System.Drawing.Size(300, 20);
            this.InputRepRightAnswerBox.TabIndex = 5;
            // 
            // InputRepWrongAnswerBox1
            // 
            this.InputRepWrongAnswerBox1.Location = new System.Drawing.Point(100, 270);
            this.InputRepWrongAnswerBox1.Name = "InputRepWrongAnswerBox1";
            this.InputRepWrongAnswerBox1.Size = new System.Drawing.Size(300, 20);
            this.InputRepWrongAnswerBox1.TabIndex = 5;
            // 
            // InputRepWrongAnswerBox2
            // 
            this.InputRepWrongAnswerBox2.Location = new System.Drawing.Point(100, 312);
            this.InputRepWrongAnswerBox2.Name = "InputRepWrongAnswerBox2";
            this.InputRepWrongAnswerBox2.Size = new System.Drawing.Size(300, 20);
            this.InputRepWrongAnswerBox2.TabIndex = 5;
            // 
            // InputRepWrongAnswerBox3
            // 
            this.InputRepWrongAnswerBox3.Location = new System.Drawing.Point(100, 355);
            this.InputRepWrongAnswerBox3.Name = "InputRepWrongAnswerBox3";
            this.InputRepWrongAnswerBox3.Size = new System.Drawing.Size(300, 20);
            this.InputRepWrongAnswerBox3.TabIndex = 5;
            // 
            // CounterLabel2
            // 
            this.CounterLabel2.AutoSize = true;
            this.CounterLabel2.Location = new System.Drawing.Point(36, 401);
            this.CounterLabel2.Name = "CounterLabel2";
            this.CounterLabel2.Size = new System.Drawing.Size(0, 13);
            this.CounterLabel2.TabIndex = 3;
            // 
            // WrongAnswersLabel2
            // 
            this.WrongAnswersLabel2.Location = new System.Drawing.Point(0, 225);
            this.WrongAnswersLabel2.Name = "WrongAnswersLabel2";
            this.WrongAnswersLabel2.Size = new System.Drawing.Size(480, 15);
            this.WrongAnswersLabel2.TabIndex = 4;
            this.WrongAnswersLabel2.Text = "Введите 3 неверных варианта ответа";
            this.WrongAnswersLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightAnswerLabel2
            // 
            this.RightAnswerLabel2.Location = new System.Drawing.Point(0, 125);
            this.RightAnswerLabel2.Name = "RightAnswerLabel2";
            this.RightAnswerLabel2.Size = new System.Drawing.Size(480, 15);
            this.RightAnswerLabel2.TabIndex = 4;
            this.RightAnswerLabel2.Text = "Введите правильный вариант ответа";
            this.RightAnswerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputQuestionLabel2
            // 
            this.InputQuestionLabel2.Location = new System.Drawing.Point(0, 25);
            this.InputQuestionLabel2.Name = "InputQuestionLabel2";
            this.InputQuestionLabel2.Size = new System.Drawing.Size(480, 15);
            this.InputQuestionLabel2.TabIndex = 4;
            this.InputQuestionLabel2.Text = "Введите дополнительный простой вопрос";
            this.InputQuestionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextQuestionButton2
            // 
            this.NextQuestionButton2.BackgroundImage = global::Millionaire.Properties.Resources.ArrowRight;
            this.NextQuestionButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextQuestionButton2.Location = new System.Drawing.Point(415, 390);
            this.NextQuestionButton2.Name = "NextQuestionButton2";
            this.NextQuestionButton2.Size = new System.Drawing.Size(50, 25);
            this.NextQuestionButton2.TabIndex = 4;
            this.NextQuestionButton2.UseVisualStyleBackColor = true;
            this.NextQuestionButton2.Click += new System.EventHandler(this.NextQuestionButton2_Click);
            // 
            // PrevQuestionButton2
            // 
            this.PrevQuestionButton2.BackgroundImage = global::Millionaire.Properties.Resources.ArrowLeft;
            this.PrevQuestionButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrevQuestionButton2.Location = new System.Drawing.Point(355, 390);
            this.PrevQuestionButton2.Name = "PrevQuestionButton2";
            this.PrevQuestionButton2.Size = new System.Drawing.Size(50, 25);
            this.PrevQuestionButton2.TabIndex = 4;
            this.PrevQuestionButton2.UseVisualStyleBackColor = true;
            this.PrevQuestionButton2.Click += new System.EventHandler(this.PrevQuestionButton2_Click);
            // 
            // ConstructForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.InitialGroupBox);
            this.Controls.Add(this.PackNameGroupBox);
            this.Controls.Add(this.QuestionsGroupBox);
            this.Controls.Add(this.ReplacerQuestionGroupBox);
            this.Name = "ConstructForm";
            this.InitialGroupBox.ResumeLayout(false);
            this.PackNameGroupBox.ResumeLayout(false);
            this.PackNameGroupBox.PerformLayout();
            this.QuestionsGroupBox.ResumeLayout(false);
            this.QuestionsGroupBox.PerformLayout();
            this.ReplacerQuestionGroupBox.ResumeLayout(false);
            this.ReplacerQuestionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private ListBox PackList;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
        private Label PacksLabel;
        private GroupBox InitialGroupBox;
        private GroupBox PackNameGroupBox;
        private TextBox InputPackNameTextBox;
        private Label InputPackNameLabel;
        private Button NameEnteredButton;
        private GroupBox QuestionsGroupBox;
        private Label InputQuestionLabel1;
        private Label InputRightAnswerLabel1;
        private Label InputWrongAnswersLabel1;
        private TextBox InputQuestionBox;
        private TextBox InputRightAnswerBox;
        private TextBox InputWrongAnswerBox1;
        private TextBox InputWrongAnswerBox2;
        private TextBox InputWrongAnswerBox3;
        private Button PrevQuestionButton1;
        private Button NextQuestionButton1;
        private Label CounterLabel1;
        private GroupBox ReplacerQuestionGroupBox;
        private Label InputQuestionLabel2;
        private Label RightAnswerLabel2;
        private Label WrongAnswersLabel2;
        private TextBox InputRepQuestionBox;
        private TextBox InputRepRightAnswerBox;
        private TextBox InputRepWrongAnswerBox1;
        private TextBox InputRepWrongAnswerBox2;
        private TextBox InputRepWrongAnswerBox3;
        private Button PrevQuestionButton2;
        private Button NextQuestionButton2;
        private Label CounterLabel2;
    }
}
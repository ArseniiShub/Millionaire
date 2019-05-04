namespace Millionaire
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.mainInfoLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.moneyTreeLabel = new System.Windows.Forms.Label();
            this.moneyTreeInfoLabel = new System.Windows.Forms.Label();
            this.hintsLabel = new System.Windows.Forms.Label();
            this.hintLabel1 = new System.Windows.Forms.Label();
            this.hintLabel2 = new System.Windows.Forms.Label();
            this.hintLabel3 = new System.Windows.Forms.Label();
            this.hintLabel4 = new System.Windows.Forms.Label();
            this.hintPicture4 = new System.Windows.Forms.PictureBox();
            this.hintPicture3 = new System.Windows.Forms.PictureBox();
            this.hintPicture2 = new System.Windows.Forms.PictureBox();
            this.hintPicture1 = new System.Windows.Forms.PictureBox();
            this.moneyTreePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hintPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTreePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainInfoLabel
            // 
            this.mainInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainInfoLabel.Location = new System.Drawing.Point(44, 54);
            this.mainInfoLabel.Name = "mainInfoLabel";
            this.mainInfoLabel.Size = new System.Drawing.Size(715, 58);
            this.mainInfoLabel.TabIndex = 0;
            this.mainInfoLabel.Text = resources.GetString("mainInfoLabel.Text");
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(0, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(792, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Описание игры";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // moneyTreeLabel
            // 
            this.moneyTreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyTreeLabel.Location = new System.Drawing.Point(43, 126);
            this.moneyTreeLabel.Name = "moneyTreeLabel";
            this.moneyTreeLabel.Size = new System.Drawing.Size(190, 26);
            this.moneyTreeLabel.TabIndex = 2;
            this.moneyTreeLabel.Text = "\"Денежное дерево\"";
            // 
            // moneyTreeInfoLabel
            // 
            this.moneyTreeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyTreeInfoLabel.Location = new System.Drawing.Point(44, 180);
            this.moneyTreeInfoLabel.Name = "moneyTreeInfoLabel";
            this.moneyTreeInfoLabel.Size = new System.Drawing.Size(187, 310);
            this.moneyTreeInfoLabel.TabIndex = 3;
            this.moneyTreeInfoLabel.Text = resources.GetString("moneyTreeInfoLabel.Text");
            // 
            // hintsLabel
            // 
            this.hintsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintsLabel.Location = new System.Drawing.Point(566, 126);
            this.hintsLabel.Name = "hintsLabel";
            this.hintsLabel.Size = new System.Drawing.Size(114, 23);
            this.hintsLabel.TabIndex = 5;
            this.hintsLabel.Text = "Подсказки";
            // 
            // hintLabel1
            // 
            this.hintLabel1.Location = new System.Drawing.Point(570, 180);
            this.hintLabel1.Name = "hintLabel1";
            this.hintLabel1.Size = new System.Drawing.Size(189, 50);
            this.hintLabel1.TabIndex = 6;
            this.hintLabel1.Text = "50 на 50 - Компьютер убирает 2 неверных варианта ответа";
            // 
            // hintLabel2
            // 
            this.hintLabel2.Location = new System.Drawing.Point(570, 250);
            this.hintLabel2.Name = "hintLabel2";
            this.hintLabel2.Size = new System.Drawing.Size(165, 100);
            this.hintLabel2.TabIndex = 7;
            this.hintLabel2.Text = "Право на ошибку - игрок может дать два ответа на заданный вопрос. Если первый отв" +
    "ет игрока оказался правильным, подсказка всё равно считается использованной. ";
            // 
            // hintLabel3
            // 
            this.hintLabel3.Location = new System.Drawing.Point(570, 370);
            this.hintLabel3.Name = "hintLabel3";
            this.hintLabel3.Size = new System.Drawing.Size(150, 50);
            this.hintLabel3.TabIndex = 8;
            this.hintLabel3.Text = "Замена вопроса - меняет вопрос на другой такой же сложности или выше";
            // 
            // hintLabel4
            // 
            this.hintLabel4.Location = new System.Drawing.Point(570, 440);
            this.hintLabel4.Name = "hintLabel4";
            this.hintLabel4.Size = new System.Drawing.Size(140, 45);
            this.hintLabel4.TabIndex = 9;
            this.hintLabel4.Text = "Дополниетльное время - добавляет 5 минут на ответ";
            // 
            // hintPicture4
            // 
            this.hintPicture4.BackgroundImage = global::Millionaire.Properties.Resources.AddTime;
            this.hintPicture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hintPicture4.Location = new System.Drawing.Point(504, 440);
            this.hintPicture4.Name = "hintPicture4";
            this.hintPicture4.Size = new System.Drawing.Size(60, 60);
            this.hintPicture4.TabIndex = 10;
            this.hintPicture4.TabStop = false;
            // 
            // hintPicture3
            // 
            this.hintPicture3.BackgroundImage = global::Millionaire.Properties.Resources.Change1;
            this.hintPicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hintPicture3.Location = new System.Drawing.Point(504, 370);
            this.hintPicture3.Name = "hintPicture3";
            this.hintPicture3.Size = new System.Drawing.Size(60, 60);
            this.hintPicture3.TabIndex = 10;
            this.hintPicture3.TabStop = false;
            // 
            // hintPicture2
            // 
            this.hintPicture2.BackgroundImage = global::Millionaire.Properties.Resources.Mistake;
            this.hintPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hintPicture2.Location = new System.Drawing.Point(504, 250);
            this.hintPicture2.Name = "hintPicture2";
            this.hintPicture2.Size = new System.Drawing.Size(60, 60);
            this.hintPicture2.TabIndex = 10;
            this.hintPicture2.TabStop = false;
            // 
            // hintPicture1
            // 
            this.hintPicture1.BackgroundImage = global::Millionaire.Properties.Resources._50;
            this.hintPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hintPicture1.Location = new System.Drawing.Point(504, 180);
            this.hintPicture1.Name = "hintPicture1";
            this.hintPicture1.Size = new System.Drawing.Size(60, 60);
            this.hintPicture1.TabIndex = 10;
            this.hintPicture1.TabStop = false;
            // 
            // moneyTreePicture
            // 
            this.moneyTreePicture.Image = global::Millionaire.Properties.Resources.MoneyTree;
            this.moneyTreePicture.Location = new System.Drawing.Point(244, 126);
            this.moneyTreePicture.Name = "moneyTreePicture";
            this.moneyTreePicture.Size = new System.Drawing.Size(198, 386);
            this.moneyTreePicture.TabIndex = 4;
            this.moneyTreePicture.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 542);
            this.Controls.Add(this.hintPicture4);
            this.Controls.Add(this.hintPicture3);
            this.Controls.Add(this.hintPicture2);
            this.Controls.Add(this.hintPicture1);
            this.Controls.Add(this.hintLabel4);
            this.Controls.Add(this.hintLabel3);
            this.Controls.Add(this.hintLabel2);
            this.Controls.Add(this.hintLabel1);
            this.Controls.Add(this.hintsLabel);
            this.Controls.Add(this.moneyTreePicture);
            this.Controls.Add(this.moneyTreeInfoLabel);
            this.Controls.Add(this.moneyTreeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mainInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.Text = "Правила";
            ((System.ComponentModel.ISupportInitialize)(this.hintPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hintPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTreePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainInfoLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label moneyTreeLabel;
        private System.Windows.Forms.Label moneyTreeInfoLabel;
        private System.Windows.Forms.PictureBox moneyTreePicture;
        private System.Windows.Forms.Label hintsLabel;
        private System.Windows.Forms.Label hintLabel1;
        private System.Windows.Forms.Label hintLabel2;
        private System.Windows.Forms.Label hintLabel3;
        private System.Windows.Forms.Label hintLabel4;
        private System.Windows.Forms.PictureBox hintPicture1;
        private System.Windows.Forms.PictureBox hintPicture2;
        private System.Windows.Forms.PictureBox hintPicture3;
        private System.Windows.Forms.PictureBox hintPicture4;
    }
}
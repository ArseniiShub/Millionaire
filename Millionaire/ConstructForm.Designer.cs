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
            this.counterLabel = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.wrongAnswerBox2 = new System.Windows.Forms.TextBox();
            this.wrongAnswerBox1 = new System.Windows.Forms.TextBox();
            this.wrongAnswerBox3 = new System.Windows.Forms.TextBox();
            this.wrongAnswerLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rightAnswerLabel = new System.Windows.Forms.Label();
            this.rightAnswerBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TopTextBox = new System.Windows.Forms.TextBox();
            this.TopLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(8, 17);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(0, 13);
            this.counterLabel.TabIndex = 1;
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prevButton.BackgroundImage = global::Millionaire.Properties.Resources.ArrowLeft;
            this.prevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prevButton.Location = new System.Drawing.Point(380, 15);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(40, 22);
            this.prevButton.TabIndex = 6;
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Visible = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nextButton.BackgroundImage = global::Millionaire.Properties.Resources.ArrowRight;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextButton.Location = new System.Drawing.Point(420, 15);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(40, 22);
            this.nextButton.TabIndex = 7;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click1);
            // 
            // wrongAnswerBox2
            // 
            this.wrongAnswerBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongAnswerBox2.Enabled = false;
            this.wrongAnswerBox2.Location = new System.Drawing.Point(15, 80);
            this.wrongAnswerBox2.Name = "wrongAnswerBox2";
            this.wrongAnswerBox2.Size = new System.Drawing.Size(445, 20);
            this.wrongAnswerBox2.TabIndex = 4;
            // 
            // wrongAnswerBox1
            // 
            this.wrongAnswerBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongAnswerBox1.Enabled = false;
            this.wrongAnswerBox1.Location = new System.Drawing.Point(15, 40);
            this.wrongAnswerBox1.Name = "wrongAnswerBox1";
            this.wrongAnswerBox1.Size = new System.Drawing.Size(445, 20);
            this.wrongAnswerBox1.TabIndex = 3;
            // 
            // wrongAnswerBox3
            // 
            this.wrongAnswerBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongAnswerBox3.Enabled = false;
            this.wrongAnswerBox3.Location = new System.Drawing.Point(15, 120);
            this.wrongAnswerBox3.Name = "wrongAnswerBox3";
            this.wrongAnswerBox3.Size = new System.Drawing.Size(445, 20);
            this.wrongAnswerBox3.TabIndex = 5;
            // 
            // wrongAnswerLabel
            // 
            this.wrongAnswerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.wrongAnswerLabel.Enabled = false;
            this.wrongAnswerLabel.Location = new System.Drawing.Point(3, 16);
            this.wrongAnswerLabel.Name = "wrongAnswerLabel";
            this.wrongAnswerLabel.Size = new System.Drawing.Size(470, 15);
            this.wrongAnswerLabel.TabIndex = 0;
            this.wrongAnswerLabel.Text = "Другие варианты ответа";
            this.wrongAnswerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.wrongAnswerBox1);
            this.groupBox3.Controls.Add(this.wrongAnswerBox3);
            this.groupBox3.Controls.Add(this.wrongAnswerBox2);
            this.groupBox3.Controls.Add(this.wrongAnswerLabel);
            this.groupBox3.Location = new System.Drawing.Point(4, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 160);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.nextButton);
            this.groupBox4.Controls.Add(this.counterLabel);
            this.groupBox4.Controls.Add(this.prevButton);
            this.groupBox4.Location = new System.Drawing.Point(4, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 45);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // rightAnswerLabel
            // 
            this.rightAnswerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightAnswerLabel.Enabled = false;
            this.rightAnswerLabel.Location = new System.Drawing.Point(3, 16);
            this.rightAnswerLabel.Name = "rightAnswerLabel";
            this.rightAnswerLabel.Size = new System.Drawing.Size(470, 15);
            this.rightAnswerLabel.TabIndex = 0;
            this.rightAnswerLabel.Text = "Правильный вариант ответа";
            this.rightAnswerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rightAnswerBox
            // 
            this.rightAnswerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightAnswerBox.Enabled = false;
            this.rightAnswerBox.Location = new System.Drawing.Point(15, 40);
            this.rightAnswerBox.Name = "rightAnswerBox";
            this.rightAnswerBox.Size = new System.Drawing.Size(445, 20);
            this.rightAnswerBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rightAnswerBox);
            this.groupBox2.Controls.Add(this.rightAnswerLabel);
            this.groupBox2.Location = new System.Drawing.Point(4, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // TopTextBox
            // 
            this.TopTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopTextBox.Location = new System.Drawing.Point(15, 40);
            this.TopTextBox.Name = "TopTextBox";
            this.TopTextBox.Size = new System.Drawing.Size(445, 20);
            this.TopTextBox.TabIndex = 1;
            // 
            // TopLabel
            // 
            this.TopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopLabel.Location = new System.Drawing.Point(3, 16);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(470, 15);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Название набора";
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TopLabel);
            this.groupBox1.Controls.Add(this.TopTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // ConstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConstructForm";
            this.Text = "ConstructForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox wrongAnswerBox2;
        private System.Windows.Forms.TextBox wrongAnswerBox1;
        private System.Windows.Forms.TextBox wrongAnswerBox3;
        private System.Windows.Forms.Label wrongAnswerLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label rightAnswerLabel;
        private System.Windows.Forms.TextBox rightAnswerBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TopTextBox;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.GroupBox groupBox1;    }
}
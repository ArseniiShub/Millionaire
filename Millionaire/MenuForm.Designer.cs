namespace Millionaire
{
    partial class MenuForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.constructButton = new System.Windows.Forms.Button();
            this.recordsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(73, 350);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 40);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // constructButton
            // 
            this.constructButton.Location = new System.Drawing.Point(73, 410);
            this.constructButton.Name = "constructButton";
            this.constructButton.Size = new System.Drawing.Size(200, 40);
            this.constructButton.TabIndex = 1;
            this.constructButton.Text = "Конструктор";
            this.constructButton.UseVisualStyleBackColor = true;
            this.constructButton.Click += new System.EventHandler(this.ConstructButton_Click);
            // 
            // recordsButton
            // 
            this.recordsButton.Location = new System.Drawing.Point(73, 470);
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.Size = new System.Drawing.Size(200, 40);
            this.recordsButton.TabIndex = 2;
            this.recordsButton.Text = "Рекорды";
            this.recordsButton.UseVisualStyleBackColor = true;
            this.recordsButton.Click += new System.EventHandler(this.RecordsButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(73, 530);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(200, 40);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Правила";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(73, 590);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Millionaire.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(342, 661);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.recordsButton);
            this.Controls.Add(this.constructButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Who wants to be a Millionaire?";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button constructButton;
        private System.Windows.Forms.Button recordsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
    }
}


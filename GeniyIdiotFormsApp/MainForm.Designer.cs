namespace GeniyIdiotFormsApp
{
    partial class MainForm
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
            this.quetionNumberLabel = new System.Windows.Forms.Label();
            this.quetionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рестартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quetionNumberLabel
            // 
            this.quetionNumberLabel.AutoSize = true;
            this.quetionNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quetionNumberLabel.Location = new System.Drawing.Point(15, 56);
            this.quetionNumberLabel.Name = "quetionNumberLabel";
            this.quetionNumberLabel.Size = new System.Drawing.Size(78, 19);
            this.quetionNumberLabel.TabIndex = 0;
            this.quetionNumberLabel.Text = "Вопрос №";
            // 
            // quetionTextLabel
            // 
            this.quetionTextLabel.AutoSize = true;
            this.quetionTextLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quetionTextLabel.Location = new System.Drawing.Point(15, 84);
            this.quetionTextLabel.Name = "quetionTextLabel";
            this.quetionTextLabel.Size = new System.Drawing.Size(103, 19);
            this.quetionTextLabel.TabIndex = 1;
            this.quetionTextLabel.Text = "текст вопроса";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(19, 117);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(658, 20);
            this.userAnswerTextBox.TabIndex = 2;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(19, 152);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(658, 45);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рестартToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // рестартToolStripMenuItem
            // 
            this.рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            this.рестартToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рестартToolStripMenuItem.Text = "Рестарт";
            this.рестартToolStripMenuItem.Click += new System.EventHandler(this.рестартToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 209);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.quetionTextLabel);
            this.Controls.Add(this.quetionNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.nextButton_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quetionNumberLabel;
        private System.Windows.Forms.Label quetionTextLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рестартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}


namespace GeniyIdiotFormsApp
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // quetionNumberLabel
            // 
            this.quetionNumberLabel.AutoSize = true;
            this.quetionNumberLabel.Location = new System.Drawing.Point(13, 13);
            this.quetionNumberLabel.Name = "quetionNumberLabel";
            this.quetionNumberLabel.Size = new System.Drawing.Size(58, 13);
            this.quetionNumberLabel.TabIndex = 0;
            this.quetionNumberLabel.Text = "Вопрос №";
            // 
            // quetionTextLabel
            // 
            this.quetionTextLabel.AutoSize = true;
            this.quetionTextLabel.Location = new System.Drawing.Point(16, 48);
            this.quetionTextLabel.Name = "quetionTextLabel";
            this.quetionTextLabel.Size = new System.Drawing.Size(80, 13);
            this.quetionTextLabel.TabIndex = 1;
            this.quetionTextLabel.Text = "текст вопроса";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(19, 85);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(447, 20);
            this.userAnswerTextBox.TabIndex = 2;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(19, 111);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(447, 45);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 168);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.quetionTextLabel);
            this.Controls.Add(this.quetionNumberLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quetionNumberLabel;
        private System.Windows.Forms.Label quetionTextLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Button nextButton;
    }
}



namespace signuo
{
    partial class Quiz
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.AnswerButton1 = new System.Windows.Forms.Button();
            this.AnswerButton2 = new System.Windows.Forms.Button();
            this.AnswerButton3 = new System.Windows.Forms.Button();
            this.AnswerButton4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Location = new System.Drawing.Point(34, 128);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(627, 80);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Question";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(541, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 107);
            this.button1.TabIndex = 5;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SubmitBt);
            // 
            // NextBtn
            // 
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextBtn.Location = new System.Drawing.Point(667, 304);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(101, 107);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextButton);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Location = new System.Drawing.Point(666, 170);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(101, 38);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "score";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerButton1
            // 
            this.AnswerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton1.Location = new System.Drawing.Point(33, 304);
            this.AnswerButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnswerButton1.Name = "AnswerButton1";
            this.AnswerButton1.Size = new System.Drawing.Size(120, 107);
            this.AnswerButton1.TabIndex = 8;
            this.AnswerButton1.Text = "Answer1";
            this.AnswerButton1.UseVisualStyleBackColor = true;
            // 
            // AnswerButton2
            // 
            this.AnswerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton2.Location = new System.Drawing.Point(160, 304);
            this.AnswerButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnswerButton2.Name = "AnswerButton2";
            this.AnswerButton2.Size = new System.Drawing.Size(120, 107);
            this.AnswerButton2.TabIndex = 9;
            this.AnswerButton2.Text = "Answer2";
            this.AnswerButton2.UseVisualStyleBackColor = true;
            // 
            // AnswerButton3
            // 
            this.AnswerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton3.Location = new System.Drawing.Point(287, 304);
            this.AnswerButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnswerButton3.Name = "AnswerButton3";
            this.AnswerButton3.Size = new System.Drawing.Size(120, 107);
            this.AnswerButton3.TabIndex = 10;
            this.AnswerButton3.Text = "Answer3";
            this.AnswerButton3.UseVisualStyleBackColor = true;
            // 
            // AnswerButton4
            // 
            this.AnswerButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton4.Location = new System.Drawing.Point(414, 304);
            this.AnswerButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnswerButton4.Name = "AnswerButton4";
            this.AnswerButton4.Size = new System.Drawing.Size(120, 107);
            this.AnswerButton4.TabIndex = 11;
            this.AnswerButton4.Text = "Answer4";
            this.AnswerButton4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(50)))), ((int)(((byte)(133)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 419);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(33, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(734, 87);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "IT\'S QUIZ TIME!!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(688, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Score";
            // 
            // Quiz
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AnswerButton4);
            this.Controls.Add(this.AnswerButton3);
            this.Controls.Add(this.AnswerButton2);
            this.Controls.Add(this.AnswerButton1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz";
            this.Text = "QuizzTime";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button AnswerButton1;
        private System.Windows.Forms.Button AnswerButton2;
        private System.Windows.Forms.Button AnswerButton3;
        private System.Windows.Forms.Button AnswerButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
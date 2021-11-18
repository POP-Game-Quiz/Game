
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SubmitBtnn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ColorSwich = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.ScoreDisplay = new System.Windows.Forms.Label();
            this.timeDisplay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSwich)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(175, 199);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(175, 258);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(506, 199);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(506, 258);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(117, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuestionLabel.Location = new System.Drawing.Point(146, 119);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(574, 74);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Question";
            // 
            // SubmitBtnn
            // 
            this.SubmitBtnn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitBtnn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubmitBtnn.Location = new System.Drawing.Point(550, 10);
            this.SubmitBtnn.Name = "SubmitBtnn";
            this.SubmitBtnn.Size = new System.Drawing.Size(94, 66);
            this.SubmitBtnn.TabIndex = 5;
            this.SubmitBtnn.Text = "Submit";
            this.SubmitBtnn.UseVisualStyleBackColor = true;
            this.SubmitBtnn.Click += new System.EventHandler(this.SubmitBt);
            // 
            // NextBtn
            // 
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextBtn.Location = new System.Drawing.Point(650, 10);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(94, 66);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextButton);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(459, 33);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(44, 20);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "score";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Location = new System.Drawing.Point(756, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(32, 31);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ColorSwich
            // 
            this.ColorSwich.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ColorSwich.LargeChange = 1;
            this.ColorSwich.Location = new System.Drawing.Point(118, 12);
            this.ColorSwich.Maximum = 1;
            this.ColorSwich.Name = "ColorSwich";
            this.ColorSwich.Size = new System.Drawing.Size(42, 56);
            this.ColorSwich.TabIndex = 10;
            this.ColorSwich.Scroll += new System.EventHandler(this.ColorSwitch);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 450);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.timerLabel);
            this.panel2.Controls.Add(this.ScoreDisplay);
            this.panel2.Controls.Add(this.NextBtn);
            this.panel2.Controls.Add(this.SubmitBtnn);
            this.panel2.Controls.Add(this.timeDisplay);
            this.panel2.Controls.Add(this.ScoreLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 81);
            this.panel2.TabIndex = 12;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(73, 27);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(119, 28);
            this.timerLabel.TabIndex = 10;
            this.timerLabel.Text = "20 Seconds";
            // 
            // ScoreDisplay
            // 
            this.ScoreDisplay.AutoSize = true;
            this.ScoreDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreDisplay.Location = new System.Drawing.Point(384, 27);
            this.ScoreDisplay.Name = "ScoreDisplay";
            this.ScoreDisplay.Size = new System.Drawing.Size(69, 28);
            this.ScoreDisplay.TabIndex = 8;
            this.ScoreDisplay.Text = "Score:";
            // 
            // timeDisplay
            // 
            this.timeDisplay.AutoSize = true;
            this.timeDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeDisplay.Location = new System.Drawing.Point(3, 26);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(64, 28);
            this.timeDisplay.TabIndex = 9;
            this.timeDisplay.Text = "Time:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Location = new System.Drawing.Point(343, 333);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 20);
            this.FeedbackLabel.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "end";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColorSwich);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ColorSwich)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button SubmitBtnn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TrackBar ColorSwich;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Label ScoreDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Button button1;
    }
}
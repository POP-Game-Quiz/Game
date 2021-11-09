
namespace signuo
{
    partial class LogForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.SubmitButton1 = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ColorSwich = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelFeedback = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ColorSwich)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton1
            // 
            resources.ApplyResources(this.SubmitButton1, "SubmitButton1");
            this.SubmitButton1.Name = "SubmitButton1";
            this.SubmitButton1.UseVisualStyleBackColor = true;
            this.SubmitButton1.Click += new System.EventHandler(this.Submit);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.UserNameTextBox, "UserNameTextBox");
            this.UserNameTextBox.Name = "UserNameTextBox";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ConfirmPasswordTextbox
            // 
            this.ConfirmPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.ConfirmPasswordTextbox, "ConfirmPasswordTextbox");
            this.ConfirmPasswordTextbox.Name = "ConfirmPasswordTextbox";
            // 
            // ConfirmPasswordLabel
            // 
            resources.ApplyResources(this.ConfirmPasswordLabel, "ConfirmPasswordLabel");
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            // 
            // ColorSwich
            // 
            this.ColorSwich.LargeChange = 1;
            resources.ApplyResources(this.ColorSwich, "ColorSwich");
            this.ColorSwich.Maximum = 1;
            this.ColorSwich.Name = "ColorSwich";
            this.ColorSwich.Scroll += new System.EventHandler(this.ColorSwitch);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelFeedback);
            this.panel2.Controls.Add(this.SubmitButton1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // LabelFeedback
            // 
            resources.ApplyResources(this.LabelFeedback, "LabelFeedback");
            this.LabelFeedback.Name = "LabelFeedback";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LoginButton);
            // 
            // ExitBtn
            // 
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SignUpButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // SignUpButton
            // 
            resources.ApplyResources(this.SignUpButton, "SignUpButton");
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // LogForm
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColorSwich);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.ConfirmPasswordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogForm";
            ((System.ComponentModel.ISupportInitialize)(this.ColorSwich)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ConfirmPasswordTextbox;
        public System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TrackBar ColorSwich;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label LabelFeedback;
    }
}


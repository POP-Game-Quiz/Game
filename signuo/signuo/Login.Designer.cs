
namespace signuo
{
    partial class Login
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
            this.SubmitButton1 = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.SubmitButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton1.Location = new System.Drawing.Point(686, 396);
            this.SubmitButton1.Name = "button1";
            this.SubmitButton1.Size = new System.Drawing.Size(102, 42);
            this.SubmitButton1.TabIndex = 0;
            this.SubmitButton1.Text = "submit";
            this.SubmitButton1.UseVisualStyleBackColor = true;
            this.SubmitButton1.Click += new System.EventHandler(this.Submit);
            // 
            // textBox1
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(364, 80);
            this.UserNameTextBox.Name = "textBox1";
            this.UserNameTextBox.Size = new System.Drawing.Size(227, 27);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // textBox2
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(364, 126);
            this.PasswordTextBox.Name = "textBox2";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(227, 27);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(606, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LoginButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // textBox3
            // 
            this.ConfirmPasswordTextbox.Location = new System.Drawing.Point(364, 170);
            this.ConfirmPasswordTextbox.Name = "textBox3";
            this.ConfirmPasswordTextbox.PasswordChar = '*';
            this.ConfirmPasswordTextbox.Size = new System.Drawing.Size(227, 27);
            this.ConfirmPasswordTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(230, 177);
            this.ConfirmPasswordLabel.Name = "label3";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(127, 20);
            this.ConfirmPasswordLabel.TabIndex = 7;
            this.ConfirmPasswordLabel.Text = "confirm password";
            // 
            // button3
            // 
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpButton.Location = new System.Drawing.Point(606, 113);
            this.SignUpButton.Name = "button3";
            this.SignUpButton.Size = new System.Drawing.Size(94, 37);
            this.SignUpButton.TabIndex = 8;
            this.SignUpButton.Text = "sign up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.ConfirmPasswordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.SubmitButton1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ConfirmPasswordTextbox;
        public System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Button SignUpButton;
    }
}


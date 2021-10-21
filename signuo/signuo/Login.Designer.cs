
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.Location = new System.Drawing.Point(686, 396);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(102, 42);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.Submit);
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(364, 80);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(227, 27);
            this.UserNameInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(364, 126);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(227, 27);
            this.PasswordInput.TabIndex = 2;
            // 
            // LogInButton
            // 
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInButton.Location = new System.Drawing.Point(606, 70);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(94, 37);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "Login";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(229, 87);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(73, 20);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(229, 133);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(72, 20);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "password";
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(364, 170);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.PasswordChar = '*';
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(227, 27);
            this.ConfirmPasswordInput.TabIndex = 6;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(230, 177);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(127, 20);
            this.ConfirmPasswordLabel.TabIndex = 7;
            this.ConfirmPasswordLabel.Text = "confirm password";
            // 
            // SignUpButton
            // 
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpButton.Location = new System.Drawing.Point(606, 113);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(182, 37);
            this.SignUpButton.TabIndex = 8;
            this.SignUpButton.Text = "Sign Up";
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
            this.Controls.Add(this.ConfirmPasswordInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        public System.Windows.Forms.TextBox ConfirmPasswordInput;
        public System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Button SignUpButton;
    }
}


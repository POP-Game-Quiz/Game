
namespace signuo
{
    partial class BadgesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadgesForm));
            this.CongratsLable = new System.Windows.Forms.Label();
            this.CongratsMessage = new System.Windows.Forms.Label();
            this.pictureBoxBronze = new System.Windows.Forms.PictureBox();
            this.pictureBoxSilver = new System.Windows.Forms.PictureBox();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBronze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            this.SuspendLayout();
            // 
            // CongratsLable
            // 
            this.CongratsLable.AutoSize = true;
            this.CongratsLable.BackColor = System.Drawing.Color.Transparent;
            this.CongratsLable.Font = new System.Drawing.Font("Elephant", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CongratsLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CongratsLable.Location = new System.Drawing.Point(224, 75);
            this.CongratsLable.Name = "CongratsLable";
            this.CongratsLable.Size = new System.Drawing.Size(493, 64);
            this.CongratsLable.TabIndex = 0;
            this.CongratsLable.Text = "Congratulations !";
            // 
            // CongratsMessage
            // 
            this.CongratsMessage.AutoSize = true;
            this.CongratsMessage.BackColor = System.Drawing.Color.Transparent;
            this.CongratsMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CongratsMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CongratsMessage.Location = new System.Drawing.Point(112, 168);
            this.CongratsMessage.Name = "CongratsMessage";
            this.CongratsMessage.Size = new System.Drawing.Size(728, 50);
            this.CongratsMessage.TabIndex = 1;
            this.CongratsMessage.Text = "you have earned a Bronze Award ";
            // 
            // pictureBoxBronze
            // 
            this.pictureBoxBronze.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBronze.BackgroundImage = global::signuo.Properties.Resources.sticker_35mm_bronzeaward__1_;
            this.pictureBoxBronze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBronze.Image = global::signuo.Properties.Resources.sticker_35mm_bronzeaward__1_;
            this.pictureBoxBronze.Location = new System.Drawing.Point(315, 260);
            this.pictureBoxBronze.Name = "pictureBoxBronze";
            this.pictureBoxBronze.Size = new System.Drawing.Size(292, 287);
            this.pictureBoxBronze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBronze.TabIndex = 2;
            this.pictureBoxBronze.TabStop = false;
            this.pictureBoxBronze.Visible = false;
            // 
            // pictureBoxSilver
            // 
            this.pictureBoxSilver.Image = global::signuo.Properties.Resources.ri573fci_400x400;
            this.pictureBoxSilver.Location = new System.Drawing.Point(315, 260);
            this.pictureBoxSilver.Name = "pictureBoxSilver";
            this.pictureBoxSilver.Size = new System.Drawing.Size(292, 287);
            this.pictureBoxSilver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSilver.TabIndex = 3;
            this.pictureBoxSilver.TabStop = false;
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.Image = global::signuo.Properties.Resources.trend_enterprises_inc_32_gold_embossed_congratulations_certificate_award_seals_stickers__29180_1603888933;
            this.pictureBoxGold.Location = new System.Drawing.Point(315, 260);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(292, 287);
            this.pictureBoxGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGold.TabIndex = 4;
            this.pictureBoxGold.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Location = new System.Drawing.Point(878, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(32, 31);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BadgesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 559);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.pictureBoxGold);
            this.Controls.Add(this.pictureBoxSilver);
            this.Controls.Add(this.pictureBoxBronze);
            this.Controls.Add(this.CongratsMessage);
            this.Controls.Add(this.CongratsLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BadgesForm";
            this.Text = "BadgesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBronze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CongratsLable;
        private System.Windows.Forms.Label CongratsMessage;
        private System.Windows.Forms.PictureBox pictureBoxBronze;
        private System.Windows.Forms.PictureBox pictureBoxSilver;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.Button ExitBtn;
    }
}
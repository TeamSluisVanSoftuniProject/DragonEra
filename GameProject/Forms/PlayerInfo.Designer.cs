namespace GameProject.Forms
{
    partial class PlayerInfo
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
            this.InfoName = new System.Windows.Forms.Label();
            this.InfoHealth = new System.Windows.Forms.Label();
            this.InfoLevel = new System.Windows.Forms.Label();
            this.InfoGold = new System.Windows.Forms.Label();
            this.InfoExperience = new System.Windows.Forms.Label();
            this.DamageInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoName
            // 
            this.InfoName.AutoSize = true;
            this.InfoName.Location = new System.Drawing.Point(66, 24);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(35, 13);
            this.InfoName.TabIndex = 0;
            this.InfoName.Text = "Name";
            // 
            // InfoHealth
            // 
            this.InfoHealth.AutoSize = true;
            this.InfoHealth.Location = new System.Drawing.Point(86, 62);
            this.InfoHealth.Name = "InfoHealth";
            this.InfoHealth.Size = new System.Drawing.Size(38, 13);
            this.InfoHealth.TabIndex = 1;
            this.InfoHealth.Text = "Health";
            // 
            // InfoLevel
            // 
            this.InfoLevel.AutoSize = true;
            this.InfoLevel.Location = new System.Drawing.Point(86, 89);
            this.InfoLevel.Name = "InfoLevel";
            this.InfoLevel.Size = new System.Drawing.Size(33, 13);
            this.InfoLevel.TabIndex = 2;
            this.InfoLevel.Text = "Level";
            // 
            // InfoGold
            // 
            this.InfoGold.AutoSize = true;
            this.InfoGold.Location = new System.Drawing.Point(86, 119);
            this.InfoGold.Name = "InfoGold";
            this.InfoGold.Size = new System.Drawing.Size(29, 13);
            this.InfoGold.TabIndex = 3;
            this.InfoGold.Text = "Gold";
            // 
            // InfoExperience
            // 
            this.InfoExperience.AutoSize = true;
            this.InfoExperience.Location = new System.Drawing.Point(86, 146);
            this.InfoExperience.Name = "InfoExperience";
            this.InfoExperience.Size = new System.Drawing.Size(60, 13);
            this.InfoExperience.TabIndex = 4;
            this.InfoExperience.Text = "Experience";
            // 
            // DamageInfo
            // 
            this.DamageInfo.AutoSize = true;
            this.DamageInfo.Location = new System.Drawing.Point(86, 364);
            this.DamageInfo.Name = "DamageInfo";
            this.DamageInfo.Size = new System.Drawing.Size(47, 13);
            this.DamageInfo.TabIndex = 5;
            this.DamageInfo.Text = "Damage";
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.DamageInfo);
            this.Controls.Add(this.InfoExperience);
            this.Controls.Add(this.InfoGold);
            this.Controls.Add(this.InfoLevel);
            this.Controls.Add(this.InfoHealth);
            this.Controls.Add(this.InfoName);
            this.Name = "PlayerInfo";
            this.Text = "DragonEra";
            this.Load += new System.EventHandler(this.PlayerInfo_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Press);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoName;
        private System.Windows.Forms.Label InfoHealth;
        private System.Windows.Forms.Label InfoLevel;
        private System.Windows.Forms.Label InfoGold;
        private System.Windows.Forms.Label InfoExperience;
        private System.Windows.Forms.Label DamageInfo;
    }
}
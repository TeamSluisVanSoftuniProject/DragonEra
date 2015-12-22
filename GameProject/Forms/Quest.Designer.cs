namespace GameProject.Forms
{
    partial class Quest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quest));
            this.LongCount = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.WyrnCount = new System.Windows.Forms.Label();
            this.EraCount = new System.Windows.Forms.Label();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LongCount
            // 
            this.LongCount.AutoSize = true;
            this.LongCount.BackColor = System.Drawing.Color.Transparent;
            this.LongCount.Font = new System.Drawing.Font("DarksSkyrimFont", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongCount.ForeColor = System.Drawing.Color.White;
            this.LongCount.Location = new System.Drawing.Point(165, 141);
            this.LongCount.Name = "LongCount";
            this.LongCount.Size = new System.Drawing.Size(61, 20);
            this.LongCount.TabIndex = 0;
            this.LongCount.Text = "0 / 4";
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.DimGray;
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AcceptButton.FlatAppearance.BorderSize = 3;
            this.AcceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AcceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.ForeColor = System.Drawing.Color.LightGray;
            this.AcceptButton.Location = new System.Drawing.Point(25, 296);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(265, 67);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "ACCEPT";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // WyrnCount
            // 
            this.WyrnCount.AutoSize = true;
            this.WyrnCount.BackColor = System.Drawing.Color.Transparent;
            this.WyrnCount.Font = new System.Drawing.Font("DarksSkyrimFont", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WyrnCount.ForeColor = System.Drawing.Color.White;
            this.WyrnCount.Location = new System.Drawing.Point(134, 170);
            this.WyrnCount.Name = "WyrnCount";
            this.WyrnCount.Size = new System.Drawing.Size(61, 20);
            this.WyrnCount.TabIndex = 4;
            this.WyrnCount.Text = "0 / 4";
            // 
            // EraCount
            // 
            this.EraCount.AutoSize = true;
            this.EraCount.BackColor = System.Drawing.Color.Transparent;
            this.EraCount.Font = new System.Drawing.Font("DarksSkyrimFont", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EraCount.ForeColor = System.Drawing.Color.White;
            this.EraCount.Location = new System.Drawing.Point(149, 199);
            this.EraCount.Name = "EraCount";
            this.EraCount.Size = new System.Drawing.Size(61, 20);
            this.EraCount.TabIndex = 5;
            this.EraCount.Text = "0 / 4";
            // 
            // CompleteButton
            // 
            this.CompleteButton.BackColor = System.Drawing.Color.DimGray;
            this.CompleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompleteButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.CompleteButton.FlatAppearance.BorderSize = 3;
            this.CompleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CompleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CompleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompleteButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompleteButton.ForeColor = System.Drawing.Color.LightGray;
            this.CompleteButton.Location = new System.Drawing.Point(25, 296);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(265, 67);
            this.CompleteButton.TabIndex = 6;
            this.CompleteButton.Text = "COMPLETE";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // Quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameProject.Properties.Resources.QuestBG;
            this.ClientSize = new System.Drawing.Size(326, 386);
            this.Controls.Add(this.EraCount);
            this.Controls.Add(this.WyrnCount);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.LongCount);
            this.Controls.Add(this.CompleteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragonEra";
            this.Load += new System.EventHandler(this.Quest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WyrnCount;
        private System.Windows.Forms.Label EraCount;
        private System.Windows.Forms.Button CompleteButton;
        public System.Windows.Forms.Label LongCount;
        public System.Windows.Forms.Button AcceptButton;
    }
}
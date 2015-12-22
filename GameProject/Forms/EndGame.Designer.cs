namespace GameProject.Forms
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.DimGray;
            this.PlayAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.PlayAgainButton.FlatAppearance.BorderSize = 3;
            this.PlayAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PlayAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgainButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.LightGray;
            this.PlayAgainButton.Location = new System.Drawing.Point(273, 338);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(252, 85);
            this.PlayAgainButton.TabIndex = 1;
            this.PlayAgainButton.Text = "PLAY AGAIN";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.DimGray;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.QuitButton.FlatAppearance.BorderSize = 3;
            this.QuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuitButton.ForeColor = System.Drawing.Color.LightGray;
            this.QuitButton.Location = new System.Drawing.Point(273, 450);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(252, 85);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "QUIT";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameProject.Properties.Resources.MainGameBG_Recovered2;
            this.ClientSize = new System.Drawing.Size(802, 599);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PlayAgainButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragonEra";
            this.Load += new System.EventHandler(this.EndGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Button QuitButton;
    }
}
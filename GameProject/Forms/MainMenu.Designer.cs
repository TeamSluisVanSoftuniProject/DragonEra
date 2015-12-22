namespace GameProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.StartGame = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.DimGray;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGame.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.StartGame.FlatAppearance.BorderSize = 3;
            this.StartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.StartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGame.ForeColor = System.Drawing.Color.LightGray;
            this.StartGame.Location = new System.Drawing.Point(34, 69);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(221, 74);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "START GAME";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.DimGray;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.quitButton.FlatAppearance.BorderSize = 3;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.ForeColor = System.Drawing.Color.LightGray;
            this.quitButton.Location = new System.Drawing.Point(34, 158);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(221, 74);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // MainMenu
            // 
            this.AcceptButton = this.StartGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::GameProject.Properties.Resources.DragonWallaperpNedugav;
            this.ClientSize = new System.Drawing.Size(795, 604);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.StartGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragonEra";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button quitButton;
    }
}


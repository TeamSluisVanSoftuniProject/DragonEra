namespace GameProject
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.BattleButton = new System.Windows.Forms.Button();
            this.MarketButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.QuestButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.DamageLabelStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BattleButton
            // 
            this.BattleButton.BackColor = System.Drawing.Color.DimGray;
            this.BattleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BattleButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BattleButton.FlatAppearance.BorderSize = 3;
            this.BattleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BattleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BattleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BattleButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BattleButton.ForeColor = System.Drawing.Color.LightGray;
            this.BattleButton.Location = new System.Drawing.Point(31, 215);
            this.BattleButton.Name = "BattleButton";
            this.BattleButton.Size = new System.Drawing.Size(221, 74);
            this.BattleButton.TabIndex = 1;
            this.BattleButton.Text = "Battle";
            this.BattleButton.UseVisualStyleBackColor = false;
            this.BattleButton.Click += new System.EventHandler(this.Battle_Click);
            // 
            // MarketButton
            // 
            this.MarketButton.BackColor = System.Drawing.Color.DimGray;
            this.MarketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MarketButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.MarketButton.FlatAppearance.BorderSize = 3;
            this.MarketButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MarketButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.MarketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarketButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarketButton.ForeColor = System.Drawing.Color.LightGray;
            this.MarketButton.Location = new System.Drawing.Point(31, 387);
            this.MarketButton.Name = "MarketButton";
            this.MarketButton.Size = new System.Drawing.Size(221, 74);
            this.MarketButton.TabIndex = 2;
            this.MarketButton.Text = "Market";
            this.MarketButton.UseVisualStyleBackColor = false;
            this.MarketButton.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.BackColor = System.Drawing.Color.DimGray;
            this.InventoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InventoryButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.InventoryButton.FlatAppearance.BorderSize = 3;
            this.InventoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.InventoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryButton.ForeColor = System.Drawing.Color.LightGray;
            this.InventoryButton.Location = new System.Drawing.Point(31, 299);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(221, 74);
            this.InventoryButton.TabIndex = 3;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = false;
            this.InventoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(194, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(132, 22);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Slaugther";
            // 
            // healthBar
            // 
            this.healthBar.ForeColor = System.Drawing.Color.Cyan;
            this.healthBar.Location = new System.Drawing.Point(145, 92);
            this.healthBar.MarqueeAnimationSpeed = 50;
            this.healthBar.Maximum = 0;
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(222, 33);
            this.healthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.healthBar.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 130);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HealthLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.Location = new System.Drawing.Point(189, 55);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(81, 21);
            this.HealthLabel.TabIndex = 12;
            this.HealthLabel.Text = "label1";
            // 
            // QuestButton
            // 
            this.QuestButton.BackColor = System.Drawing.Color.DimGray;
            this.QuestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.QuestButton.FlatAppearance.BorderSize = 3;
            this.QuestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.QuestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.QuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestButton.ForeColor = System.Drawing.Color.LightGray;
            this.QuestButton.Location = new System.Drawing.Point(551, 476);
            this.QuestButton.Name = "QuestButton";
            this.QuestButton.Size = new System.Drawing.Size(221, 74);
            this.QuestButton.TabIndex = 13;
            this.QuestButton.Text = "Quest";
            this.QuestButton.UseVisualStyleBackColor = false;
            this.QuestButton.Click += new System.EventHandler(this.QuestButton_Click);
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
            this.QuitButton.Location = new System.Drawing.Point(629, 10);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(143, 52);
            this.QuitButton.TabIndex = 14;
            this.QuitButton.Text = "QUIT";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // DamageLabelStatus
            // 
            this.DamageLabelStatus.AutoSize = true;
            this.DamageLabelStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DamageLabelStatus.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageLabelStatus.Location = new System.Drawing.Point(306, 55);
            this.DamageLabelStatus.Name = "DamageLabelStatus";
            this.DamageLabelStatus.Size = new System.Drawing.Size(52, 21);
            this.DamageLabelStatus.TabIndex = 16;
            this.DamageLabelStatus.Text = "350";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.ErrorImage = global::GameProject.Properties.Resources.logo_status_bar;
            this.pictureBox2.Location = new System.Drawing.Point(27, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 96);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::GameProject.Properties.Resources.MainGameBG;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DamageLabelStatus);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.QuestButton);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.MarketButton);
            this.Controls.Add(this.BattleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragonEra";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MarketButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Button BattleButton;
        public System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HealthLabel;
        public System.Windows.Forms.Button QuestButton;
        public System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label DamageLabelStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
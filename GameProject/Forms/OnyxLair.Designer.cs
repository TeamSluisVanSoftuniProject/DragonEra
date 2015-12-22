namespace GameProject.Forms
{
    partial class DragonEra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragonEra));
            this.PlayerHealthBar = new System.Windows.Forms.ProgressBar();
            this.OnyxHealthBar = new System.Windows.Forms.ProgressBar();
            this.HeroDamage = new System.Windows.Forms.Label();
            this.HeroHealth = new System.Windows.Forms.Label();
            this.OnyxDamage = new System.Windows.Forms.Label();
            this.OnyxHealth = new System.Windows.Forms.Label();
            this.AttackButton = new System.Windows.Forms.Button();
            this.HealButton = new System.Windows.Forms.Button();
            this.ExecuteAssasin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.Location = new System.Drawing.Point(132, 373);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(218, 35);
            this.PlayerHealthBar.TabIndex = 0;
            // 
            // OnyxHealthBar
            // 
            this.OnyxHealthBar.Location = new System.Drawing.Point(651, 373);
            this.OnyxHealthBar.Name = "OnyxHealthBar";
            this.OnyxHealthBar.Size = new System.Drawing.Size(220, 35);
            this.OnyxHealthBar.TabIndex = 1;
            // 
            // HeroDamage
            // 
            this.HeroDamage.AutoSize = true;
            this.HeroDamage.BackColor = System.Drawing.Color.Transparent;
            this.HeroDamage.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroDamage.Location = new System.Drawing.Point(196, 236);
            this.HeroDamage.Name = "HeroDamage";
            this.HeroDamage.Size = new System.Drawing.Size(139, 35);
            this.HeroDamage.TabIndex = 3;
            this.HeroDamage.Text = "label1";
            // 
            // HeroHealth
            // 
            this.HeroHealth.AutoSize = true;
            this.HeroHealth.BackColor = System.Drawing.Color.Transparent;
            this.HeroHealth.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroHealth.Location = new System.Drawing.Point(196, 306);
            this.HeroHealth.Name = "HeroHealth";
            this.HeroHealth.Size = new System.Drawing.Size(139, 35);
            this.HeroHealth.TabIndex = 4;
            this.HeroHealth.Text = "label2";
            // 
            // OnyxDamage
            // 
            this.OnyxDamage.AutoSize = true;
            this.OnyxDamage.BackColor = System.Drawing.Color.Transparent;
            this.OnyxDamage.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnyxDamage.Location = new System.Drawing.Point(710, 236);
            this.OnyxDamage.Name = "OnyxDamage";
            this.OnyxDamage.Size = new System.Drawing.Size(139, 35);
            this.OnyxDamage.TabIndex = 5;
            this.OnyxDamage.Text = "label3";
            // 
            // OnyxHealth
            // 
            this.OnyxHealth.AutoSize = true;
            this.OnyxHealth.BackColor = System.Drawing.Color.Transparent;
            this.OnyxHealth.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnyxHealth.Location = new System.Drawing.Point(710, 306);
            this.OnyxHealth.Name = "OnyxHealth";
            this.OnyxHealth.Size = new System.Drawing.Size(139, 35);
            this.OnyxHealth.TabIndex = 6;
            this.OnyxHealth.Text = "label4";
            // 
            // AttackButton
            // 
            this.AttackButton.BackColor = System.Drawing.Color.DimGray;
            this.AttackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.AttackButton.FlatAppearance.BorderSize = 3;
            this.AttackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AttackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AttackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttackButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttackButton.ForeColor = System.Drawing.Color.LightGray;
            this.AttackButton.Location = new System.Drawing.Point(429, 300);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(151, 50);
            this.AttackButton.TabIndex = 9;
            this.AttackButton.Text = "ATTACK";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click_1);
            // 
            // HealButton
            // 
            this.HealButton.BackColor = System.Drawing.Color.DimGray;
            this.HealButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HealButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.HealButton.FlatAppearance.BorderSize = 3;
            this.HealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.HealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HealButton.ForeColor = System.Drawing.Color.LightGray;
            this.HealButton.Location = new System.Drawing.Point(186, 437);
            this.HealButton.Name = "HealButton";
            this.HealButton.Size = new System.Drawing.Size(100, 41);
            this.HealButton.TabIndex = 10;
            this.HealButton.Text = "Heal";
            this.HealButton.UseVisualStyleBackColor = true;
            this.HealButton.Click += new System.EventHandler(this.HealButton_Click_1);
            // 
            // ExecuteAssasin
            // 
            this.ExecuteAssasin.BackColor = System.Drawing.Color.DimGray;
            this.ExecuteAssasin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteAssasin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.ExecuteAssasin.FlatAppearance.BorderSize = 3;
            this.ExecuteAssasin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ExecuteAssasin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ExecuteAssasin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteAssasin.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteAssasin.ForeColor = System.Drawing.Color.LightGray;
            this.ExecuteAssasin.Location = new System.Drawing.Point(133, 490);
            this.ExecuteAssasin.Name = "ExecuteAssasin";
            this.ExecuteAssasin.Size = new System.Drawing.Size(202, 41);
            this.ExecuteAssasin.TabIndex = 11;
            this.ExecuteAssasin.Text = "Execute(3x Damage)";
            this.ExecuteAssasin.UseVisualStyleBackColor = true;
            this.ExecuteAssasin.Click += new System.EventHandler(this.ExecuteAssasin_Click);
            // 
            // DragonEra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 595);
            this.Controls.Add(this.ExecuteAssasin);
            this.Controls.Add(this.HealButton);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.OnyxHealth);
            this.Controls.Add(this.OnyxDamage);
            this.Controls.Add(this.HeroHealth);
            this.Controls.Add(this.HeroDamage);
            this.Controls.Add(this.OnyxHealthBar);
            this.Controls.Add(this.PlayerHealthBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DragonEra";
            this.Text = "OnyxLair";
            this.Load += new System.EventHandler(this.OnyxLair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PlayerHealthBar;
        private System.Windows.Forms.ProgressBar OnyxHealthBar;
        private System.Windows.Forms.Label HeroDamage;
        private System.Windows.Forms.Label HeroHealth;
        private System.Windows.Forms.Label OnyxDamage;
        private System.Windows.Forms.Label OnyxHealth;
        public System.Windows.Forms.Button AttackButton;
        public System.Windows.Forms.Button HealButton;
        public System.Windows.Forms.Button ExecuteAssasin;
    }
}
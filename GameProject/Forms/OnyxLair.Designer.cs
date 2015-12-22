namespace GameProject.Forms
{
    partial class OnyxLair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnyxLair));
            this.PlayerHealthBar = new System.Windows.Forms.ProgressBar();
            this.OnyxHealthBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.HeroDamage = new System.Windows.Forms.Label();
            this.HeroHealth = new System.Windows.Forms.Label();
            this.OnyxDamage = new System.Windows.Forms.Label();
            this.OnyxHealth = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "UseHeal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Execute (3x Damage)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OnyxLair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 595);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OnyxHealth);
            this.Controls.Add(this.OnyxDamage);
            this.Controls.Add(this.HeroHealth);
            this.Controls.Add(this.HeroDamage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OnyxHealthBar);
            this.Controls.Add(this.PlayerHealthBar);
            this.Name = "OnyxLair";
            this.Text = "OnyxLair";
            this.Load += new System.EventHandler(this.OnyxLair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PlayerHealthBar;
        private System.Windows.Forms.ProgressBar OnyxHealthBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HeroDamage;
        private System.Windows.Forms.Label HeroHealth;
        private System.Windows.Forms.Label OnyxDamage;
        private System.Windows.Forms.Label OnyxHealth;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
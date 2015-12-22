namespace GameProject.Forms
{
    partial class Market
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Market));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BuyPotionButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BuyStaffButton = new System.Windows.Forms.Button();
            this.BuyDaggersButton = new System.Windows.Forms.Button();
            this.NameLabelShop = new System.Windows.Forms.Label();
            this.GoldLabelShop = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(252, 282);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.BuyPotionButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(244, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Potions";
            // 
            // BuyPotionButton
            // 
            this.BuyPotionButton.BackColor = System.Drawing.Color.DimGray;
            this.BuyPotionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyPotionButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BuyPotionButton.FlatAppearance.BorderSize = 2;
            this.BuyPotionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BuyPotionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BuyPotionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyPotionButton.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyPotionButton.ForeColor = System.Drawing.Color.LightGray;
            this.BuyPotionButton.Location = new System.Drawing.Point(199, 19);
            this.BuyPotionButton.Name = "BuyPotionButton";
            this.BuyPotionButton.Size = new System.Drawing.Size(37, 32);
            this.BuyPotionButton.TabIndex = 13;
            this.BuyPotionButton.Text = "BUY";
            this.BuyPotionButton.UseVisualStyleBackColor = true;
            this.BuyPotionButton.Click += new System.EventHandler(this.BuyPotionButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.BuyStaffButton);
            this.tabPage2.Controls.Add(this.BuyDaggersButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(244, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AttackItems";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BuyStaffButton
            // 
            this.BuyStaffButton.BackColor = System.Drawing.Color.DimGray;
            this.BuyStaffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyStaffButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BuyStaffButton.FlatAppearance.BorderSize = 2;
            this.BuyStaffButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BuyStaffButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BuyStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyStaffButton.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyStaffButton.ForeColor = System.Drawing.Color.LightGray;
            this.BuyStaffButton.Location = new System.Drawing.Point(199, 88);
            this.BuyStaffButton.Name = "BuyStaffButton";
            this.BuyStaffButton.Size = new System.Drawing.Size(37, 32);
            this.BuyStaffButton.TabIndex = 15;
            this.BuyStaffButton.Text = "BUY";
            this.BuyStaffButton.UseVisualStyleBackColor = true;
            this.BuyStaffButton.Click += new System.EventHandler(this.BuyStaffButton_Click);
            // 
            // BuyDaggersButton
            // 
            this.BuyDaggersButton.BackColor = System.Drawing.Color.DimGray;
            this.BuyDaggersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyDaggersButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BuyDaggersButton.FlatAppearance.BorderSize = 2;
            this.BuyDaggersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BuyDaggersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BuyDaggersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyDaggersButton.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyDaggersButton.ForeColor = System.Drawing.Color.LightGray;
            this.BuyDaggersButton.Location = new System.Drawing.Point(199, 20);
            this.BuyDaggersButton.Name = "BuyDaggersButton";
            this.BuyDaggersButton.Size = new System.Drawing.Size(37, 32);
            this.BuyDaggersButton.TabIndex = 14;
            this.BuyDaggersButton.Text = "BUY";
            this.BuyDaggersButton.UseVisualStyleBackColor = true;
            this.BuyDaggersButton.Click += new System.EventHandler(this.BuyDaggersButton_Click);
            // 
            // NameLabelShop
            // 
            this.NameLabelShop.AutoSize = true;
            this.NameLabelShop.BackColor = System.Drawing.Color.Transparent;
            this.NameLabelShop.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabelShop.Location = new System.Drawing.Point(84, 21);
            this.NameLabelShop.Name = "NameLabelShop";
            this.NameLabelShop.Size = new System.Drawing.Size(81, 21);
            this.NameLabelShop.TabIndex = 3;
            this.NameLabelShop.Text = "label1";
            // 
            // GoldLabelShop
            // 
            this.GoldLabelShop.AutoSize = true;
            this.GoldLabelShop.BackColor = System.Drawing.Color.Transparent;
            this.GoldLabelShop.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldLabelShop.Location = new System.Drawing.Point(183, 24);
            this.GoldLabelShop.Name = "GoldLabelShop";
            this.GoldLabelShop.Size = new System.Drawing.Size(68, 17);
            this.GoldLabelShop.TabIndex = 5;
            this.GoldLabelShop.Text = "label2";
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(448, 446);
            this.Controls.Add(this.GoldLabelShop);
            this.Controls.Add(this.NameLabelShop);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Market";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragonEra";
            this.Load += new System.EventHandler(this.Market_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label NameLabelShop;
        private System.Windows.Forms.Label GoldLabelShop;
        private System.Windows.Forms.Button BuyPotionButton;
        private System.Windows.Forms.Button BuyStaffButton;
        private System.Windows.Forms.Button BuyDaggersButton;
    }
}
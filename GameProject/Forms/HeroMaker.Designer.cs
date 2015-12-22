namespace GameProject
{
    partial class HeroMaker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroMaker));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.continueButton = new System.Windows.Forms.Button();
            this.wizardClass = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.assasinClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.DimGray;
            this.continueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.continueButton.FlatAppearance.BorderSize = 3;
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueButton.ForeColor = System.Drawing.Color.LightGray;
            this.continueButton.Location = new System.Drawing.Point(599, 498);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(173, 52);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "CONTINUE";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // wizardClass
            // 
            this.wizardClass.BackColor = System.Drawing.Color.Transparent;
            this.wizardClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wizardClass.BackgroundImage")));
            this.wizardClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wizardClass.FlatAppearance.BorderSize = 0;
            this.wizardClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wizardClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wizardClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wizardClass.ForeColor = System.Drawing.Color.Transparent;
            this.wizardClass.Location = new System.Drawing.Point(469, 110);
            this.wizardClass.Name = "wizardClass";
            this.wizardClass.Size = new System.Drawing.Size(145, 150);
            this.wizardClass.TabIndex = 3;
            this.wizardClass.UseVisualStyleBackColor = false;
            this.wizardClass.Click += new System.EventHandler(this.wizardClass_Click);
            this.wizardClass.MouseEnter += new System.EventHandler(this.Mouse_EnterWizard);
            this.wizardClass.MouseLeave += new System.EventHandler(this.Mouse_LeaveWizard);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Black;
            this.nameBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(305, 457);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 40);
            this.nameBox.TabIndex = 5;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // assasinClass
            // 
            this.assasinClass.BackColor = System.Drawing.Color.Transparent;
            this.assasinClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("assasinClass.BackgroundImage")));
            this.assasinClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assasinClass.FlatAppearance.BorderSize = 0;
            this.assasinClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.assasinClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.assasinClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assasinClass.Location = new System.Drawing.Point(187, 119);
            this.assasinClass.Name = "assasinClass";
            this.assasinClass.Size = new System.Drawing.Size(149, 152);
            this.assasinClass.TabIndex = 6;
            this.assasinClass.UseVisualStyleBackColor = false;
            this.assasinClass.Click += new System.EventHandler(this.assasinClass_Click);
            this.assasinClass.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.assasinClass.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // HeroMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::GameProject.Properties.Resources.CreateClassBG;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.assasinClass);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.wizardClass);
            this.Controls.Add(this.continueButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HeroMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragonEra";
            this.Load += new System.EventHandler(this.HeroMaker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button wizardClass;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button assasinClass;
    }
}
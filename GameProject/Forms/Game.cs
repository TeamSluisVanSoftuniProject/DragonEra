using System;
using System.Drawing;
using System.Windows.Forms;
using GameProject.Characters;
using GameProject.Enums;
using GameProject.Forms;
using GameProject.Models;
using GameProject.Properties;
using GameStructure.Hero;
using Market = GameProject.Forms.Market;

namespace GameProject
{
    public partial class Game : Form
    {
        public static Hero hero;
        public static Game game;
        public static Assasin assasin;

        public Game()
        {
            InitializeComponent();
        }

        public void Game_Load(object sender, EventArgs e)
        { 
            if (HeroMaker.wizardChoosen)
            {
                hero = new Wizard(HeroMaker.className);
                Image wizardLogo = Image.FromFile(@"C:\Users\Deny\Documents\Visual Studio 2015\Projects\GameProject\GameProject\Resources\wizardstatusbar.jpg");
                pictureBox2.Image = wizardLogo;
            }
            else
            {
                hero = new Assasin(HeroMaker.className);
                pictureBox2.Image = Image.FromFile(@"C:\Users\Deny\Documents\Visual Studio 2015\Projects\GameProject\GameProject\Resources\logo status bar.png");
            }
            NameLabel.Text = HeroMaker.className;
            HealthLabel.Text = hero.Health.ToString();
            healthBar.Maximum = hero.Health;
            healthBar.Value = hero.Health;
            healthBar.Minimum = 0;
            DamageLabelStatus.Text = hero.GetAttackDemage().ToString();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Market market = new Market(this);
            market.Show();
        }

        public void UpdateHealth(int health)
        {
            if (health < 0)
            {
                healthBar.Value = 0;
            }
            else
            {
                HealthLabel.Text = health.ToString();
                if (health > healthBar.Maximum)
                {
                    healthBar.Value = healthBar.Maximum;
                    HealthLabel.Text = healthBar.Maximum.ToString();
                    MessageBox.Show("You're already at full health, but we're gonna get your money tho.");
                }
                else
                {
                    healthBar.Value = health;
                }
            }
            DamageLabelStatus.Text = hero.AttackDamage.ToString();

        }

        private void Battle_Click(object sender, EventArgs e)
        {
            if (!Quest.accepted)
            {
                MessageBox.Show("You can't enter without accepting the quest.");
            }
            else
            {
                Battle battle = new Battle(this);
                battle.Show();
            }
        }

        private void KeyPress(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.M)
            {
                hero.Gold += 1000;
            }

        }

        public void ExitGame(ExitReason reason)
        {
            if (reason == ExitReason.PlayerDie)
            {
                Quest.LongwingCount = 0;
                Quest.WyvernCount = 0;
                Quest.EragonCount = 0;

                EndGame endGame = new EndGame();
                this.Close();
                endGame.Show();
            }

            if (reason == ExitReason.PlayerWin)
            {
                MessageBox.Show("You win!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction.");
        }

        private void QuestButton_Click(object sender, EventArgs e)
        {
            Quest quest = new Quest();
            quest.Show();
        }


        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DragonEra onyxLair = new DragonEra();
            this.Close();
            onyxLair.Show();
        }
    }
}
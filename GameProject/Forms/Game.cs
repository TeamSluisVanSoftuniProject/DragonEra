using System;
using System.Drawing;
using System.Windows.Forms;
using GameProject.Characters;
using GameProject.Enums;
using GameProject.Forms;
using GameProject.Models;
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
            }
            else
            {
                hero = new Assasin(HeroMaker.className);
            }
            NameLabel.Text = HeroMaker.className;
            HealthLabel.Text = hero.Health.ToString();
            healthBar.Maximum = hero.Health;
            healthBar.Value = hero.Health;
            healthBar.Minimum = 0;

            if (healthBar.Value < 0)
            {
                healthBar.Value = 0;
            }


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
                healthBar.Value = health;
            }
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
            PlayerInfo playerInfo = new PlayerInfo(this);

            if (e.KeyCode == Keys.C)
            {
                playerInfo.Show();
            }

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
            OnyxLair onyxLair = new OnyxLair(this);
            onyxLair.Show();
        }
    }
}
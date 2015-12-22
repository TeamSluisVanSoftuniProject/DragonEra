using System;
using System.Windows.Forms;
using GameProject.Characters;
using GameProject.Enums;

namespace GameProject.Forms
{
    public partial class OnyxLair : Form
    {
        Dragon onyx = DragonFactory.CreateDragon(DragonTypes.Onyx);

        private Game game;
        private bool used = false;

        public OnyxLair(Game game)
        {
            InitializeComponent();
            if (used)
            {
                button3.Enabled = false;
            }

            this.game = game;
        }

        private void OnyxLair_Load(object sender, EventArgs e)
        {
            OnyxHealthBar.Maximum = onyx.Health;
            OnyxHealthBar.Value = onyx.Health;
            OnyxDamage.Text = onyx.AttackDamage.ToString();
            OnyxHealth.Text = onyx.Health.ToString();

            HeroHealth.Text = Game.hero.Health.ToString();
            HeroDamage.Text = Game.hero.AttackDamage.ToString();

            PlayerHealthBar.Maximum = Game.hero.Health;
            PlayerHealthBar.Value = Game.hero.Health;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            onyx.Health -= Game.hero.AttackDamage;
            Game.hero.Health -= onyx.AttackDamage;
            UpdateHealth(Game.hero.Health);
            OnyxHealthBar.Value = onyx.Health;
            OnyxHealth.Text = onyx.Health.ToString();

            if (onyx.Health <= 0 || OnyxHealthBar.Value <= 0)
            {
                MessageBox.Show("Good job! You ended the Dragon Era and won the game!!!");
                Environment.Exit(0);
            }

            CheckIfDead(Game.hero.Health);
        }


        public void UpdateHealth(int health)
        {
            PlayerHealthBar.Value = health;
            HeroHealth.Text = health.ToString();

            if (health < 0)
            {
                EndGame endGame = new EndGame();
                endGame.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.assasin.Heal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onyx.Health -= Game.hero.AttackDamage * 3;
            OnyxHealthBar.Value = onyx.Health;
            OnyxHealth.Text = onyx.Health.ToString();
            button3.Enabled = false;

        }

        private void CheckIfDead(int health)
        {
            if (health <= 0)
            {
                this.Close();
                game.Close();
                EndGame endGame = new EndGame();
                endGame.Show();
            }
        }
    }
}

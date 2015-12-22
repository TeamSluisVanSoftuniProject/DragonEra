using System;
using System.Windows.Forms;
using GameProject.Characters;
using GameProject.Enums;

namespace GameProject.Forms
{
    public partial class DragonEra : Form
    {
       
        private Game game;
        private int healCounter;
        private int executeCounter;
        Onyx onyx = (Onyx)DragonFactory.CreateDragon(DragonTypes.Onyx);

        public DragonEra()
        {
            InitializeComponent();
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

            HealButton.Enabled = false;
            ExecuteAssasin.Enabled = false;
        }

        public void UpdateHealth(int heroHealth, int dragonHealth)
        {
            if (heroHealth < 0)
            {
                PlayerHealthBar.Maximum = 0;
                PlayerHealthBar.Value = 0;
            }
            else if (dragonHealth < 0)
            {
                OnyxHealthBar.Maximum = 0;
                OnyxHealthBar.Value = 0;
            }
            else
            {
                PlayerHealthBar.Value = heroHealth;
                OnyxHealthBar.Value = dragonHealth;
                HeroHealth.Text = heroHealth.ToString();
                OnyxHealth.Text = dragonHealth.ToString();
            }

        }



        private void CheckIfDead(int heroHealth, int dragonHealth)
        {
            if (dragonHealth <= 0)
            {
                this.Close();
                MessageBox.Show("You ended the Dragon Era. Good job!");
            }

            if (heroHealth <= 0)
            {
                this.Close();
                EndGame endGame = new EndGame();
                endGame.Show();
            }
        }



        private void Cooldowns()
        {
            healCounter++;
            executeCounter++;

            if (healCounter == 3)
            {
                HealButton.Enabled = true;
            }
            else
            {
                HealButton.Enabled = false;
            }

            if (executeCounter == 5)
            {
                ExecuteAssasin.Enabled = true;
            }
            else
            {
                ExecuteAssasin.Enabled = false;
            }
        }

        private void AttackButton_Click_1(object sender, EventArgs e)
        {
            Game.hero.DoBattleOnyx(onyx);
            CheckIfDead(Game.hero.Health, onyx.Health);
            UpdateHealth(Game.hero.Health, onyx.Health);
            Cooldowns();
        }

        private void ExecuteAssasin_Click(object sender, EventArgs e)
        {
            onyx.Health -= Game.hero.AttackDamage * 3;
            UpdateHealth(Game.hero.Health, onyx.Health);
            ExecuteAssasin.Enabled = false;
        }

        private void HealButton_Click_1(object sender, EventArgs e)
        {
            Game.hero.Heal();
            UpdateHealth(Game.hero.Health, onyx.Health);
            HealButton.Enabled = false;
        }
    }
}

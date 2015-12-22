using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameProject.Characters;
using static GameProject.Enums.DragonTypes;


namespace GameProject.Forms
{
    public partial class Battle : Form
    {
        Dragon longwing = DragonFactory.CreateDragon(Longwing);
        Dragon wyvern = DragonFactory.CreateDragon(Wyvern);
        Dragon eragon = DragonFactory.CreateDragon(Eragon);

        private Game game;

        public Battle(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void Battle_Load(object sender, EventArgs e)
        {
            LongwingHealth.Text = longwing.Health.ToString();
            LongwingDamage.Text = longwing.ReturnDamage.ToString();
            WyrmHealth.Text = wyvern.Health.ToString();
            WyrmDamage.Text = wyvern.ReturnDamage.ToString();
            EregonHealth.Text = eragon.Health.ToString();
            EregonDamage.Text = eragon.ReturnDamage.ToString();
            OnyxButton.Visible = false;

            if (Quest.completed)
            {
                AttackEragonButton.Enabled = false;
                AttackLongwingButton.Enabled = false;
                AttackWyrnButton.Enabled = false;
                OnyxButton.Visible = true;
            }
        }

        private void AttackLongwingButton_Click(object sender, EventArgs e)
        {
            Game.hero.DoBattle(longwing);
            game.UpdateHealth(Game.hero.Health);
            CheckIfDead(Game.hero.Health);
        }

        private void AttackWyrnButton_Click(object sender, EventArgs e)
        {
            Game.hero.DoBattle(wyvern);
            game.UpdateHealth(Game.hero.Health);
            CheckIfDead(Game.hero.Health);
        }

        private void AttackEragonButton_Click(object sender, EventArgs e)
        {
            Game.hero.DoBattle(eragon);
            game.UpdateHealth(Game.hero.Health);
            CheckIfDead(Game.hero.Health);
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

        private void OnyxButton_Click(object sender, EventArgs e)
        {
            DragonEra onyxLair = new DragonEra();
            onyxLair.Show();
        }
    }
}

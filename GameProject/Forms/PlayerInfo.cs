using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStructure.Hero;

namespace GameProject.Forms
{
    public partial class PlayerInfo : Form
    {
        private Game game;

        public PlayerInfo(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void PlayerInfo_Load(object sender, EventArgs e)
        {
            var hero = Game.hero;
            InfoName.Text = hero.Name;
            InfoExperience.Text = hero.Experience.ToString();
            InfoGold.Text = hero.Gold.ToString();
            InfoHealth.Text = hero.Health.ToString();
            InfoLevel.Text = hero.Level.ToString();
            DamageInfo.Text = hero.AttackDamage.ToString();
        }

        private void Key_Press(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.C)
            {
                this.Hide();
            }
        }
    }
}
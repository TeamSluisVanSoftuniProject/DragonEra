using System;
using System.Windows.Forms;
using GameProject.Characters;
using GameProject.Enums;
using GameProject.Items;
using GameProject.Items.AttackItems;
using GameProject.Items.HealthItems;

namespace GameProject.Forms
{
    public partial class Market : Form
    {
        Potion potion = (Potion)ItemFactory.CreateItem(ItemTypes.Potion);
        Daggers daggers = (Daggers) ItemFactory.CreateItem(ItemTypes.Daggers);
        Staff staff = (Staff) ItemFactory.CreateItem(ItemTypes.Staff);

        private Game game;

        public Market(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void Market_Load(object sender, EventArgs e)
        {
            GoldLabelShop.Text = Game.hero.Gold.ToString();
            NameLabelShop.Text = Game.hero.Name;
        }

        private void BuyPotionButton_Click(object sender, EventArgs e)
        {
            if (Game.hero.Gold >= potion.Price)
            {
                potion.Heal(Game.hero);
                game.UpdateHealth(Game.hero.Health);
                Game.hero.Gold -= potion.Price;
                GoldLabelShop.Text = Game.hero.Gold.ToString();
            }
            else
            {
                MessageBox.Show(Constants.NotEnoughGold);
            }
        }

        private void BuyDaggersButton_Click(object sender, EventArgs e)
        {
            if (HeroMaker.assasinChoosen)
            {
                if (Game.hero.Gold < daggers.Price)
                {
                    MessageBox.Show(Constants.NotEnoughGold);
                }
                else
                {
                    Game.hero.Gold -= daggers.Price;
                    Game.hero.AttackDamage += daggers.Attack;
                    MessageBox.Show(String.Format("You have equipped {0}", daggers.Name));
                    GoldLabelShop.Text = Game.hero.Gold.ToString();
                }
            }
            else
            {
                MessageBox.Show(Constants.NeedToBeAssasin);
            }
            BuyDaggersButton.Enabled = false;
        }

        private void BuyStaffButton_Click(object sender, EventArgs e)
        {
            if (HeroMaker.wizardChoosen)
            {
                if (Game.hero.Gold < staff.Price)
                {
                    MessageBox.Show(Constants.NotEnoughGold);
                }
                else
                {
                    Game.hero.Gold -= staff.Price;
                    Game.hero.AttackDamage += staff.Attack;
                    MessageBox.Show(String.Format("You have equipped {0}", staff.Name));
                    GoldLabelShop.Text = Game.hero.Gold.ToString();
                }
            }
            else
            {
                MessageBox.Show(Constants.NeedToBeWizard);
            }


            BuyStaffButton.Enabled = false;
        }
    }
}

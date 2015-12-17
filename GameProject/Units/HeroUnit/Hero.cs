using System;
using System.Windows.Forms;
using GameProject;
using GameProject.Characters;
using GameProject.Enums;
using GameProject.Forms;

namespace GameStructure.Hero
{
    public abstract class Hero : Unit
    {
        private int experience;
        private int kills;
        private int gold;
        private Inventory inventory;

        protected Hero(string name, int health, int attackDamage)
            : base(name, health, attackDamage)
        {
            this.inventory = new Inventory();
            this.Level = 1;
        }

        public int Experience { get; set; }

        public int Gold { get; set; }

        public int Kills { get; set; }

        public Inventory Inventory { get; set; }

        public int Level { get; set; }

        public override int GetAttackDemage()
        {
            int damage = this.AttackDamage;

            if (damage <= 0)
            {
                damage = 10;
            }

            return damage;
        }

        public void DoBattle(Dragon dragon)
        {
            var enemyHealth = dragon.Health;
            var playerDamage = this.GetAttackDemage();
            var dragonDamage = dragon.GetAttackDemage();

            if (playerDamage > enemyHealth)
            {
                this.Experience += dragon.Experience;
                this.Gold += dragon.GoldDrop;
                this.Health -= dragonDamage;

                if (this.Experience % 300 == 0)
                {
                    MessageBox.Show("You leveled up! You're now level " + this.Level + "!");
                    this.Level++;
                }
                MessageBox.Show(Constants.CreatureKilled + dragon.Name);
            }
            else
            {
                this.Health -= dragonDamage * 2;
            }

            if (Quest.accepted)
            {
                if (dragon.Name == "Longwing")
                {
                    Quest.LongwingCount++;
                }
                if (dragon.Name == "Wyvern")
                {
                    Quest.WyvernCount++;
                }
                if (dragon.Name == "Eragon")
                {
                    Quest.EragonCount++;
                }
            }

        }
    }

}
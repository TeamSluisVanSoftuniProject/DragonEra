using System;
using System.Windows.Forms;
using GameProject;
using GameProject.Characters;
using GameProject.Enums;
using GameProject.Forms;
using GameProject.Models;

namespace GameStructure.Hero
{
    public delegate void EventHandler();

    public abstract class Hero : Unit
    {
        private int experience;
        private int kills;
        private int gold;
        private Inventory inventory;
        private static int precentage;
        private Game game;

        protected Hero(string name, int health, int attackDamage)
            : base(name, health, attackDamage)
        {
            this.inventory = new Inventory();
            this.Level = 1;
        }

        public static event EventHandler QuestWarning;

        public int Experience { get; set; }

        public int Gold { get; set; }

        public int Kills { get; set; }

        public Inventory Inventory { get; set; }

        public int Level { get; set; }

        public override int GetAttackDemage()
        {
            int damage = this.AttackDamage;
            return damage;
        }

        public void DoBattle(Dragon dragon)
        {
            var dragonHealth = dragon.Health;
            var playerDamage = this.GetAttackDemage();
            var dragonDamage = dragon.GetAttackDemage();

            if (playerDamage > dragonHealth)
            {
                this.Gold += dragon.GoldDrop;
                this.Health -= dragonDamage;

                MessageBox.Show(String.Format("You have just killed {0}! You earned : {1} Gold!", dragon.Name, dragon.GoldDrop));
            }

            UpdateQuest(dragon);
        }

        public void DoBattleOnyx(Onyx onyx)
        {
            this.Health -= onyx.ReturnDamage;
            onyx.Health -= AttackDamage;
        }

        public void UpdateQuest(Dragon dragon)
        {
            if (Quest.accepted)
            {
                if (dragon.Name == "Longwing")
                {
                    if (Quest.LongwingCount >= 4)
                    {
                        Quest.LongwingCount = 4;
                    }
                    else
                    {
                        Quest.LongwingCount++;
                    }

                }
                if (dragon.Name == "Wyvern")
                {
                    if (Quest.WyvernCount >= 4)
                    {
                        Quest.WyvernCount = 4;
                    }
                    else
                    {
                        Quest.WyvernCount = 4;
                    }
                }
                if (dragon.Name == "Eragon")
                {
                    if (Quest.EragonCount >= 4)
                    {
                        Quest.EragonCount = 4;
                    }
                    else
                    {
                        Quest.EragonCount++;
                    }
                }
            }
        }

        public void Heal()
        {
            this.Health += 90;
        }


    }
}

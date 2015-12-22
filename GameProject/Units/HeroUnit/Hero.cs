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

        public static void Warning()
        {
            MessageBox.Show("Good job! Your quest is " + precentage + "% completed");
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
            var dragonHealth = dragon.Health;
            var playerDamage = this.GetAttackDemage();
            var dragonDamage = dragon.GetAttackDemage();

            if (this.Health <= 0)
            {
                Game.game.ExitGame(ExitReason.PlayerDie);
            }

            if (playerDamage > dragonHealth)
            {
                if (precentage == 70)
                {
                    QuestWarning = Warning;
                    QuestWarning.Invoke();
                }

                this.Experience += dragon.Experience;
                this.Gold += dragon.GoldDrop;
                this.Health -= dragonDamage;

                if (this.Experience == 500)
                {
                    this.Level++;
                    MessageBox.Show("You leveled up! You're now level " + this.Level + "!");
                }

                MessageBox.Show(String.Format("You just killed {0}! You earned : {1} gold and {2} experience", dragon.Name, dragon.GoldDrop, dragon.Experience));

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

                    if (Quest.LongwingCount + Quest.WyvernCount + Quest.EragonCount == 7)
                    {
                        precentage = 70;
                    }
                }
            }
        }
    }
}

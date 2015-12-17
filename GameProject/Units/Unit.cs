using System;

namespace GameStructure.Hero
{
    public abstract class Unit
    {
        private string name;
        private int health;
        private int attackDamage;

        protected Unit(string name, int health, int attackDamage)
        {
            this.Name = name;
            this.Health = health;
            this.AttackDamage = attackDamage;
        }

        public int AttackDamage
        {
            get { return this.attackDamage; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.attackDamage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.health = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public abstract int GetAttackDemage();

    }
}
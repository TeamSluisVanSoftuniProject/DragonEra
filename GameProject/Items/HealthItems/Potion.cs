using System;
using GameProject.Enums;
using GameProject.Interfaces;
using GameStructure.Hero;

namespace GameProject.Items.HealthItems
{
    public class Potion : HealthItem
    {
        private const int SimplePotion = 50;

        public Potion(string name, int price, ItemTypes item)
            : base(name, price, item)
        {
        }

        public void Heal(Hero hero)
        {
            hero.Health += Healing;
        }

        public override int Healing
        {
            get
            {
                switch (this.ItemTypes)
                {
                    case ItemTypes.Potion:
                        return Potion.SimplePotion;
                    default:
                        return 0;
                }
            }
        }
    }
}

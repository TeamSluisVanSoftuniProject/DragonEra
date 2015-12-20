using System;
using GameProject.Enums;
using GameProject.Interfaces;
using GameStructure.Hero;

namespace GameProject.Items.HealthItems
{
    public class Potion : HealthItem
    {
        private const int SmallPotionHealing = 30;
        private const int BigPotionHealing = 60;

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
                    case ItemTypes.SmallPotion:
                        return Potion.SmallPotionHealing;
                    case ItemTypes.BigPotion:
                        return Potion.BigPotionHealing;
                    default:
                        return 0;
                }
            }
        }
    }
}

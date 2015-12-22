using System;
using GameProject.Enums;

namespace GameProject.Items.AttackItems
{
    public class Daggers : AttackItem
    {
        private const int DaggersDamage = 100;

        public Daggers(string name, int price, ItemTypes item) 
             :base(name, price, item)
        {
        }

        public override int Attack
        {
            get
            {
                switch (this.ItemTypes)
                {
                    case ItemTypes.Daggers: return Daggers.DaggersDamage;
                    default:
                        return 0;
                }
            }
        }
    }
}
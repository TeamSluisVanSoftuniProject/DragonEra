using System;
using GameProject.Enums;
using GameProject.Items.AttackItems;
using GameProject.Items.HealthItems;

namespace GameProject.Items
{
    public class ItemFactory
    {
        public static Item CreateItem(ItemTypes item)
        {
            switch (item)
            {
                case ItemTypes.SmallPotion:
                    return new Potion("Small potion", 50, ItemTypes.SmallPotion);
                case ItemTypes.BigPotion:
                    return new Potion("Big potion", 75, ItemTypes.BigPotion);
                case ItemTypes.Daggers:
                    return new Daggers("Daggers of Faith", 30, ItemTypes.Daggers);

                default: throw new ArgumentException("Invalid enemy type.");
            }
        }
    }
}
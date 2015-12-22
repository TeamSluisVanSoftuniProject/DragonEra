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
                case ItemTypes.Potion:
                    return new Potion("Small potion", 100, ItemTypes.Potion);
                case ItemTypes.Daggers:
                    return new Daggers("Daggers of Faith", 1500, ItemTypes.Daggers);
                case ItemTypes.Staff:
                    return new Staff("Rod of Atos", 1800, ItemTypes.Staff);

                default: throw new ArgumentException("Invalid enemy type.");
            }
        }
    }
}
using System;
using GameProject.Enums;
using GameProject.Interfaces;

namespace GameProject.Items
{
    public class Item : IItem
    {
        private string name;

        public Item(string name, int price, ItemTypes items)
        {
            this.Name = name;
            this.Price = price;
            this.ItemTypes = items;
        }

        public int Price { get; set; }

        public ItemTypes ItemTypes { get; set; }

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
    }
}
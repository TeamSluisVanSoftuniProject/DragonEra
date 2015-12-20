using GameProject.Enums;

namespace GameProject.Items.AttackItems
{
    public abstract class AttackItem : Item
    {
        protected AttackItem(string name, int price, ItemTypes items) 
            :base(name, price, items)
        {
        }

        public abstract int Attack { get;}
    }
}

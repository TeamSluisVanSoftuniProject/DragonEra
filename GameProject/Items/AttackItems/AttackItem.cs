using GameProject.Enums;

namespace GameProject.Items.AttackItems
{
    public abstract class AttackItem : Item
    {
        protected AttackItem(string name, int price, ItemTypes itemType) 
            :base(name, price, itemType)
        {
        }

        public abstract int Attack { get;}
    }
}

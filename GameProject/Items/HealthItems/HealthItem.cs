using GameProject.Enums;

namespace GameProject.Items.HealthItems
{

    public abstract class HealthItem : Item
    {
        protected HealthItem(string name, int price, ItemTypes item) 
            :base(name, price, item)
        {
        }

        public abstract int Healing { get; }
    }
}

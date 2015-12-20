using GameProject.Enums;

namespace GameProject.Items.AttackItems
{
    public class Staff : AttackItem
    {
        private const int StaffDamage = 50;

        public Staff(string name, int price, ItemTypes item) 
             :base(name, price, item)
        {
        }

        public override int Attack
        {
            get
            {
                switch (this.ItemTypes)
                {
                    case ItemTypes.Staff: return Staff.StaffDamage;
                    default:
                        return Staff.StaffDamage;
                }
            }
        }
    }
}
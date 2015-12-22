using GameProject.Enums;

namespace GameProject.Interfaces
{
    public interface IItem
    {
        int Price
        {
            get; set; }

        ItemTypes ItemTypes
        {
            get;
            set;
        }
    }
}
using System;
using GameProject.Enums;

namespace GameProject.Characters
{
    public class DragonFactory
    {
        public static Dragon CreateDragon(DragonTypes type)
        {
            switch (type)
            {
                case DragonTypes.Wyvern:
                    return new Dragon("Wyvern", 200, DragonTypes.Wyvern, 80 , 150, 350);
                case DragonTypes.Eragon:
                    return new Dragon("Eragon", 200, DragonTypes.Eragon, 100, 200, 400);
                case DragonTypes.Longwing:
                    return new Dragon("Longwing", 200, DragonTypes.Longwing, 40, 100, 300);
                    default: throw new ArgumentException("Invalid enemy type.");
            }
        }
    }
}
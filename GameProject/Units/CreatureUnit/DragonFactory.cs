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
                    return new Dragon("Wyvern", 200, DragonTypes.Wyvern, 80 , 150, 135);
                case DragonTypes.Eragon:
                    return new Dragon("Eragon", 200, DragonTypes.Eragon, 100, 200, 190);
                case DragonTypes.Longwing:
                    return new Dragon("Longwing", 200, DragonTypes.Longwing, 40, 100, 85);
                case DragonTypes.Onyx:
                    return new Dragon("Onyx", 2000, DragonTypes.Onyx, 50, 0, 0);
                default: throw new ArgumentException("Invalid enemy type.");
            }
        }
    }
}
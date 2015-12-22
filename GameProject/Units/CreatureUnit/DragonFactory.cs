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
                    return new Dragon("Wyvern", 200, DragonTypes.Wyvern, 80, 135);
                case DragonTypes.Eragon:
                    return new Dragon("Eragon", 200, DragonTypes.Eragon, 100 ,190);
                case DragonTypes.Longwing:
                    return new Dragon("Longwing", 200, DragonTypes.Longwing, 40, 85);
                case DragonTypes.Onyx:
                    return new Onyx(BehaviorType.Aggressive);

                default: throw new ArgumentException("Invalid enemy type.");
            }
        }
    }
}
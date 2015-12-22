using GameProject.Enums;
using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Onyx : Unit
    {
        private const int OnyxHealth = 2000;
        private const int OnyxDamage = 50;
        private const string OnyxName = "Onyx";


        public Onyx(DragonTypes dragonType) 
            :base(OnyxName, OnyxHealth, OnyxDamage)
        {
            this.DragonType = dragonType;
        }

        public DragonTypes DragonType { get; set; }

        public override int GetAttackDemage()
        {
            int damage = this.AttackDamage;

            if (damage <= 0)
            {
                damage = 10;
            }

            return damage;
        }


    }
}
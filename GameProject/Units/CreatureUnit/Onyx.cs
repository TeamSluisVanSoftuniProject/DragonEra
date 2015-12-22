using GameProject.Enums;
using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Onyx : Dragon
    {
        private const int OnyxHealth = 3500;
        private const int OnyxDamage = 50;
        private const string OnyxName = "Onyx";


        public Onyx(BehaviorType behaviorType) 
            :base(OnyxName, OnyxHealth, DragonTypes.Onyx, OnyxDamage, 0)
        {
            this.BehaviorType = behaviorType;
        }

        public BehaviorType BehaviorType { get; set; }


        public override int GetAttackDemage()
        {
            int damage = this.AttackDamage;
            return damage;
        }


    }
}
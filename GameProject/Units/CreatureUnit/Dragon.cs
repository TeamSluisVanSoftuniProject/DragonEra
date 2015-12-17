using GameProject.Enums;
using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Dragon : Unit
    {
        public Dragon(string name, int health, DragonTypes type, int returnDamage, int experienceDrop, int goldDrop) :
            base(name, health, returnDamage)
        {
            this.Experience = experienceDrop;
            this.EnemyType = type;
            this.ReturnDamage = returnDamage;
            this.GoldDrop = goldDrop;
        }

        public int GoldDrop { get; set; }

        public int Experience { get; set; }

        public DragonTypes EnemyType { get; set; }

        public int ReturnDamage { get;}

        public override int GetAttackDemage()
        {
            int damage = this.ReturnDamage;

            if (damage <= 0)
            {
                damage = 10;
            }

            return damage;
        }
    }
}
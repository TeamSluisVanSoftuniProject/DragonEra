using GameProject.Enums;
using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Dragon : Unit
    {
        public Dragon(string name, int health, DragonTypes type, int returnDamage,int goldDrop) :
            base(name, health, returnDamage)
        {
            this.DragonType = type;
            this.ReturnDamage = returnDamage;
            this.GoldDrop = goldDrop;
        }

        public int GoldDrop { get; set; }


        public DragonTypes DragonType { get; set; }

        public int ReturnDamage { get;}

        public override int GetAttackDemage()
        {
            int damage = this.ReturnDamage;
            return damage;
        }
    }
}
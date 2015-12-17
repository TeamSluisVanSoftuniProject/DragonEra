using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Assasin : Hero
    {
        private new const int AttackDamage = 350;
        private new const int Health = 200;

        public Assasin(string name) 
            : base(name, Health, AttackDamage)
        {
        }

    }
}
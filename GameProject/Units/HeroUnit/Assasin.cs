using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Assasin : Hero
    {
        private const int AssasinDamage = 250;
        private const int AssasinsHealth = 300;

        public Assasin(string name) 
            : base(name, AssasinsHealth, AssasinDamage)
        {
        }

        public void Execute(Onyx onyx)
        {
            onyx.Health -= Game.hero.AttackDamage * 3;
        }

    }
}
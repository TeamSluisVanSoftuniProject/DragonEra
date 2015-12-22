using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Assasin : Hero
    {
        private const int AssasinDamage = 200;
        private const int AssasinsHealth = 300;

        public Assasin(string name) 
            : base(name, AssasinsHealth, AssasinDamage)
        {
        }

        public void Heal()
        {
            this.Health += 200;
        }

    }
}
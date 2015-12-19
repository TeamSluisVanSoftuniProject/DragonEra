namespace GameProject.Characters
{
    public class Assasin : Character
    {
        private new const int AttackDamage = 100;
        private new const int Health = 200;

        public Assasin(string name) 
            : base(name, Health, AttackDamage)
        {
        }
    }
}
namespace GameProject.Characters
{
    public class Wizard : Character
    {
        private const int SpellDamage = 120;
        private new const int Health = 200;
        private const int Mana = 200;

        private int mana;

        public Wizard(string name) 
            : base(name, Health, SpellDamage)
        {
            this.mana = Mana;
        }
    }
}
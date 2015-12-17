using GameProject.Interfaces;
using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Wizard : Hero
    {
        private const int SpellDamage = 350;
        public const int WizardHealth= 200;
        private const int Mana = 200;
        private int mana;

        public Wizard(string name) 
            : base(name, WizardHealth, SpellDamage)
        {
            this.mana = Mana;
        }
    }
}
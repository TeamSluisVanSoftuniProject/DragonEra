using GameProject.Interfaces;
using GameStructure.Hero;

namespace GameProject.Characters
{
    public class Wizard : Hero
    {
        private const int WizardDamage = 300;
        public const int WizardHealth= 250;

        public Wizard(string name) 
            : base(name, WizardHealth, WizardDamage)
        {
        }
    }
}
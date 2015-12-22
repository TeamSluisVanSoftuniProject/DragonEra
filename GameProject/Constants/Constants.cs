using System;
using GameProject.Forms;

namespace GameProject.Characters
{
    public class Constants
    {
        public const int DefaultHealth = 300;
        public static readonly string YouEarned = String.Format("You earned + {0} experience, + {1} gold", 100, 100);
        public const string NotEnoughGold = "You don't have enough gold.";
        public const string NeedToBeAssasin = "You need to be an Assasin to buy this item.";
        public const string NeedToBeWizard = "You need to be a Wizard to buy this item.";
    }
}
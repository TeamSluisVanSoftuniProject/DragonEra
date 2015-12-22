using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameProject.Characters;
using GameProject.Enums;
using GameProject.Items;
using GameProject.Items.HealthItems;
using GameStructure.Hero;

namespace GameProject
{
    static class MainClass
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());


        }
    }
}

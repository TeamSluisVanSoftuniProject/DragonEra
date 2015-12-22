using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GameProject.Characters;

namespace GameProject
{
    public partial class HeroMaker : Form
    {
        public static string className;
        public static bool wizardChoosen;
        public static bool assasinChoosen;
        bool isChoosen;

        public HeroMaker()
        {
            InitializeComponent();
        }

        private void HeroMaker_Load(object sender, EventArgs e)
        {
            continueButton.Visible = false;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Close();
            game.Show();
            
        }

        public void nameBox_TextChanged(object sender, EventArgs e)
        {
            nameBox.MaxLength = 10;

            if (string.IsNullOrEmpty(nameBox.Text) || !isChoosen || !Regex.IsMatch(nameBox.Text, "^[a-zA-Z][a-zA-Z]{3,}$"))
            {
                continueButton.Visible = false;
            }
            else
            {
                continueButton.Visible = true;
            }
            className = nameBox.Text;
        }

        public void wizardClass_Click(object sender, EventArgs e)
        {
            isChoosen = true;
            wizardClass.Location = new Point(309, 111);
            assasinClass.Visible = false;
            wizardChoosen = true;
        }

        public void assasinClass_Click(object sender, EventArgs e)
        {
            isChoosen = true;
            assasinClass.Location = new Point(309, 111);
            wizardClass.Visible = false;
            assasinChoosen = true;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            assasinClass.BackgroundImage = Image.FromFile(@"C:\Users\Deny\Documents\Visual Studio 2015\Projects\GameProject\GameProject\Resources\HoverAssasin.png");
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            assasinClass.BackgroundImage = Image.FromFile(@"C:\Users\Deny\Documents\Visual Studio 2015\Projects\GameProject\GameProject\Resources\LogoAssasin.png");
        }

        private void Mouse_LeaveWizard(object sender, EventArgs e)
        {
            wizardClass.BackgroundImage = Image.FromFile(@"C:\Users\Deny\Documents\Visual Studio 2015\Projects\GameProject\GameProject\Resources\LogoWizard.png");
        }

        private void Mouse_EnterWizard(object sender, EventArgs e)
        {
            wizardClass.BackgroundImage = Image.FromFile(@"C:\Users\Deny\Documents\Visual Studio 2015\Projects\GameProject\GameProject\Resources\HoverWizard.png");
        }
    }
}

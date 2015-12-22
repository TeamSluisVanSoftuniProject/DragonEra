using System;
using System.Windows.Forms;

namespace GameProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            HeroMaker heroMenu = new HeroMaker();
            this.Hide();
            heroMenu.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

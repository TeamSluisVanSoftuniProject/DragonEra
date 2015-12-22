using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameProject.Characters;

namespace GameProject.Forms
{
    public partial class Quest : Form
    {

        public Quest()
        {
            InitializeComponent();
        }

        public static bool accepted;
        public static bool completed;
        public static int LongwingCount;
        public static int EragonCount;
        public static int WyvernCount;

        private void Quest_Load(object sender, EventArgs e)
        {
            LongCount.Text = LongwingCount + " / 4";
            WyrnCount.Text = WyvernCount + " / 4";
            EraCount.Text = EragonCount + " / 4";
            CompleteButton.Enabled = false;

            if (accepted)
            {
                AcceptButton.Visible = false;
            }

            if (LongwingCount == 4 && EragonCount == 4 && WyvernCount == 4)
            {
                completed = true;
                CompleteButton.Enabled = true;
            }
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            Game.hero.Gold += 2000;
            MessageBox.Show("Good job! Quest completed. You earned: 2000 gold!");
            MessageBox.Show("You can enter Onyx's lair now. Get prepared!");
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            accepted = true;
            AcceptButton.Visible = false;
            CompleteButton.Enabled = false;         
            MessageBox.Show("Quest Accepted.");
            this.Close();
        }
    }
}

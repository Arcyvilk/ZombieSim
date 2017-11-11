using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieSim
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Main form of the game
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            MessageBox.Show(GameData.GameDescription,
                GameData.Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            GameData.fillUpgradeList();
            foreach (Upgrade u in GameData.Upgrades)
            {
                listBoxUpgrades.Items.Add(u.Name);
            }
            timerCount.Start();
        }
        /// <summary>
        /// Function responsible for the main timer of the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {
            if (!checkForWin())
            {
                GameData.Zombies.addZombies(GameData.Zombies.PerTick);
                textBoxZombieCount.Text = GameData.Zombies.Count.ToString();
                textBoxBrainsCount.Text = GameData.Zombies.BrainsCount.ToString();
                labelZombiesPerSecond.Text = GameData.Zombies.PerTick.ToString() + " zombies per second";
                labelZombiesPerClick.Text = GameData.Zombies.PerClick.ToString() + " zombies per click";
            }
        }
        private void buttonIncrementZombies_Click(object sender, EventArgs e)
        {
            if (!checkForWin())
            {
                GameData.Zombies.addZombies(GameData.Zombies.PerClick);
                textBoxZombieCount.Text = GameData.Zombies.Count.ToString();
                textBoxBrainsCount.Text = GameData.Zombies.BrainsCount.ToString();
            }
        }
        private bool checkForWin() {
            if (GameData.Zombies.Count >= 10)
            {
                timerCount.Stop();
                buttonIncrementZombies.Enabled = false;
                MessageBox.Show("Congratulations, you won the game! \n" +
                    "Whole humanity got succesfully converted into zombies. Are you happy with yourself?",
                    GameData.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}

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
            foreach (Upgrades u in GameData.Upgrades)
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
            GameData.Zombies.addZombies(GameData.Zombies.PerTick);
            labelZombieCount.Text = GameData.Zombies.Count.ToString();
            labelBrainsCount.Text = GameData.Zombies.BrainsCount.ToString();
            labelZombiesPerSecond.Text = GameData.Zombies.PerTick.ToString() + " zombies per second";
            labelZombiesPerClick.Text = GameData.Zombies.PerClick.ToString() + " zombies per click";
        }
        /// <summary>
        /// Changes the button's picture to buttonPushed after pressing LMB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxButton_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxButton.Image = ZombieSim.Properties.Resources.buttonPushed;
        }
        /// <summary>
        /// Changes the button's picture to buttonReady after pressing LMB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxButton_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxButton.Image = ZombieSim.Properties.Resources.buttonReady;
        }
        /// <summary>
        /// Obsługuje zdarzenia przypisane do pojedynczego przyciśnięcia przycisku (inkrementacja zombie)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxButton_Click(object sender, EventArgs e)
        {
            GameData.Zombies.addZombies(GameData.Zombies.PerClick);
            labelZombieCount.Text = GameData.Zombies.Count.ToString();
            labelBrainsCount.Text = GameData.Zombies.BrainsCount.ToString();
        }
    }
}

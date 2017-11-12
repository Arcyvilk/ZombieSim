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
        /// Main form of the game. Stuff triggering when the game gets started.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            GameData.fillUpgradeList();
            dataGridViewUpgrades.ColumnCount = 3;
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            dataGridViewUpgrades.Columns.Insert(0, imgColumn);
            foreach (Upgrade u in GameData.Upgrades)
            {
                object pic = ZombieSim.Properties.Resources.ResourceManager.GetObject(u.Picture);
                Image img = new Bitmap((Image)pic);
                DataGridViewRow row = new DataGridViewRow();
                dataGridViewUpgrades.Rows.Add(img, u.Name, u.Count, u.Cost);
            }
            timerCount.Start();
        }
        /// <summary>
        /// Function handling showing help contents after clicking butonHelp.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GameData.GameDescription,
                GameData.Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
                updateZombieAmounts();
            }
        }
        /// <summary>
        /// Function responsible for incrementing zombie count with every Big Red Button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!checkForWin()) //if the win condition wasn't met yet and the game can continue
            {
                GameData.Zombies.addZombies(GameData.Zombies.PerClick);
                pictureBoxButton.Image = ZombieSim.Properties.Resources.buttonPushed;
                updateZombieAmounts();
            }
        }
        /// <summary>
        /// Function responsible for changing picture for the Big Red Button every time with MouseUp event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxButton_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxButton.Image = ZombieSim.Properties.Resources.buttonReady;
        }
        /// <summary>
        /// Updates the amount of zombies/brains owned.
        /// </summary>
        private void updateZombieAmounts()
        {
            textBoxZombieCount.Text = GameData.Zombies.Count.ToString();
            textBoxBrainsCount.Text = GameData.Zombies.BrainsCount.ToString();
            labelZombiesPerSecond.Text = GameData.Zombies.PerTick.ToString() + " zombies per second";
            labelZombiesPerClick.Text = GameData.Zombies.PerClick.ToString() + " zombies per click";
        }
        /// <summary>
        /// Function checking if the win condition was fulfilled, and reacting if it was.
        /// </summary>
        /// <returns></returns>
        private bool checkForWin() {
            if (GameData.Zombies.Count >= 100)
            {
                timerCount.Stop();
                pictureBoxButton.Enabled = false;
                MessageBox.Show("Congratulations, you won the game! \n" +
                    "Whole humanity got succesfully converted into zombies. I hope you are happy with yourself.",
                    GameData.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Function handling clicking on the elements inside dataGridViewUpgrades.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUpgrades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GameData.Zombies.BrainsCount >= GameData.Upgrades[e.RowIndex].Cost)
                buyUpgrade(e.RowIndex);
        }
        /// <summary>
        /// Shows the desription of the upgrade after hovering your mouse over it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUpgrades_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string toolTipText = GameData.Upgrades[e.RowIndex].Description + "\n\nCurrent upgrade cost: "+GameData.Upgrades[e.RowIndex].Cost
                +"\n\nAmount of upgrades owned: "+GameData.Upgrades[e.RowIndex].Count;
            DataGridViewCell cell = this.dataGridViewUpgrades.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.ToolTipText = toolTipText;
        }
        /// <summary>
        /// Function handling what happens when you buy an upgrade.
        /// </summary>
        /// <param name="upgradeIndex"></param>
        private void buyUpgrade(int upgradeIndex) {
            Upgrade u = GameData.Upgrades[upgradeIndex];
            GameData.Zombies.PerClick += u.ZombiesPerClick;
            GameData.Zombies.PerTick += u.ZombiesPerTick;
            GameData.Zombies.BrainsCount -= u.Cost;
            double newCost = Math.Round(u.Cost * 1.2);
            u.Cost = Convert.ToInt64(newCost);
            u.Count++;
            updateZombieAmounts();
            dataGridViewUpgrades.Update();
        }
    }
}

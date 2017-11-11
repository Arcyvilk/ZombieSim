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
        /// Class storing the vague data on all the game's objects.
        /// </summary>
        public class GameData
        {
            public string Title { get; set; }
            public Zombies Zombies { get; set; }
            public Upgrades Upgrades { get; set; }
        }
        /// <summary>
        /// Class storing the data on the total amount of zombies there are in the game.
        /// </summary>
        public class Zombies
        {
            public int Count { get; set; } //amount of zombies had
            public int PerTick { get; set; } //ingrowth of zombies per second
            public Zombies(int count, int perTick)
            { //construtor
                Count = count;
                PerTick = perTick;
            }
        }
        public class Upgrades
        {
            public string Name { get; set; } //name of the upgrade
            public string Picture { get; set; } //picture of the upgrade
            public string Description { get; set; } //description of the upgrade
            public int Count { get; set; } //amount of the particular upgrade
            public int ZombiesPerTick { get; set; } //amount f zombie per second gien by this particular upgrade
            public Upgrades(string name, string picture, string description, int count, int zombiesPerTick)
            { //constructor
                Name = name;
                Picture = picture;
                Description = description;
                Count = count;
                ZombiesPerTick = zombiesPerTick;
            }
        }

        public FormMain()
        {
            InitializeComponent();
            Zombies zombies = new Zombies(0, 1);
            GameData gameData = new GameData();
            gameData.Zombies = zombies;

            MessageBox.Show("Every time you press a button, one person somewhere in the world gets turned into a zombie.\n" +
                "Your goal is to turn the whole humanity into zombies. Using brains (1 zombie = 1 brain), you can unlock unique upgrades which speed up this process.\n\n" +
                "Good luck!",
                gameData.Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            timerCount.Start();
        }
        /// <summary>
        /// Funkcja obsługująca zdarzenie pojedynczego ticku głównego timera gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Zmienia obrazek przycisku na buttonPushed po wciśnięciu lewego przycisku myszy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxButton_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxButton.Image = ZombieSim.Properties.Resources.buttonPushed;
        }
        /// <summary>
        /// Zmienia obrazek przycisku na buttonReady, kiedy przycisk zostaje zwolniony
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

        }
    }
}

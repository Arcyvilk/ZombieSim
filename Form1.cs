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
        public static class GameData
        {
            public static string Title { get; set; } = "Zombie Apocalypse Simulator";
            public static string GameDescription { get; set; } = "Every time you press a button," +
                "one person somewhere in the world gets turned into a zombie.\n" +
                "Your goal is to turn the whole humanity into zombies. " +
                "Using brains (1 zombie = 1 brain), you can unlock unique upgrades which speed up this process.\n\n" +
                "Good luck!";
            public static Zombies Zombies { get; set; } = new Zombies();
            public static Upgrades Viruses { get; set; } = 
                new Upgrades("Virus", "virus.png", "A simple virus to turn people into mindless carcasses.", 10, 0, 1, 0);
            public static Upgrades InfectedMongrels { get; set; } = 
                new Upgrades("Infected mongrel", "mongrel.png", "A homeless dog haunted by the disease. Warning, it bites!", 50, 0, 5, 0);
            public static Upgrades Vaccines { get; set; } = 
                new Upgrades("Vaccine causing zombizm", "vaccine.png", "Vaccine causing zombizm. You cannot say they didn't warn you.", 100, 0, 10, 0);
            public static Upgrades ToxicWastes { get; set; } = 
                new Upgrades("Toxic waste", "waste.png", "Toxic, radioactive wastes.", 400, 0, 20, 0);
            public static Upgrades MadScientists { get; set; } = 
                new Upgrades("Mad scientist", "scientist.png", "This nice scientist devoted his life to turn the whole humanity into zombies.", 1000, 0, 50, 0);
            public static Upgrades Altars { get; set; } = 
                new Upgrades("Altar for the Old Gods", "altar.png", "The Old Gods like altars and bloody sacrifices.", 2000, 0, 100, 0);
            public static List<Upgrades> Upgrades = new List<Upgrades>();
            public static void fillUpgradeList() {
                GameData.Upgrades.Add(GameData.Viruses);
                GameData.Upgrades.Add(GameData.InfectedMongrels);
                GameData.Upgrades.Add(GameData.Vaccines);
                GameData.Upgrades.Add(GameData.ToxicWastes);
                GameData.Upgrades.Add(GameData.MadScientists);
                GameData.Upgrades.Add(GameData.Altars);
            }
            static GameData(){
                Zombies.Count = 0;
                Zombies.PerTick = 0;
                Zombies.PerClick = 1;
            }
        }
        /// <summary>
        /// Class storing the data on the total amount of zombies there are in the game.
        /// </summary>
        public class Zombies
        {
            public int Count { get; set; } //amount of zombies had
            public int BrainsCount { get; set; } //amount of brains had
            public int PerTick { get; set; } //ingrowth of zombies per second
            public int PerClick { get; set; } //ingrowth of zombies per click
            public void addZombies(int number)
            {
                Count += number;
                BrainsCount += number;
            }
        }
        /// <summary>
        /// Class storing the data on the particular upgrades unlocked throrough the game
        /// </summary>
        public class Upgrades
        {
            public string Name { get; set; } //name of the upgrade
            public string Picture { get; set; } //picture of the upgrade
            public string Description { get; set; } //description of the upgrade
            public float Cost { get; set; } //cost of buying this upgrade
            public int Count { get; set; } //amount of the particular upgrade
            public int ZombiesPerTick { get; set; } //amount of zombie per second given by this particular upgrade
            public int ZombiesPerClick { get; set; } //amount of zombie per click given by this particular upgrade
            public Upgrades(string name, string picture, string description, float cost, int count, int zombiesPerTick, int zombiesPerClick)
            {
                Name = name;
                Picture = picture;
                Description = description;
                Cost = cost;
                Count = count;
                ZombiesPerTick = zombiesPerTick;
                ZombiesPerClick = zombiesPerClick;
            }
        }

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

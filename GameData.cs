using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSim
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
        public static void fillUpgradeList()
        {
            GameData.Upgrades.Add(GameData.Viruses);
            GameData.Upgrades.Add(GameData.InfectedMongrels);
            GameData.Upgrades.Add(GameData.Vaccines);
            GameData.Upgrades.Add(GameData.ToxicWastes);
            GameData.Upgrades.Add(GameData.MadScientists);
            GameData.Upgrades.Add(GameData.Altars);
        }
        static GameData()
        {
            Zombies.Count = 0;
            Zombies.PerTick = 0;
            Zombies.PerClick = 1;
        }
    }
}

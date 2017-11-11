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

        static Upgrade Virus = new Upgrade
        {
            Name = "Virus",
            Picture = "virus.png",
            Description = "A simple virus to turn people into mindless carcasses.",
            Cost = 10,
            Count = 0,
            ZombiesPerTick = 1,
            ZombiesPerClick = 0
        };
        static Upgrade InfectedMongrel = new Upgrade
        {
            Name = "Infected mongrel",
            Picture = "mongrel.png",
            Description = "A homeless dog haunted by the disease. Warning, it bites!",
            Cost = 50,
            Count = 0,
            ZombiesPerTick = 5,
            ZombiesPerClick = 0
        };
        static Upgrade Vaccine = new Upgrade
        {
            Name = "Vaccine causing zombizm",
            Picture = "vaccine.png",
            Description = "Vaccine causing zombizm. Do not pretend they didn't try to warn you.",
            Cost = 100,
            Count = 0,
            ZombiesPerTick = 10,
            ZombiesPerClick = 0
        };
        static Upgrade ToxicWastes = new Upgrade
        {
            Name = "Toxic waste",
            Picture = "waste.png",
            Description = "Tozic, radioactive wastes.",
            Cost = 400,
            Count = 0,
            ZombiesPerTick = 20,
            ZombiesPerClick = 0
        };
        static Upgrade MadScientist = new Upgrade
        {
            Name = "Mad scientist",
            Picture = "scientist.png",
            Description = "This nice scientist devoted his life to turn the whole humanity into zombies.",
            Cost = 1000,
            Count = 0,
            ZombiesPerTick = 50,
            ZombiesPerClick = 0
        };
        static Upgrade Altar = new Upgrade
        {
            Name = "Altar for the Old Gods",
            Picture = "altar.png",
            Description = "The Old Gods enjoy a nice altar and a bloody sacrifice.",
            Cost = 2000,
            Count = 0,
            ZombiesPerTick = 100,
            ZombiesPerClick = 0
        };

        public static List<Upgrade> Upgrades = new List<Upgrade>();

        public static void fillUpgradeList()
        {
            GameData.Upgrades.Add(GameData.Virus);
            GameData.Upgrades.Add(GameData.InfectedMongrel);
            GameData.Upgrades.Add(GameData.Vaccine);
            GameData.Upgrades.Add(GameData.ToxicWastes);
            GameData.Upgrades.Add(GameData.MadScientist);
            GameData.Upgrades.Add(GameData.Altar);
        }
        static GameData()
        {
            Zombies.Count = 0;
            Zombies.PerTick = 0;
            Zombies.PerClick = 1;
        }
    }
}

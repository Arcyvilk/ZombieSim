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
        public static string Title { get; set; } = "Zombie Apocalypse Simulator"; //title of the game
        /// <summary>
        /// Game description shown in the help file.
        /// </summary>
        public static string GameDescription { get; set; } = "Every time you press a button, " +
            "one person somewhere in the world gets turned into a zombie.\n" +
            "Your goal is to turn the whole humanity into zombies. " +
            "Using brains (1 zombie = 1 brain), you can unlock upgrades which speed up this process. "+
            "Every upgrade purchase will raise the price of the consecutive purchases of the same type by 25%!\n\n" +
            "Good luck!";
        public static Zombies Zombies { get; set; } = new Zombies();
    
    //UPGRADES

        /// <summary>
        /// Data structure of the "Virus" upgrade.
        /// </summary>
        static Upgrade Virus = new Upgrade
        {
            Name = "Virus",
            Picture = "virus",
            Description = "A simple virus to turn people into mindless carcasses.",
            OriginalCost = 10,
            CurrentCost = 10,
            Count = 0,
            ZombiesPerTick = 1,
            ZombiesPerClick = 0
        };
        /// <summary>
        /// Data structure of the "Virus" upgrade.
        /// </summary>
        static Upgrade ZombieHand = new Upgrade
        {
            Name = "Dead Hand",
            Picture = "hand",
            Description = "A rotting zombie hand that helps you clicking that Big Red Doom Button.",
            OriginalCost = 100,
            CurrentCost= 100,
            Count = 0,
            ZombiesPerTick = 0,
            ZombiesPerClick = 2
        };
        /// <summary>
        /// Data structure of the "Infected Mongrel" upgrade.
        /// </summary>
        static Upgrade InfectedMongrel = new Upgrade
        {
            Name = "Infected mongrel",
            Picture = "dog",
            Description = "A homeless dog haunted by the disease. Warning, it bites!",
            OriginalCost = 500,
            CurrentCost = 500,
            Count = 0,
            ZombiesPerTick = 10,
            ZombiesPerClick = 0
        };
        /// <summary>
        /// Data structure of the "Vaccine causing zombizm" upgrade.
        /// </summary>
        static Upgrade Vaccine = new Upgrade
        {
            Name = "Vaccine causing zombizm",
            Picture = "vaccine",
            Description = "Vaccine causing zombizm. Do not pretend they didn't try to warn you.",
            OriginalCost = 1000,
            CurrentCost = 1000,
            Count = 0,
            ZombiesPerTick = 25,
            ZombiesPerClick = 1
        };
        /// <summary>
        /// Data structure of the "Toxic waste" upgrade.
        /// </summary>
        static Upgrade ToxicWastes = new Upgrade
        {
            Name = "Toxic waste",
            Picture = "waste",
            Description = "Toxic, radioactive wastes.",
            OriginalCost = 5000,
            CurrentCost = 5000,
            Count = 0,
            ZombiesPerTick = 50,
            ZombiesPerClick = 0
        };
        /// <summary>
        /// Data structure of the "Mad Scientist" upgrade.
        /// </summary>
        static Upgrade MadScientist = new Upgrade
        {
            Name = "Mad scientist",
            Picture = "scientist",
            Description = "This nice scientist devoted his life to turn the whole humanity into zombies.",
            OriginalCost = 10000,
            CurrentCost = 10000, 
            Count = 0,
            ZombiesPerTick = 100,
            ZombiesPerClick = 5
        };
        /// <summary>
        /// Data structure of the "Altar" upgrade.
        /// </summary>
        static Upgrade Altar = new Upgrade
        {
            Name = "Altar for the Old Gods",
            Picture = "virus", //change this one
            Description = "The Old Gods enjoy a nice altar and a bloody sacrifice.",
            OriginalCost = 50000,
            CurrentCost = 50000,
            Count = 0,
            ZombiesPerTick = 250,
            ZombiesPerClick = 10
        };

        /// <summary>
        /// List containing all the Upgrade objects.
        /// </summary>
        public static List<Upgrade> Upgrades = new List<Upgrade>();

        /// <summary>
        /// Function filling the Upgrades List with all the available upgrade objects.
        /// </summary>
        public static void fillUpgradeList()
        {
            GameData.Upgrades.Add(GameData.Virus);
            GameData.Upgrades.Add(GameData.ZombieHand);
            GameData.Upgrades.Add(GameData.InfectedMongrel);
            GameData.Upgrades.Add(GameData.Vaccine);
            GameData.Upgrades.Add(GameData.ToxicWastes);
            GameData.Upgrades.Add(GameData.MadScientist);
            GameData.Upgrades.Add(GameData.Altar);
        }

        //CITIES
        static City Monako = new City
        {
            Name = "Monako",
            Population = 36950
        };
        static City Radom = new City
        {
            Name = "Radom",
            Population = 219703
        };
        static City Wroclaw = new City
        {
            Name = "Wrocław",
            Population = 637683
        };
        static City Belgrad = new City
        {
            Name = "Belgrad",
            Population = 1166763
        };
        static City Paris = new City
        {
            Name = "Paryż",
            Population = 2229621
        };
        static City NewYork = new City
        {
            Name = "Nowy Jork",
            Population = 8537673
        };
        static City Poland = new City
        {
            Name = "Polska",
            Population = 38634007
        };
        static City Russia = new City
        {
            Name = "Rosja",
            Population = 144463451
        };
        static City UnitedStates = new City
        {
            Name = "Stany Zjednoczone",
            Population = 325365189
        };
        static City Europe = new City
        {
            Name = "Europa",
            Population = 741447158
        };
        static City China = new City
        {
            Name = "Chiny",
            Population = 1403500365
        };
        static City Asia = new City
        {
            Name = "Azja",
            Population = 4462676731
        };
        static City AllButAustralia = new City
        {
            Name = "wszystko oprócz Australii",
            Population = 7575286600
        };
        static City World = new City
        {
            Name = "świat",
            Population = 7600000000
        };
        public static List<City> CityList = new List<City>(); //list storing all the cities inside

        /// <summary>
        /// Function filling the City list with the cities.
        /// </summary>
        public static void fillCityList()
        {
            CityList.Add(Monako);
            CityList.Add(Radom);
            CityList.Add(Wroclaw);
            CityList.Add(Belgrad);
            CityList.Add(Paris);
            CityList.Add(NewYork);
            CityList.Add(Poland);
            CityList.Add(Russia);
            CityList.Add(UnitedStates);
            CityList.Add(Europe);
            CityList.Add(China);
            CityList.Add(Asia);
            CityList.Add(AllButAustralia);
            CityList.Add(World);
        }
    }
}

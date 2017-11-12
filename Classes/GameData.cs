using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSim
{
    /// <summary>
    /// Klasa przechowująca najważniejsze informace o stanie gry.
    /// </summary>
    public static class GameData
    {
        /// <summary>
        /// Tytuł gry.
        /// </summary>
        public static string Title { get; set; } = "Symulator Zombie Apokalisy";
        /// <summary>
        /// Opis gry (pokazywany w pliku pomocy)
        /// </summary>
        public static string GameDescription { get; set; } = "Za każdym razem, kiedy wciskasz Wielki Czerwony Przycisk Zagłady, " +
            "jedna osoba gdzieś na świecie zmienia się w zombie.\n" +
            "Twoim celem jest zamienienie w zombie całej ludzkości. " +
            "Używając mózgów (jeden zombie dropi jeden mózg), będziesz odblokowywać ulepszenia przyspieszające ten proces "+
            "(każde kupione ulepszenie zwiększa koszt kolejnych o 25%).\n\n" +
            "Po drodze możesz też odblokowywać unikalne osiągnięcia.\n\n"+
            "Powodzenia!";
        public static Zombies Zombies { get; set; } = new Zombies();
    
    //ULEPSZENIA

        /// <summary>
        /// Struktura danych ulepszenia "Virus".
        /// </summary>
        static Upgrade Virus = new Upgrade
        {
            Name = "Wirus",
            Picture = "virus",
            Description = "Prosty wirus zmieniający ludzi w bezmyślne żywe trupy.",
            OriginalCost = 10,
            CurrentCost = 10,
            Count = 0,
            ZombiesPerTick = 1,
            ZombiesPerClick = 0
        };
        /// <summary>
        /// Struktura danych ulepszenia "ZombieHand".
        /// </summary>
        static Upgrade ZombieHand = new Upgrade
        {
            Name = "Martwa łapa",
            Picture = "hand",
            Description = "Gnijąca łapa zombie pomagająca Ci klikać w ten Wielki Czerwony Przycisk Zagłady.",
            OriginalCost = 100,
            CurrentCost= 100,
            Count = 0,
            ZombiesPerTick = 0,
            ZombiesPerClick = 2
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "InfectedMongrel".
        /// </summary>
        static Upgrade InfectedMongrel = new Upgrade
        {
            Name = "Zainfekowany kundel",
            Picture = "dog",
            Description = "Bezdomny dog opanowany przez zombiezarazę. Uwaga, gryzie!",
            OriginalCost = 500,
            CurrentCost = 500,
            Count = 0,
            ZombiesPerTick = 10,
            ZombiesPerClick = 0
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "Vaccine".
        /// </summary>
        static Upgrade Vaccine = new Upgrade
        {
            Name = "Szczepionka powodująca zombizm",
            Picture = "vaccine",
            Description = "Szczepionka powodujaca zombizm. Nie próbuj udawać, że Cię nie ostrzegali.",
            OriginalCost = 1000,
            CurrentCost = 1000,
            Count = 0,
            ZombiesPerTick = 25,
            ZombiesPerClick = 1
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "ToxicWastes".
        /// </summary>
        static Upgrade ToxicWastes = new Upgrade
        {
            Name = "Toksyczne odpady",
            Picture = "waste",
            Description = "Stos paskudnych, radioaktywnych odpadów. Skąd to się w ogóle bierze?",
            OriginalCost = 5000,
            CurrentCost = 5000,
            Count = 0,
            ZombiesPerTick = 50,
            ZombiesPerClick = 0
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "MadScientist".
        /// </summary>
        static Upgrade MadScientist = new Upgrade
        {
            Name = "Szalony naukowiec",
            Picture = "scientist",
            Description = "Ten przemiły staruszek poświecił swoje życie badaniom nad obracaniem ludzi w bezmózgie żywe trupy.",
            OriginalCost = 10000,
            CurrentCost = 10000, 
            Count = 0,
            ZombiesPerTick = 100,
            ZombiesPerClick = 5
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "Altar".
        /// </summary>
        static Upgrade Altar = new Upgrade
        {
            Name = "Ołtarz Pastarych Bogów",
            Picture = "elder",
            Description = "Prastarzy Bogowie bardzo chętnie pomogą Ci w sianiu zarazy zombie za drobną ceną krwawej ofiary.",
            OriginalCost = 50,
            CurrentCost = 50,
            Count = 0,
            ZombiesPerTick = 250,
            ZombiesPerClick = 10
        };

        /// <summary>
        /// Lista gromadząca wszystkie obiekty typu Upgrade.
        /// </summary>
        public static List<Upgrade> UpgradeList = new List<Upgrade>();

        /// <summary>
        /// Funkcja wypełniająca listę UpgradeList wszystkimi dostępnymi obiektami typu Upgrade.
        /// </summary>
        public static void fillUpgradeList()
        {
            GameData.UpgradeList.Add(GameData.Virus);
            GameData.UpgradeList.Add(GameData.ZombieHand);
            GameData.UpgradeList.Add(GameData.InfectedMongrel);
            GameData.UpgradeList.Add(GameData.Vaccine);
            GameData.UpgradeList.Add(GameData.ToxicWastes);
            GameData.UpgradeList.Add(GameData.MadScientist);
            GameData.UpgradeList.Add(GameData.Altar);
        }

    //MIASTA

        /// <summary>
        /// Struktura danych wszystkich miast.
        /// </summary>
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

        /// <summary>
        /// Lista gromadząca wszystkie obiekty typu City.
        /// </summary>
        public static List<City> CityList = new List<City>();

        /// <summary>
        /// Funkcja wypełniająca listę CityList wszystkimi dostępnymi obiektami typu City.
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

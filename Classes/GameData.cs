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
        static Upgrade virus = new Upgrade
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
        static Upgrade zombieHand = new Upgrade
        {
            Name = "Martwa łapa",
            Picture = "hand",
            Description = "Gnijąca łapa zombie pomagająca Ci klikać w ten Wielki Czerwony Przycisk Zagłady.",
            OriginalCost = 100,
            CurrentCost= 100,
            Count = 0,
            ZombiesPerTick = 0,
            ZombiesPerClick = 3
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "InfectedMongrel".
        /// </summary>
        static Upgrade infectedMongrel = new Upgrade
        {
            Name = "Zainfekowany kundel",
            Picture = "dog",
            Description = "Bezdomny dog opanowany przez zombiezarazę. Uwaga, gryzie!",
            OriginalCost = 250,
            CurrentCost = 250,
            Count = 0,
            ZombiesPerTick = 10,
            ZombiesPerClick = 0
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "Vaccine".
        /// </summary>
        static Upgrade vaccine = new Upgrade
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
        static Upgrade toxicWastes = new Upgrade
        {
            Name = "Toksyczne odpady",
            Picture = "waste",
            Description = "Stos paskudnych, radioaktywnych odpadów. Skąd to się w ogóle wzięło?",
            OriginalCost = 2500,
            CurrentCost = 2500,
            Count = 0,
            ZombiesPerTick = 50,
            ZombiesPerClick = 0
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "Expired Food".
        /// </summary>
        static Upgrade expiredFood = new Upgrade
        {
            Name = "Nieświeży burger",
            Picture = "food",
            Description = "Te hamburgery nie dość, że przeterminowane, to jeszcze zawierają w sobie zombie drobnoustroje. Gdzie jest Sanepid?",
            OriginalCost = 5000,
            CurrentCost = 5000,
            Count = 0,
            ZombiesPerTick = 100,
            ZombiesPerClick = 10
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "MadScientist".
        /// </summary>
        static Upgrade madScientist = new Upgrade
        {
            Name = "Szalony naukowiec",
            Picture = "scientist",
            Description = "Ten przemiły staruszek poświecił swoje życie badaniom nad obracaniem ludzi w bezmózgie żywe trupy.",
            OriginalCost = 8000,
            CurrentCost = 8000, 
            Count = 0,
            ZombiesPerTick = 250,
            ZombiesPerClick = 25
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "Satellite".
        /// </summary>
        static Upgrade satellite = new Upgrade
        {
            Name = "Zombie satelita",
            Picture = "satellite",
            Description = "Ta satelita okrąża Ziemię i atakuje mózgi jeszcze żywych ludzi za pomocą fal elektromagnetycznych.",
            OriginalCost = 12500,
            CurrentCost = 12500,
            Count = 0,
            ZombiesPerTick = 500,
            ZombiesPerClick = 50
        };
        /// <summary>
        /// Struktura danych ulepszenia o nazwie "Altar".
        /// </summary>
        static Upgrade altar = new Upgrade
        {
            Name = "Ołtarz Prastarych Bogów",
            Picture = "elder",
            Description = "Prastarzy Bogowie bardzo chętnie pomogą Ci w sianiu zarazy zombie za drobną ceną krwawej ofiary.",
            OriginalCost = 20000,
            CurrentCost = 20000,
            Count = 0,
            ZombiesPerTick = 1000,
            ZombiesPerClick = 100
        };

        /// <summary>
        /// Lista gromadząca wszystkie obiekty typu Upgrade.
        /// </summary>
        public static List<Upgrade> upgradeList = new List<Upgrade>();

        /// <summary>
        /// Funkcja wypełniająca listę upgradeList wszystkimi dostępnymi obiektami typu Upgrade.
        /// </summary>
        public static void fillupgradeList()
        {
            GameData.upgradeList.Add(GameData.virus);
            GameData.upgradeList.Add(GameData.zombieHand);
            GameData.upgradeList.Add(GameData.infectedMongrel);
            GameData.upgradeList.Add(GameData.vaccine);
            GameData.upgradeList.Add(GameData.toxicWastes);
            GameData.upgradeList.Add(GameData.expiredFood);
            GameData.upgradeList.Add(GameData.madScientist);
            GameData.upgradeList.Add(GameData.satellite);
            GameData.upgradeList.Add(GameData.altar);
        }

    //MIASTA

        /// <summary>
        /// Struktura danych wszystkich miast.
        /// </summary>
        static City monako = new City
        {
            Name = "Monako",
            Population = 36950
        };
        static City radom = new City
        {
            Name = "Radom",
            Population = 219703
        };
        static City wroclaw = new City
        {
            Name = "Wrocław",
            Population = 637683
        };
        static City belgrad = new City
        {
            Name = "Belgrad",
            Population = 1166763
        };
        static City paris = new City
        {
            Name = "Paryż",
            Population = 2229621
        };
        static City newYork = new City
        {
            Name = "Nowy Jork",
            Population = 8537673
        };
        static City poland = new City
        {
            Name = "Polska",
            Population = 38634007
        };
        static City russia = new City
        {
            Name = "Rosja",
            Population = 144463451
        };
        static City unitedStates = new City
        {
            Name = "Stany Zjednoczone",
            Population = 325365189
        };
        static City europe = new City
        {
            Name = "Europa",
            Population = 741447158
        };
        static City china = new City
        {
            Name = "Chiny",
            Population = 1403500365
        };
        static City asia = new City
        {
            Name = "Azja",
            Population = 4462676731
        };
        static City allButAustralia = new City
        {
            Name = "wszystko oprócz Australii",
            Population = 7575286600
        };
        static City world = new City
        {
            Name = "świat",
            Population = 7600000000
        };

        /// <summary>
        /// Lista gromadząca wszystkie obiekty typu City.
        /// </summary>
        public static List<City> cityList = new List<City>();

        /// <summary>
        /// Funkcja wypełniająca listę cityList wszystkimi dostępnymi obiektami typu City.
        /// </summary>
        public static void fillcityList()
        {
            cityList.Add(monako);
            cityList.Add(radom);
            cityList.Add(wroclaw);
            cityList.Add(belgrad);
            cityList.Add(paris);
            cityList.Add(newYork);
            cityList.Add(poland);
            cityList.Add(russia);
            cityList.Add(unitedStates);
            cityList.Add(europe);
            cityList.Add(china);
            cityList.Add(asia);
            cityList.Add(allButAustralia);
            cityList.Add(world);
        }
    }
}

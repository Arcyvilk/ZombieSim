using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSim
{
    /// <summary>
    /// Klasa przechowująca dane o liczbach zombie/zombie na klika/zombie na sekundę/mózgów.
    /// </summary>
    public class Zombies
    {
        public long Count { get; set; } = 0; //liczba posiadanych zombie
        public long BrainsCount { get; set; } = 0;//liczba posiadanych mózgów
        public long OldCount { get; set; } = 0; //liczba zombie, które gracz posiadał w poprzednim ticku
        public long PerTick { get; set; } = 0; //zombie na sekundę
        public long PerClick { get; set; } = 1; //zombie na klika

        /// <summary>
        /// Funkcja odpowiedzialna za inkrementację liczby zombie (na seukndę lub na klika)
        /// </summary>
        /// <param name="number"></param>
        public void addZombies(long number)
        {
            OldCount = Count;
            Count += number;
            BrainsCount += number;
        }
    }
}

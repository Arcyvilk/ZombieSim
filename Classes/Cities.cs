using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSim
{
    /// <summary>
    /// Klasa przechowująca informacje o miastach, które mogą zostać odblokowane w trakcie gry poprzez ich zniszczenie
    /// </summary>
    public class City
    {
        public string Name { get; set; } //nazwa miasta
        public long Population { get; set; } //populacja miasta 
        public bool Unlocked { get; set; } = false; //miasto odblokowuje się, jeśli twoja całkowita liczba zombie przekracza liczbę populacji miasta
    }
}

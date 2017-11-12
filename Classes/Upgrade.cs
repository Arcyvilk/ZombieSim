using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSim
{
    /// <summary>
    /// Klasa przechowująca dane ulepszeń odblokowywanych w trakcie gry.
    /// </summary>
    public class Upgrade
    {
        public string Picture { get; set; } //obrazek przypisany do ulepszenia (nazwa kieruje do Properties.Resources)
        public string Name { get; set; } //nazwa ulepszenia
        public string Description { get; set; } //krótki opis ulepszenia
        public int Count { get; set; } //wykupiona ilość tego ulepszenia
        public long OriginalCost { get; set; } //wstępny koszt ulepszenia
        public long CurrentCost { get; set; } //obecny koszt ulepszenia (koszt zwiększa się o 25% z każdym kolejnym kupionym ulepszeniem)
        public int ZombiesPerTick { get; set; } //liczba zombie na sekundę dawana przez to ulepszenie
        public int ZombiesPerClick { get; set; } //liczba zombie na klika dawana przez to ulepszenie
    }
}

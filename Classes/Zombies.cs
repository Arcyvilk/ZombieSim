using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSim
{
    /// <summary>
    /// Class storing the data on the total amount of zombies there are in the game.
    /// </summary>
    public class Zombies
    {
        public long Count { get; set; } = 0; //amount of zombies had
        public long BrainsCount { get; set; } = 0;//amount of brains had
        public long PerTick { get; set; } = 0; //ingrowth of zombies per second
        public long PerClick { get; set; } = 1; //ingrowth of zombies per click

        /// <summary>
        /// Function responsible for incrementing the zombie count, be it by click, be it by timer tick.
        /// </summary>
        /// <param name="number"></param>
        public void addZombies(long number)
        {
            Count += number;
            BrainsCount += number;
        }
    }
}

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
        public int Count { get; set; } = 0; //amount of zombies had
        public int BrainsCount { get; set; } = 0;//amount of brains had
        public int PerTick { get; set; } = 0; //ingrowth of zombies per second
        public int PerClick { get; set; } = 1; //ingrowth of zombies per click

        public void addZombies(int number)
        {
            Count += number;
            BrainsCount += number;
        }
    }
}

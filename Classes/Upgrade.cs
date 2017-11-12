using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSim
{
    /// <summary>
    /// Class storing the data on the particular upgrades unlocked throrough the game
    /// </summary>
    public class Upgrade
    {
        public string Picture { get; set; } //picture of the upgrade
        public string Name { get; set; } //name of the upgrade
        public string Description { get; set; } //description of the upgrade
        public int Count { get; set; } //amount of the particular upgrade
        public long OriginalCost { get; set; } //initial cost of buying this upgrade
        public long CurrentCost { get; set; } //cost of buying this upgrade after applying the multiplier
        public int ZombiesPerTick { get; set; } //amount of zombie per second given by this particular upgrade
        public int ZombiesPerClick { get; set; } //amount of zombie per click given by this particular upgrade
    }
}

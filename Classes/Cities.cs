using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSim
{
    /// <summary>
    /// Class storing the population numbers of some chosen countries.
    /// </summary>
    public class City
    {
        public string Name { get; set; }
        public long Population { get; set; }
        public bool Unlocked { get; set; } = false;
    }
}

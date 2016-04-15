using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class Species
    {
        public string goal { get; set; }
        public double population { get; set; }
        public string language { get; set; }
        public bool hasTail { get; set; }
        public bool wearsClothing { get; set; }
        public string economy { get; set; }
        public string habitat { get; set; }
        public Spaceship ship { get; set; }
        public string weapon { get; set; }
        public virtual void speak()
        {
            Console.WriteLine("Time for tea");
        }
    }
}
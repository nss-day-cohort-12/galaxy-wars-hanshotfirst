using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    public class Species
    {
        public string goal { get; set; }
        public double population { get; set; }
        public string language { get; set; }
        public bool hasTail { get; set; }
        public bool wearsClothing { get; set; }
        public bool isCute { get; set; }
        public string economy { get; set; }
        public string habitat { get; set; }
        public Spaceship ship { get; set; }
        public string weapon { get; set; }

        public virtual void speak()  // virtual method; can be overridden (see Tusken.cs)
        {
            Console.WriteLine("Time for tea");
        }
        public virtual void speak(string sayWhat)  // overloading the method speak() with a new signature
        {
            Console.WriteLine(sayWhat);
        }
        public virtual void speak(string sayWhat, int repeat)  // overloading the method speak() with a new signature
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(sayWhat);
            }
        }
    }
}
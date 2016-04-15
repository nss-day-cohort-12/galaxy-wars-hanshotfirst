using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class Jawa : Species, ISpacefaring
    {
        public bool utini = true;

        public bool hasScience
        {
            get
            {
                return hasScience;
            }

            set
            {
                hasScience = true;
            }
        }

        public string Spaceship
        {
            get
            {
                return Spaceship;
            }

            set
            {
                Spaceship = "frigate";
            }
        }
    }
}
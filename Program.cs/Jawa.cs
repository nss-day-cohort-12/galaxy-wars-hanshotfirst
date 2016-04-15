using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class Jawa : Species, ISpacefaring
    {
        // properties unique to Jawas
        public bool utini;
        public bool sneaky;
        public void launchArmada()
        {

        }
        public void developTechnology()
        {

        }


        // constructor
        public Jawa()
        {
            this.utini = true;
            this.language = "Jawanese";  // property inherited from Species
            this.sneaky = true;
            this.weapon = "stun gun";    // property inherited from Species
            this.economy = "scavenging";  // property inherited from Species

            this.ship = new Spaceship();
            this.ship.shipClass = "frigate";
            this.ship.size = "relatively small";
            this.ship.name = "lowassa";
        }
    }
}
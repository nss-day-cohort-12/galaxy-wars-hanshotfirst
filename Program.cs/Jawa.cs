using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    public class Jawa : Species, ISpacefaring
    {
        // properties unique to Jawas
        public bool utini;
        public bool sneaky;

        // properties/methods to satisfy ISpacefaring interface
        public bool hasScience { get; set; }
        public bool prefersStarTrekToStarWars { get; set; }
        public void launchArmada() { }
        public void developTechnology() { }

        // constructor
        public Jawa()
        {
            this.prefersStarTrekToStarWars = false;
            this.hasScience = true;
            this.utini = true;
            this.language = "Jawanese";  // property inherited from Species
            this.sneaky = true;
            this.weapon = "stun gun";    // property inherited from Species
            this.economy = "scavenging";  // property inherited from Species
            this.isCute = true;  // property inherited from Species
            this.hasTail = false;  // property inherited from Species
            this.wearsClothing = true;  // property inherited from Species
            this.goal = "science";  // property inherited from Species

            this.ship = new Spaceship();
            this.ship.shipClass = "frigate";
            this.ship.size = "relatively small";
            this.ship.name = "lowassa";
            this.ship.weaponDamage = 32000;
            this.ship.shields = 32000;
        }
    }
}
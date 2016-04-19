using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    public class Hutt : Species, IReligious
    {
        // https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/master/1-foundations/resources/FND_CONSTRUCTOR_METHOD.md
        
        // properties/methods that satisfy IReligious interface
        public string totem { get; set; }
        public string deity { get; set;  }
        public void pray() { }
        public void crusade() { }

        // constructor
        public Hutt()
        {
            this.totem = "wallet";
            this.deity = "Mammon";
            this.weapon = "halitosis";  // property inherited from Species
            this.language = "Huttese";  // property inherited from Species
            this.economy = "racketeering";  // property inherited from Species
            this.isCute = false;  // property inherited from Species
            this.hasTail = true;  // property inherited from Species
            this.wearsClothing = false;  // property inherited from Species
            this.goal = "religion";  // property inherited from Species

            this.ship = new Spaceship();
            this.ship.shipClass = "space barge";
            this.ship.size = "big";
            this.ship.name = "pankpa";
            this.ship.weaponDamage = 37000;
            this.ship.shields = 21000;
        }

    }
}
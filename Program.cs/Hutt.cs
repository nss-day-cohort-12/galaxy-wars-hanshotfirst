using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class Hutt : Species, IReligious
    {
        // https://github.com/nashville-software-school/csharp-dotnet-milestones/blob/master/1-foundations/resources/FND_CONSTRUCTOR_METHOD.md
        
        // properties unique to Hutts
        public string totem { get; set; }
        public string deity { get; set; }

        // constructor
        public Hutt()
        {
            this.totem = "wallet";
            this.deity = "Filthy Lucre";
            this.weapon = "halitosis";  // property inherited from Species
            this.language = "Huttese";  // property inherited from Species
            this.economy = "racketeering";  // property inherited from Species

            this.ship = new Spaceship();
            this.ship.shipClass = "space barge";
            this.ship.size = "big";
            this.ship.name = "pankpa";
        }

        string IReligious.totem
        {
            get
            {
                return totem;
            }

            set
            {
                totem = "credits";
            }
        }

        string IReligious.deity
        {
            get
            {
                return deity;
            }

            set
            {
                deity = "Filthy Lucre";
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class Tusken : Species, IWarrior
    {
        public string weapon = "gaffi stick";
        public string battleCry = "ooorooorooor";
        public string goal = "warfare";
        public string language = "Tusken";

        string IWarrior.weapon
        {
            get
            {
                return weapon;
            }

            set
            {
                weapon = "gaffi stick";
            }
        }

        string IWarrior.battleCry
        {
            get
            {
                return battleCry;
            }

            set
            {
                battleCry = "ooorooorooor";
            }
        }
    }
}

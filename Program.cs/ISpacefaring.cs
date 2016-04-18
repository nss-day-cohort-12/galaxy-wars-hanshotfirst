using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    interface ISpacefaring
    {
        bool hasScience { get; set; }
        bool prefersStarTrekToStarWars { get; set; }
        void launchArmada();
        void developTechnology();
    }
}

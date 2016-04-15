using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    interface ISpacefaring
    {
        string Spaceship { get; set; }
        bool hasScience { get; set; }
    }
}

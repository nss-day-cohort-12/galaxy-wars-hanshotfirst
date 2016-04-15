using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    interface IWarrior
    {
        string weapon { get; set; }
        string battleCry { get; set; }
    }
}

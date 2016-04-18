using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    interface IWarrior
    {
        string battleCry { get; set; }
        bool bloodthirsty { get; set; }
        void yell();
        void sneakAttack();
    }
}

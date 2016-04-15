using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class Hutt : Species, IReligious
    {
        public int wealth { get; set; }
        public string totem = "wallet";
        public string deity;

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
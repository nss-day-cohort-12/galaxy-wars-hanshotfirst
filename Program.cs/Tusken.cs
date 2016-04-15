using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class Tusken : Species, IWarrior
    {
        // properties unique to Tuskens
        public string battleCry;
        public void yell()
        {
            Console.WriteLine(battleCry);
        }
        public void sneakAttack()
        {
            Console.WriteLine("Tusken sneak attack!!");
        }
        public override void speak()
        {
            Console.WriteLine("yaaarrk ark ark ark");
        }

        // constructor
        public Tusken()
        {
            this.weapon = "gaffi stick";  // property inherited from Species
            this.battleCry = "ooorooorooor";
            this.goal = "warfare";  // property inherited from Species
            this.language = "Tusken";  // property inherited from Species
            this.economy = "feudal warfare";  // property inherited from Species

            this.ship = new Spaceship();
            this.ship.shipClass = "rust bucket";
            this.ship.size = "medium";
            this.ship.name = "arrghgark";
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class Tusken : Species, IWarrior
    {
        // properties/methods to satisfy IWarrior interface
        public string battleCry { get; set; }
        public bool bloodthirsty { get; set; }
        public void yell()
        {
            Console.WriteLine(battleCry);
        }
        public void sneakAttack()
        {
            Console.WriteLine("Tusken sneak attack!!");
        }
        public override void speak()  // overrides default method speak() from Species
        {
            Console.WriteLine("yaaarrk ark ark ark");
        }
        public override void speak(string foo)  // overrides default method speak(string) from Species
        {
            Console.WriteLine("brark yark aie aie aie");
        }

        // constructor
        public Tusken()
        {
            this.bloodthirsty = true;
            this.weapon = "gaffi stick";  // property inherited from Species
            this.battleCry = "ooorooorooor";
            this.goal = "warfare";  // property inherited from Species
            this.language = "Tusken";  // property inherited from Species
            this.economy = "feudal warfare";  // property inherited from Species
            this.isCute = false;  // property inherited from Species
            this.hasTail = false;  // property inherited from Species
            this.wearsClothing = true;  // property inherited from Species

            this.ship = new Spaceship();
            this.ship.shipClass = "rust bucket";
            this.ship.size = "medium";
            this.ship.name = "arrghgark";
            this.ship.weaponDamage = 300;
            this.ship.shields = 200;
        }

        
    }
}

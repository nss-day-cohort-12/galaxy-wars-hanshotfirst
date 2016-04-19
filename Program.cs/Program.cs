using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    public class Program
    {

        static public void Main(string[] args)
        {
            Random random = new Random();

            Tusken tusken = new Tusken();
            tusken.population = 1000000;
            Console.WriteLine("Tuskens have goal: {0}", tusken.goal);
            Console.WriteLine("A Tusken ship is called a " + tusken.ship.name);

            Hutt hutt = new Hutt();
            hutt.population = 1000000;
            Console.WriteLine("The Hutts, a religious species, worship {0}.", hutt.deity);
            Console.WriteLine("A Hutt ship is called a " + hutt.ship.name);

            Jawa jawa = new Jawa();
            jawa.population = 1000000;
            Console.WriteLine("A Jawa ship is called a " + jawa.ship.name);

            Console.WriteLine("\nJabba says:");
            hutt.speak();
            hutt.speak("Koonyah mahlyass koong! Ees too rong tah oong jedi mind trick!");
            hutt.speak("Ka cheesa crispa Greedo?", 3);
            Console.WriteLine("\nA random Jawa chimes in:");
            jawa.speak();
            jawa.speak("Utini!", 3);
            Console.WriteLine("\nQuoth the Tusken:");
            tusken.speak();  // Tusken overrides default speak() from Species
            tusken.speak("Nevermore");  // speak(parameter) will also be overridden

            bool gameOn = true;
            int year = 2100;
            while (gameOn)
            {
                Console.WriteLine("Year: " + year);
                var xx = gameRound(random, year, jawa, tusken, hutt);
                jawa.population = xx[0];
                tusken.population = xx[1];
                hutt.population = xx[2];
                Console.Write("  new Jawa pop = {0}\n", xx[0]);
                Console.Write("  new Tusken pop = {0}\n", xx[1]);
                Console.Write("  new Hutt pop = {0}\n", xx[2]);

                // check for game over
                if ( jawa.population <= 0 && tusken.population <= 0 && hutt.population <= 0)
                {
                    Console.WriteLine("The scourge of war has devastated all three populations.\n");
                    gameOn = false;
                }
                else if ( jawa.population <= 0 && tusken.population <= 0)
                {
                    Console.WriteLine("Hutts rule the solar system.\n");
                    gameOn = false;
                }
                else if (jawa.population <= 0 && hutt.population <= 0)
                {
                    Console.WriteLine("Tuskens rule the solar system.\n");
                    gameOn = false;
                }
                else if (tusken.population <= 0 && hutt.population <= 0)
                {
                    Console.WriteLine("Jawas rule the solar system.\n");
                    gameOn = false;
                }

                year++;
           }

        }
        Jawa jawa = new Jawa();
        Tusken tusken = new Tusken();
        Hutt hutt = new Hutt();

        static public List<double> gameRound(Random random, int year, Jawa jawa, Tusken tusken, Hutt hutt)
        {
            bool scienceBeatsReligion = true;
            bool religionBeatsWarfare = true;
            bool warfareBeatsScience = true;

            int yearsToReverse = 1;

            if (year % yearsToReverse == 0)
            {
                // one rule gets reversed every yearsToReverse years
                int randomNumber = random.Next(0, 3);
                Console.WriteLine("A space-time anomaly reverses rule " + randomNumber + "!");
                switch (randomNumber)
                {
                    case 0:
                        scienceBeatsReligion = false;
                        break;
                    case 1:
                        religionBeatsWarfare = false;
                        break;
                    case 2:
                        warfareBeatsScience = false;
                        break;
                    default:
                        break;
                }
            }

            // each species loses 20000
            jawa.population -= 20000;
            tusken.population -= 20000;
            hutt.population -= 20000;
            // spacefaring recovers 8000
            jawa.population += 8000;
            // additional 10000 religious killed by warfare
            hutt.population -= 10000;
            // additional 10000 science killed by warfare
            jawa.population -= 10000;
            // warfare loses 2500
            tusken.population -= 2500;
            // religious gets, and warfare loses, 1% of warfare pop
            hutt.population += tusken.population * 0.01;
            tusken.population *= 0.99;
            // religious gets, and science loses, 1% of science pop
            hutt.population += jawa.population * 0.01;
            jawa.population *= 0.99;

           
                jawa.population -= hutt.ship.weaponDamage-jawa.ship.shields;            
                jawa.population -= tusken.ship.weaponDamage - jawa.ship.shields;        
                hutt.population -= tusken.ship.weaponDamage - hutt.ship.shields;        
                hutt.population -= jawa.ship.weaponDamage - hutt.ship.shields;  
                tusken.population -= hutt.ship.weaponDamage - tusken.ship.shields;         
                tusken.population -= jawa.ship.weaponDamage - tusken.ship.shields;
            

            // science fights religion
            if (scienceBeatsReligion)
            {
                if (jawa.population > 0)
                {
                    // deduct 5% from religionPop
                   hutt.population *= 0.95;
                }
            }
            else
            {
                if (hutt.population > 0)
                {
                    // deduct 5% from sciencePop
                    jawa.population *= 0.95;
                }
            }

            // science fights warfare
            if (warfareBeatsScience)
            {
                if (tusken.population > 0)
                {
                    // deduct 5% from sciencePop
                    jawa.population *= 0.95;
                }
            }
            else
            {
                if (jawa.population > 0)
                {
                    // deduct 5% from warfarePop
                    tusken.population *= 0.95;
                }
            }

            // warfare fights religion
            if (religionBeatsWarfare)
            {
                if (hutt.population > 0)
                {
                    // deduct 5% from warfarePop
                    tusken.population *= 0.95;
                }
            }
            else
            {
                if (tusken.population > 0)
                {
                    // deduct 5% from religionPop
                    hutt.population *= 0.95;
                }
            }

            if (jawa.population <= 0) jawa.population = 0;
            if (tusken.population <= 0) tusken.population = 0;
            if (hutt.population <= 0) hutt.population = 0;

            // return a list representing new values of sciencePop, warfarePop, religionPop
            List<double> returnValues = new List<double>();
            returnValues.Add(Math.Floor(jawa.population));
            returnValues.Add(Math.Floor(tusken.population));
            returnValues.Add(Math.Floor(hutt.population));
            return returnValues;
        }
    }
}
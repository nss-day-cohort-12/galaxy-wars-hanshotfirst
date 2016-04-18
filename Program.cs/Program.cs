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
            tusken.speak("Nevermore");  // Species(parameter) will also be overridden

            bool gameOn = true;
            int year = 2100;
            while (false)
            {
                Console.WriteLine("Year: " + year);
                var xx = gameRound(random, year, jawa.population, tusken.population, hutt.population);
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

        static public List<double> gameRound(Random random, int year, double sciencePop, double warfarePop, double religionPop)
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
            sciencePop -= 20000;
            warfarePop -= 20000;
            religionPop -= 20000;
            // spacefaring recovers 8000
            sciencePop += 8000;
            // additional 10000 religious killed by warfare
            religionPop -= 10000;
            // additional 10000 science killed by warfare
            sciencePop -= 10000;
            // warfare loses 2500
            warfarePop -= 2500;
            // religious gets, and warfare loses, 1% of warfare pop
            religionPop += warfarePop * 0.01;
            warfarePop *= 0.99;
            // religious gets, and science loses, 1% of science pop
            religionPop += sciencePop * 0.01;
            sciencePop *= 0.99;

            // science fights religion
            if (scienceBeatsReligion)
            {
                if (sciencePop > 0)
                {
                    // deduct 5% from religionPop
                    religionPop *= 0.95;
                }
            }
            else
            {
                if (religionPop > 0)
                {
                    // deduct 5% from sciencePop
                    sciencePop *= 0.95;
                }
            }

            // science fights warfare
            if (warfareBeatsScience)
            {
                if (warfarePop > 0)
                {
                    // deduct 5% from sciencePop
                    sciencePop *= 0.95;
                }
            }
            else
            {
                if (sciencePop > 0)
                {
                    // deduct 5% from warfarePop
                    warfarePop *= 0.95;
                }
            }

            // warfare fights religion
            if (religionBeatsWarfare)
            {
                if (religionPop > 0)
                {
                    // deduct 5% from warfarePop
                    warfarePop *= 0.95;
                }
            }
            else
            {
                if (warfarePop > 0)
                {
                    // deduct 5% from religionPop
                    religionPop *= 0.95;
                }
            }

            if (sciencePop <= 0) sciencePop = 0;
            if (warfarePop <= 0) warfarePop = 0;
            if (religionPop <= 0) religionPop = 0;

            // return a list representing new values of sciencePop, warfarePop, religionPop
            List<double> returnValues = new List<double>();
            returnValues.Add(Math.Floor(sciencePop));
            returnValues.Add(Math.Floor(warfarePop));
            returnValues.Add(Math.Floor(religionPop));
            return returnValues;
        }
    }
}
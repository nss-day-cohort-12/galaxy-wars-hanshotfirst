using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyWar;

namespace GalaxyWar
{
    class Program
    {


        static void Main(string[] args)
        {
            Tusken tusken = new Tusken();
            tusken.population = 1000000;
            Console.WriteLine("Tuskens have goal: {0}", tusken.goal);

            Hutt hutt = new Hutt();
            hutt.population = 1000000;
            Console.WriteLine("Hutts have totem: {0}", hutt.totem);

            Jawa jawa = new Jawa();
            jawa.population = 1000000;

            bool gameOn = true;
            int year = 2100;
            while (gameOn)
            {
                Console.WriteLine("Year" + year);
                var xx = gameRound(year, jawa.population, tusken.population, hutt.population);
                year++;
                jawa.population = xx[0];
                tusken.population = xx[1];
                hutt.population = xx[2];
                Console.Write("new jawa pop = {0}\n", xx[0]);
                Console.Write("new tusken pop = {0}\n",xx[1]);
                Console.Write("new hutt pop = {0}\n",xx[2]);

                // check for game over
                if ( jawa.population <= 0 && tusken.population <= 0)
                {
                    Console.WriteLine("Hutts win\n");
                    gameOn = false;
                }
                else if (jawa.population <= 0 && hutt.population <= 0)
                {
                    Console.WriteLine("Tuskens win\n");
                    gameOn = false;
                }
                else if (tusken.population <= 0 && hutt.population <= 0)
                {
                    Console.WriteLine("Jawas win\n");
                    gameOn = false;
                }
           }

        }

        static List<double> gameRound(int year, double sciencePop, double warfarePop, double religionPop)
        {

            bool scienceBeatsReligion = true;
            bool religionBeatsWarfare = true;
            bool warfareBeatsScience = true;

            if (year % 25 == 0)
            {
                // one rule gets reversed
                Random random = new Random();
                int randomNumber = random.Next(0, 3);
                Console.WriteLine("reversing rule " + randomNumber);
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
            // spacefaring recovers 5000
            sciencePop += 5000;
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
            if (scienceBeatsReligion && sciencePop > 0)
            {
                if (sciencePop > 0)
                // deduct 2% from religionPop
                religionPop *= 0.98;
            }
            else
            {
                if (religionPop > 0)
                // deduct 2% from sciencePop
                sciencePop *= 0.98;
            }

            // science fights warfare
            if (warfareBeatsScience)
            {
                if (warfarePop > 0)
                {
                    // deduct 2% from sciencePop
                    sciencePop *= 0.98;
                }
            }
            else
            {
                if (sciencePop > 0)
                {
                    // deduct 2% from warfarePop
                    warfarePop *= 0.98;
                }
            }

            // warfare fights religion
            if (religionBeatsWarfare)
            {
                if (religionPop > 0)
                {
                    // deduct 2% from warfarePop
                    warfarePop *= 0.98;
                }
            }
            else
            {
                if (warfarePop > 0)
                {
                    // deduct 2% from religionPop
                    religionPop *= 0.98;
                }
            }

            // return a list representing new values of sciencePop, warfarePop, religionPop
            List<double> returnValues = new List<double>();
            returnValues.Add(Math.Floor(sciencePop));
            returnValues.Add(Math.Floor(warfarePop));
            returnValues.Add(Math.Floor(religionPop));
            return returnValues;
        }
    }
}

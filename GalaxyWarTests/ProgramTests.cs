using Microsoft.VisualStudio.TestTools.UnitTesting;
using GalaxyWar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GalaxyWar.Testing
{
    [TestClass()]
    public class ProgramTests
    {



        [TestMethod]
      public void testPopDecline()
      {     
                Jawa jawa = new Jawa();
                jawa.population = 1000000;
                Tusken tusken = new Tusken();
                tusken.population = 1000000;
                Hutt hutt = new Hutt();
                hutt.population = 1000000;

            List<double> xx = Program.gameRound(new Random(), 2150, jawa, tusken, hutt);
            Assert.IsTrue(xx[0] < 1000000);
            Assert.IsTrue(xx[1] < 1000000);
            Assert.IsTrue (xx[2] < 1000000);
            
        }
        [TestMethod]
        public void testNotTotalDestruction()
        {
            Jawa jawa = new Jawa();
            jawa.population = 1000000;
            Tusken tusken = new Tusken();
            tusken.population = 1000000;
            Hutt hutt = new Hutt();
            hutt.population = 1000000;

            List<double> xx = Program.gameRound(new Random(), 2150, jawa, tusken, hutt);
            Assert.AreNotEqual(xx[0] , 0);
            Assert.AreNotEqual(xx[1] , 0);
            Assert.AreNotEqual(xx[2] , 0);

        }

        Tusken tusken = new Tusken();
        Hutt hutt = new Hutt();
        Jawa jawa = new Jawa();
        
       [TestMethod]
        public void testMakeSureNoneoftheVariablesAreEqual()
        {
            Jawa jawa = new Jawa();
            jawa.population = 1000000;
            Tusken tusken = new Tusken();
            tusken.population = 1000000;
            Hutt hutt = new Hutt();
            hutt.population = 1000000;

            List<double> xx = Program.gameRound(new Random(), 2151, jawa, tusken, hutt );
            {
               

                Assert.AreNotEqual(jawa.population, tusken.population);
            }
        }

        [TestMethod]
        public void testMakeSureSecondoftheVariablesAreEqual()
        {
            Jawa jawa = new Jawa();
            jawa.population = 1000000;
            Tusken tusken = new Tusken();
            tusken.population = 1000000;
            Hutt hutt = new Hutt();
            hutt.population = 1000000;

            List<double> xx = Program.gameRound(new Random(), 2151, jawa, tusken, hutt);
            {
                
                // 0 = science
                // 1 = religion
                // 2 = warfare
                Assert.AreNotEqual(xx[1], xx[2]);          
            }
        }

        [TestMethod]
        public void testMakeSureThirdoftheVariablesAreEqual()
        {
            Jawa jawa = new Jawa();
            jawa.population = 1000000;
            Tusken tusken = new Tusken();
            tusken.population = 1000000;
            Hutt hutt = new Hutt();
            hutt.population = 1000000;
            List<double> xx = Program.gameRound(new Random(), 2151, jawa, tusken, hutt);
            {
                
                // 0 = science
                // 1 = religion
                // 2 = warfare
                Assert.AreNotEqual(xx[0], xx[2]);
            }
        } //you can add more test methods after this bracket.  I added it because I get confused easily.

        //[TestMethod]
        //public void testWhichIsGreaterScienceOrReligion()
        //{
        //    Jawa jawa = new Jawa();
        //    jawa.population = 1000000;
        //    Tusken tusken = new Tusken();
        //    tusken.population = 1000000;
        //    Hutt hutt = new Hutt();
        //    hutt.population = 1000000;

        //    List<double> xx = Program.gameRound(new Random(), 2151, jawa, tusken, hutt);
        //    {
                
        //        // religion is greater than science
        //        Assert.IsTrue(xx[1] <= xx[0]);
        //    }
        //}
        //[TestMethod]
        //public void testWhichIsGreaterScienceOrWar()
        //{
        //    Jawa jawa = new Jawa();
        //    jawa.population = 1000000;
        //    Tusken tusken = new Tusken();
        //    tusken.population = 1000000;
        //    Hutt hutt = new Hutt();
        //    hutt.population = 1000000;
        //    List<double> xx = Program.gameRound(new Random(), 2151, jawa, tusken, hutt);
        //    {
                
        //        //   war is greater than science
        //        Assert.IsTrue(xx[0] >= xx[2]);
        //    }
        //}
        //[TestMethod]
        //public void testWhichIsGreaterWarOrReligion()
        //{
        //    Jawa jawa = new Jawa();
        //    jawa.population = 1000000;
        //    Tusken tusken = new Tusken();
        //    tusken.population = 1000000;
        //    Hutt hutt = new Hutt();
        //    hutt.population = 1000000;

        //    List<double> xx = Program.gameRound(new Random(), 2151, jawa, tusken, hutt);
        //    {
                
                
        //        //religion is greater than war

        //        Assert.IsTrue(xx[1] >= xx[2]);
        //    }
        //}
        //[TestMethod]
        //public void testToKeepTestingBecauseIWantToTest()
        //{

        //}
    }
}
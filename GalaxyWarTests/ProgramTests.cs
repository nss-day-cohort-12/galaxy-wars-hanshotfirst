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
            List<double> xx = Program.gameRound(new Random(), 2150, 1000000, 1000000, 1000000);
            {

                Assert.IsTrue(xx[0] <= 1000000);
                Assert.IsTrue(xx[1] <= 1000000);
                Assert.IsTrue(xx[2] <= 1000000);
            }
        }

        [TestMethod]
        public void testMakeSureNoneoftheVariablesAreEqual()
        {
            List<double> xx = Program.gameRound(new Random(), 2151, 1000000, 1000000, 1000000);
            {
                //0= science
                //1=religion
                //2=warfare
                Assert.AreNotEqual(xx[0], xx[1]);
                Assert.AreNotEqual(xx[1], xx[2]);
                Assert.AreNotEqual(xx[0], xx[2]);
            }
        }
        [TestMethod]
    public void testWhichIsGreaterScienceOrReligion()
        {
            List<double> xx = Program.gameRound(new Random(), 2151, 1000000, 1000000, 1000000);
            {
                //religion is greater than science
                Assert.IsTrue(xx[1] > xx[0]);
            }
        }
        [TestMethod]
        public void testWhichIsGreaterScienceOrWar()
        {
            List<double> xx = Program.gameRound(new Random(), 2151, 1000000, 1000000, 1000000);
            {
                //war is greater than science
                Assert.IsTrue(xx[2] > xx[0]);
            }
        }
        [TestMethod]
        public void testWhichIsGreaterWarOrReligion()
        {
            List<double> xx = Program.gameRound(new Random(), 2151, 1000000, 1000000, 1000000);
            {
                //religion is greater than war
                Assert.IsTrue(xx[2] > xx[1]);
            }
        }
    }
}
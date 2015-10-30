using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop.Tests
{
    [TestClass()]
    public class LocationTests
    {
        [TestMethod()]
        public void LocationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LocationTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ComparetoTest()
        {
            bool expected = false;
            Location loc1 = new Location(3, 4);
            Location loc2 = new Location(4, 5);
            bool actual = loc1.Compareto(loc2);
            Assert.AreEqual(expected, actual);
        }
        

        [TestMethod()]
        public void DistancetoTest()
        {
            double expected = 5;
            Location loc1 = new Location(0, 0);
            Location loc2 = new Location(4, 3);

            double result = loc1.Distanceto(loc2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void MoveTest()
        {
            bool expected = true;
            Location loc1 = new Location(3, 4);
            Location loc2 = new Location(4, 5);
            loc1.Move(1, 1);
            bool actual = loc1.Compareto(loc2);
            Assert.AreEqual(expected, actual);
        }
    }
}
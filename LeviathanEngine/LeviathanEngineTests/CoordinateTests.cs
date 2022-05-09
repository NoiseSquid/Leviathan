using Microsoft.VisualStudio.TestTools.UnitTesting;

using LeviathanEngine;
using LeviathanEngine.HexMap;
using LeviathanEngine.HexMap.Coords;
using System;

namespace LeviathanEngineTests
{
    [TestClass]
    public class CoordinateTests
    {
        [TestMethod]
        public void CanInitialise()
        {
            var coordOddR = new Coords(CoordSys.OddR, 1, 1);
            var coordCubic = new Coords(CoordSys.Axial, 1, 1);
        }

        [TestMethod]
        public void AllCoordSystemsAreImplemented()
        {
            var allCoordsystems = Enum.GetValues(typeof(CoordSys));
            foreach (CoordSys coordSystem in allCoordsystems)
            {
                var test = new Coords(coordSystem, 1, 1);
                test.X(coordSystem);
                test.Y(coordSystem);
            }
        }

        [TestMethod]
        public void CanGetOddRValues()
        {
            var coordOddR = new Coords(CoordSys.OddR, 5, 6);
            Assert.AreEqual(5, coordOddR.X(CoordSys.OddR));
            Assert.AreEqual(6, coordOddR.Y(CoordSys.OddR));

            coordOddR = new Coords(CoordSys.OddR, -5, -6);
            Assert.AreEqual(-5, coordOddR.X(CoordSys.OddR));
            Assert.AreEqual(-6, coordOddR.Y(CoordSys.OddR));
        }

        public void CanGetAxialValues()
        {
            var coordAxial = new Coords(CoordSys.Axial, 5, 6);
            Assert.AreEqual(5, coordAxial.X(CoordSys.Axial));
            Assert.AreEqual(6, coordAxial.Y(CoordSys.Axial));

            coordAxial = new Coords(CoordSys.Axial, -5, -6);
            Assert.AreEqual(-5, coordAxial.X(CoordSys.Axial));
            Assert.AreEqual(-6, coordAxial.Y(CoordSys.Axial));
        }
    }
}
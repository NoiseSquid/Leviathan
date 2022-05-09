using Microsoft.VisualStudio.TestTools.UnitTesting;

using LeviathanEngine;
using LeviathanEngine.HexMap;
using LeviathanEngine.HexMap.Coords;

namespace LeviathanEngineTests
{
    [TestClass]
    public class GridMapTests
    {
        [TestMethod]
        public void CanCreateMap()
        {
            var hexMap = new GridMap<string>(5, 5);
            Assert.AreEqual(5, hexMap.Width);
            Assert.AreEqual(5, hexMap.Height);
        }

        [TestMethod]
        public void CanSetValueAtCoordinate()
        {
            var hexMap = new GridMap<string>(5, 5);
            var testCoords = new Coords(CoordSys.OddR, 1, 1);
            var unsetCoords = new Coords(CoordSys.OddR, 0, 0);
            hexMap.SetValueAt(testCoords, "test");

            var testValue = hexMap.GetValueAt(testCoords);
            var unsetValue = hexMap.GetValueAt(unsetCoords);
            Assert.AreEqual("test", testValue);
            Assert.AreNotEqual("test", unsetValue);
        }

        [TestMethod]
        public void CanSetTileDefaultValue()
        {
            var hexMap = new GridMap<string>(5, 5, "default");
            var coords = new Coords(CoordSys.OddR, 1, 1);
            Assert.AreEqual("default", hexMap.GetValueAt(coords));
        }

        [TestMethod]
        public void DontSetDefaultIfNotSpecified()
        {
            var hexMap = new GridMap<string>(5, 5);
            var coords = new Coords(CoordSys.OddR, 1, 1);
            Assert.AreNotEqual("default", hexMap.GetValueAt(coords));
        }

        [TestMethod]
        public void CanOnlyGetWithinBounds()
        {
            var hexMap = new GridMap<string>(5, 5);
            var badCoords = new Coords(CoordSys.OddR, 5, 5);
            Assert.ThrowsException<CoordsOutsideHexMapException>(() => hexMap.GetValueAt(badCoords));
        }

        [TestMethod]
        public void CanUseAnyType()
        {
            var hexMap = new GridMap<int>(5, 5, 1);
            var testCoords = new Coords(CoordSys.OddR, 1, 1);
            var unsetCoords = new Coords(CoordSys.OddR, 0, 0);
            hexMap.SetValueAt(testCoords, 2);

            var testValue = hexMap.GetValueAt(testCoords);
            var unsetValue = hexMap.GetValueAt(unsetCoords);
            Assert.AreEqual(2, testValue);
            Assert.AreEqual(1, unsetValue);
        }
    }
}

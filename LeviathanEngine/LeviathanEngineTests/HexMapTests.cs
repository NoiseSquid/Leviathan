using Microsoft.VisualStudio.TestTools.UnitTesting;

using LeviathanEngine;
using LeviathanEngine.HexMap;
using LeviathanEngine.HexMap.Coords;

namespace LeviathanEngineTests
{
    [TestClass]
    public class HexMapTests
    {
        [TestMethod]
        public void CanGetTerrainOfTile()
        {
            HexMap hexMap = new HexMap(5, 5);
            var terrainVal = "test";

            hexMap.SetTerrain(2, 2, terrainVal);
            Assert.AreEqual(terrainVal, hexMap.GetTerrain(2, 2));
            Assert.AreNotEqual(terrainVal, hexMap.GetTerrain(1, 1));
        }
    }
}

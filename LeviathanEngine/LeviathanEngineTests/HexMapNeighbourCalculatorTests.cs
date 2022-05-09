using Microsoft.VisualStudio.TestTools.UnitTesting;

using LeviathanEngine;
using LeviathanEngine.HexMap;
using LeviathanEngine.HexMap.Coords;

namespace LeviathanEngineTests
{
    [TestClass]
    public class HexMapNeighbourCalculatorTests
    {
        [TestMethod]
        public void CanInitialise()
        {
            var hmNCalc1 = new HexMapNeighbourCalculator(5, 5);
            var hmNCalc2 = new HexMapNeighbourCalculator(5, 5, true, false);
        }

        [TestMethod]
        public void CanFindNeighbours()
        {
            var hmNCalc = new HexMapNeighbourCalculator(5, 5);
            
        }
    }
}
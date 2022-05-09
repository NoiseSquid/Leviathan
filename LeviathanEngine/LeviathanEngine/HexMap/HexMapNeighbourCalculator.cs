using System;
using System.Collections.Generic;
using System.Text;

namespace LeviathanEngine.HexMap
{
    public class HexMapNeighbourCalculator
    {
        private readonly int width;
        private readonly int height;
        private readonly bool horizWrap;
        private readonly bool vertWrap;

        public HexMapNeighbourCalculator(int width, int height, bool mapWrapsHorizontally = false, bool mapWrapsVertically = false)
        {
            this.width = width;
            this.height = height;
            horizWrap = mapWrapsHorizontally;
            vertWrap = mapWrapsVertically;
        }
    }
}

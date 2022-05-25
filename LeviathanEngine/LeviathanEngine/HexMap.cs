using System;
using System.Collections.Generic;
using System.Text;

namespace LeviathanEngine
{
    public class HexMap
    {
        public readonly int width;
        public readonly int height;
        public HexProperties[,] hexes;

        public HexMap(int width, int height)
        {
            this.width = width;
            this.height = height;
            InitHexList();
        }

        private void InitHexList()
        {
            hexes = new HexProperties[width, height];
        }
    }
}

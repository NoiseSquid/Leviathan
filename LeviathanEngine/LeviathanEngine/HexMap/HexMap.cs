using System;
using System.Collections.Generic;
using System.Text;

namespace LeviathanEngine.HexMap
{
    public class HexMap
    {
        private GridMap<HexTile> tiles;

        public HexMap(int width, int height)
        {
            tiles = new GridMap<HexTile>(width, height);
        }

        public string SetTerrain(int col, int row, string value)
        {

        }

        public string GetTerrain(int col, int row)
        {

        }

        
    }
}

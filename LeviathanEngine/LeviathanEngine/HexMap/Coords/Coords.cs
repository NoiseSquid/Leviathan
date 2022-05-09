using System;
using System.Collections.Generic;
using System.Text;

namespace LeviathanEngine.HexMap.Coords
{
    public enum CoordSys
    {
        OddR,
        Axial,
    }

    public class Coords
    {
        private int xOddR;
        private int yOddR;

        public Coords(CoordSys coordinateType, int x, int y)
        {
            parseInitialCoords(coordinateType, x, y);
        }

        public int X(CoordSys coordinateType)
        {
            switch (coordinateType)
            {
                case CoordSys.OddR:
                    return xOddR;
                case CoordSys.Axial:
                    return oddRToAxialX(xOddR, yOddR);
                default:
                    throw new CoordSysNotImplementedException(string.Format("Coordinate system '{0}' has not been implemented", coordinateType.ToString()));
            }
        }

        public int Y(CoordSys coordinateType)
        {
            switch (coordinateType)
            {
                case CoordSys.OddR:
                    return yOddR;
                case CoordSys.Axial:
                    return oddRToAxialY(xOddR, yOddR);
                default:
                    throw new CoordSysNotImplementedException(string.Format("Coordinate system '{0}' has not been implemented", coordinateType.ToString()));
            }
        }

        private void parseInitialCoords(CoordSys coordinateType, int x, int y)
        {
            switch (coordinateType)
            {
                case CoordSys.OddR:
                    parseOddR(x, y);
                    break;
                case CoordSys.Axial:
                    parseAxial(x, y);
                    break;
                default:
                    throw new CoordSysNotImplementedException(string.Format("Coordinate system '{0}' has not been implemented", coordinateType.ToString()));
            }
        }

        private void parseOddR(int x, int y)
        {
            xOddR = x;
            yOddR = y;
        }

        private void parseAxial(int x, int y)
        {
            xOddR = x + (y - (y & 1)) / 2;
            yOddR = y;
        }

        private int oddRToAxialX(int x, int y)
        {
            return x - (y - (y & 1)) / 2;
        }

        private int oddRToAxialY(int x, int y)
        {
            return y;
        }
    }
}

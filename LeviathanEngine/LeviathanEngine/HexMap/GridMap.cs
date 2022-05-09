using LeviathanEngine.HexMap;
using LeviathanEngine.HexMap.Coords;
using System;
using System.Collections.Generic;

namespace LeviathanEngine
{
    public class GridMap<T>
    {
        private T[,] _map;
        public readonly int Width;
        public readonly int Height;

        public GridMap(int width, int height)
        {
            Width = width;
            Height = height;
            InitialiseMap();
        }


        public GridMap(int width, int height, T defaultValue) : this(width, height)
        {
            PopulateDefaults(defaultValue);
        }

        public void SetValueAt(Coords coords, T value)
        {
            if (CoordsAreInRange(coords))
                SetValueAtUnsafe(coords, value);
            else
                throw new CoordsOutsideHexMapException(string.Format("Coords \"{0}\" out of range", coords.ToString()));
        }

        public T GetValueAt(Coords coords)
        {
            if (CoordsAreInRange(coords))
                return GetValueAtUnsafe(coords);
            else
                throw new CoordsOutsideHexMapException(string.Format("Coords \"{0}\" out of range", coords.ToString()));
        }

        public bool CoordsAreInRange(Coords coords)
        {
            int col = coords.X(CoordSys.OddR);
            int row = coords.Y(CoordSys.OddR);
            if (col < 0 || col >= Width)
                return false;
            if (row < 0 || row >= Height)
                return false;
            return true;
        }


        private void InitialiseMap()
        {
            _map = new T[Width, Height];
        }

        private void PopulateDefaults(T value)
        {
            for (int col = 0; col < Width; col++)
                for (int row = 0; row < Height; row++)
                    _map[col, row] = value;
        }

        private void SetValueAtUnsafe(Coords coords, T value)
        {
            int col = coords.X(CoordSys.OddR);
            int row = coords.Y(CoordSys.OddR);
            _map[col, row] = value;
        }

        private T GetValueAtUnsafe(Coords coords)
        {
            int col = coords.X(CoordSys.OddR);
            int row = coords.Y(CoordSys.OddR);
            return _map[col, row];
        }
    }
}
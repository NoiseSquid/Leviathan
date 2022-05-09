using System;
using System.Collections.Generic;
using System.Text;

namespace LeviathanEngine.HexMap
{
    public class CoordsOutsideHexMapException : Exception
    {
        public CoordsOutsideHexMapException()
        {
        }

        public CoordsOutsideHexMapException(string message)
            : base(message)
        {
        }

        public CoordsOutsideHexMapException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

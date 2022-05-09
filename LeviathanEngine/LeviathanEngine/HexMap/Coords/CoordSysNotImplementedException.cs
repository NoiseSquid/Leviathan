using System;
using System.Collections.Generic;
using System.Text;

namespace LeviathanEngine.HexMap.Coords
{
    class CoordSysNotImplementedException : Exception
    {
        public CoordSysNotImplementedException()
        {
        }

        public CoordSysNotImplementedException(string message)
            : base(message)
        {
        }

        public CoordSysNotImplementedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

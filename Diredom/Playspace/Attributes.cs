using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diredom.Playspace
{
    public struct Attributes
    {
        public enum BoardSize
        {
            Small,
            Large,
            Length
        }

        public enum TileAttribute
        {
            Normal,
            Rough,
            Impassable,
            Raised,
            Length
        }
    }
}

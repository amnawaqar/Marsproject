using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsproject
{
    public interface Imarsover
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int PX1 { get; set; }
        public int PY1 { get; set; }
        public char Direction { get; set; }
        string instructions { get; set; }
    }
}

using Solid_Principles._4.ISP.Labs.BadExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._4.ISP.Labs.BadExample.Concrete
{
    public class BadSweater : IBadProduct
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
        public int Size { get; set; }
    }
}

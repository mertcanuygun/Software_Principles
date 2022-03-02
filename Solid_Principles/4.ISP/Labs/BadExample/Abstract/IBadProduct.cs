using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._4.ISP.Labs.BadExample.Abstract
{
    public interface IBadProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
        int Inseam { get; set; }
        int WaistSize { get; set; }
    }

}

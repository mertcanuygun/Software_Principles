using Solid_Principles._4.ISP.Labs.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._4.ISP.Labs.GoodExample.Concrete
{
    public class GoodSweater:IGoodProduct
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int BodySize { get; set; }
    }
}

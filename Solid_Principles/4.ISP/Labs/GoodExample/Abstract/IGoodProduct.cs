using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._4.ISP.Labs.GoodExample.Abstract
{
    public interface IGoodProduct
    {
        int ID { get; set; }
        double Price { get; set; }
        int Stock { get; set; }
    }
}

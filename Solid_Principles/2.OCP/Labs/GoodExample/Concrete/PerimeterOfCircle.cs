using Solid_Principles._2.OCP.Labs.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._2.OCP.Labs.GoodExample.Concrete
{
    public class PerimeterOfCircle : IPerimeterCalculation
    {
        public double Radius { get; set; }

        public double PerimeterCalculor()
        {
            return 2 * Radius * Math.PI;
        }
    }
}

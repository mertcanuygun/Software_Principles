using Solid_Principles._2.OCP.Labs.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._2.OCP.Labs.GoodExample.Concrete
{
    public class PerimeterOfTriangle : IPerimeterCalculation
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double PerimeterCalculor()
        {
            return SideA + SideB + SideC;
        }
    }
}

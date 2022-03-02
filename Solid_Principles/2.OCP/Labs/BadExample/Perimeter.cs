using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._2.OCP.Labs.BadExample
{
    public class Perimeter
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double r { get; set; }


        public string PerimeterCalculation(double shape)
        {
            double rectanglesPerimeter = 2 * (a + b);
            double trianglesPerimeter = a + b + c;
            double circlesPerimeter = 2 * Math.PI * r;

            if (shape == rectanglesPerimeter)
            {
                return $"{rectanglesPerimeter}";
            }
            else if (shape == trianglesPerimeter)
            {
                return $"{trianglesPerimeter}";
            }
            else if (shape == circlesPerimeter)
            {
                return $"{circlesPerimeter}";
            }
            else
            {
                return "Object not found";
            }
        }
    }
}

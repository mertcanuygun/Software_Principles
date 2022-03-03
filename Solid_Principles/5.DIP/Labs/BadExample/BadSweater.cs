using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5.DIP.Labs.BadExample
{
    public class BadSweater
    {
        public string PutOn()
        {
            return "Putting sweater on.";
        }

        public string TakeOff()
        {
            return "Taking sweater off.";
        }
    }
}

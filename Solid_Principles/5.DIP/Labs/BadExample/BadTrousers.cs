using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5.DIP.Labs.BadExample
{
    public class BadTrousers
    {
        public string PutOn()
        {
            return "Putting trousers on.";
        }

        public string TakeOff()
        {
            return "Taking trousers off.";
        }
    }
}

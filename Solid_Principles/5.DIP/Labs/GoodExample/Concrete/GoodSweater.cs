using Solid_Principles._5.DIP.Labs.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5.DIP.Labs.GoodExample.Concrete
{
    public class GoodSweater : IShoppingActions
    {
        public string PutOn()
        {
            return "Put sweater on.";
        }

        public string TakeOff()
        {
            return "Take sweater off.";
        }
    }
}

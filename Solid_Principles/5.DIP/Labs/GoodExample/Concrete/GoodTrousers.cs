using Solid_Principles._5.DIP.Labs.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5.DIP.Labs.GoodExample.Concrete
{
    public class GoodTrousers : IShoppingActions
    {
        public string PutOn()
        {
            return "Put trousers on.";
        }

        public string TakeOff()
        {
            return "Take trousers off.";
        }
    }
}

using Solid_Principles._3.LSP.Labs.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._3.LSP.Labs.GoodExample.Concrete
{
    public class GoodStandardUser : BaseGoodSubscription, IBaseStandardSubscription
    {
        public string LimitedContent()
        {
            return "Access granted to limited content.";
        }
    }
}

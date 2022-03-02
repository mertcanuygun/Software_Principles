using Solid_Principles._3.LSP.Labs.BadExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._3.LSP.Labs.BadExample.Concrete
{
    public class StandardUser : BaseBadSubscription, IBaseBadSubscription
    {
        public string LimitedContent()
        {
            return "Access granted to limited content.";
        }

        public string MultipleAccessibility()
        {
            return "Access not granted for multiple screen usage.";
        }

        public string UnlimitedContent()
        {
            return "Access not granted to unlimited content.";
        }
    }
}

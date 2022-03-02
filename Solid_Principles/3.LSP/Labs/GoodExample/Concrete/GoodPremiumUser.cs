using Solid_Principles._3.LSP.Labs.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._3.LSP.Labs.GoodExample.Concrete
{
    public class GoodPremiumUser : BaseGoodSubscription, IBasePremiumSubscription
    {
        public string MultipleAccessibility()
        {
            return "Access granted for multiple screen usage.";
        }

        public string UnlimitedContent()
        {
            return "Access granted to unlimited content.";
        }
    }
}

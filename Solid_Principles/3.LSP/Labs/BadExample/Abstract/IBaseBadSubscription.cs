using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._3.LSP.Labs.BadExample.Abstract
{
    public interface IBaseBadSubscription
    {
        string MultipleAccessibility();

        string UnlimitedContent();

        string LimitedContent();

    }
}

using Solid_Principles._5.DIP.Labs.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5.DIP.Labs.GoodExample
{
    public class ChangingRoom
    {
        private IShoppingActions _shoppingActions;

        public ChangingRoom(IShoppingActions shoppingActions)
        {
            this._shoppingActions = shoppingActions;
        }

        public string ChangeRoom()
        {
            return $"{_shoppingActions.PutOn()}\n{_shoppingActions.TakeOff()}";
        }
    }
}

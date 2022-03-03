using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5.DIP.Labs.BadExample
{
    public class ChangingRoomService
    {
        BadSweater badSweater = new BadSweater();
        BadTrousers badTrousers = new BadTrousers();

        public string ChangingRoom1()
        {
            return $"{badSweater.PutOn()}\n{badTrousers.PutOn()}";
        }

        public string ChangingRoom2()
        {
            return $"{badSweater.TakeOff()}\n{badTrousers.TakeOff()}";
        }
    }
}

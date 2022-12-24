using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.Exception
{
    public class HamsterDoesntExist : ApplicationException
    {
        public HamsterDoesntExist()
        {
        }

        public HamsterDoesntExist(string message)
            : base(message)
        {
        }
    }
}

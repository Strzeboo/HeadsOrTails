using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsOrTails
{
    public class RollHelper
    {
         static public int RollOnce()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}

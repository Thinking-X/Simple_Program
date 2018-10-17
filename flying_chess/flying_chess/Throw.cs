using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flying_chess
{
    class Throw
    {
        public int Step()
        {
            Random R = new Random();
            return R.Next(1, 7);
        }       
    }
}

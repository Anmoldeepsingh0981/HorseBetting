﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseBetting
{
    class Stanley : Punter
    {
        public Stanley()
        {
            Name = "Stanley";
            Cash = 75;
            MyBet = new Bet();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit():base(mov = 1,health = 3)

        public override float Cost{get;} = 5;
    }
}
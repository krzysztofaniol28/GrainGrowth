using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GrainGrowthCore
{
    public class Cell
    {
        public Grain Grain { get; protected set; }

        public Cell()
        {
            Grain = Grain.EmptyGrain;
        }
        public Cell(Grain grain)
        {
            Grain = grain;
        }

        public bool SetGrain(Grain grain)
        {
            if (Grain.IsEmpty() || grain.IsInjection())
            {
                Grain = grain;
                return true;
            }

            return false;
        }
        public void ClearGrain()
        {
            Grain = Grain.EmptyGrain;
        }
    }
}

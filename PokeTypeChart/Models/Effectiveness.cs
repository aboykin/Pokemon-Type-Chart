using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTypeChart.Models
{
    public struct Effectiveness
    {
        //Define effectiveness values 
        public const double DoubleResistance = 0.25;
        public const double SingleResistance = 0.5;
        public const double Immunity = 0;
        public const double Normal = 1;
        public const double SingleWeakness = 2;
        public const double DoubleWeakness = 4;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightNorma.Models.SP52Constants
{
    public class SP52DaylightFactor
    {
        public int Id { get; set; }
        public double? Value { get; set; }
        public string Conditions { get; set; }
        /*
        "Естественное освещение. КЕО при верхнем или комбинир освещении"
        "Естественное освещение. КЕО при боковом освещении"
        "Совмещенное освещение. КЕО при верхнем или комбинир освещении"
        "Совмещенное освещение. КЕО при боковом освещении"
         */
        public int? IlluminanceNormaId { get; set; }
        public IlluminanceNorma IlluminanceNorma { get; set; }
        
    }
}

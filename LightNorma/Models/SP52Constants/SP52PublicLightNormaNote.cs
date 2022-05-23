using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightNorma.Models.SP52Constants
{
    public class SP52PublicLightNormaNote
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public List<Models.PublicLightNormaSet> publicLightNormaSets { get; set; } 
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightNorma.Model
{
    public class IndustrialTotalTable
    {
        public string EyeAccuracy { get; set; }
        public float MinObjectSize0 { get; set; }
        public float MinObjectSizeN { get; set; }
        public char EyeHighLevel { get; set; }
        public List<char> EyeLowLevel { get; set; }

    }
}

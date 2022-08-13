using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LightNorma.Models
{
    public class IlluminanceSet
    {
        public int Id { get; set; }
        [Display(Name = "Освещенность")]
        public int? SP52IlluminanceId { get; set; }
        public SP52Constants.SP52Illuminance SP52Illuminance { get; set; }
        public string TypeShortName { get; set; }
        public string TypeName { get; set; } 
        public double NormalX { get; set; }
        public double NormalY { get; set; }
        public double NormalZ { get; set; }
        public double IllumHeight { get; set; }
        public string AdditionalPlaneInfo { get; set; }
        public int? IlluminanceNormaId { get; set; } 
        public IlluminanceNorma IlluminanceNorma { get; set; }
    }
}

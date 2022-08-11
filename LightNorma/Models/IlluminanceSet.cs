using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LightNorma.Models
{
    public class IlluminanceSet
    {
        public int Id { get; set; }
        public int? SP52IlluminanceId { get; set; }
        public SP52Constants.SP52Illuminance SP52Illuminance { get; set; }
        public string PlaneShortName { get; set; }
        public string PlaneName { get; set; } 
        public double NormalPlaneX { get; set; }
        public double NormalPlaneY { get; set; }
        public double NormalPlaneZ { get; set; }
        public double PlaneHeight { get; set; }
        [Display(Name = "Доп инфо по плоскости")]
        public string AdditionalPlaneInfo { get; set; }
        public IlluminanceNorma IlluminanceNormaId { get; set; } 
        public IlluminanceNorma IlluminanceNorma { get; set; }
    }
}

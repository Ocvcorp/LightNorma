using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightNorma.Models
{
    public class IndustrialLightNormaSet
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указана характеристика")]
        public string EyeAccuracy { get; set; }
        public double? MinObjectSize0 { get; set; }
        public double? MinObjectSizeN { get; set; }

        [Required(ErrorMessage = "Не указан разряд")]
        public int? SP52IndustrialWorkRankId { get; set;}
        public SP52Constants.SP52IndustrialWorkRank SP52IndustrialWorkRank { get; set; }

        public int? SP52IndustrialWorkSubRankId { get; set; }
        public SP52Constants.SP52IndustrialWorkSubRank SP52IndustrialWorkSubRank { get; set; }

        public int? SP52BackgroundContrastId { get; set; }
        public SP52Constants.SP52BackgroundContrast SP52BackgroundContrast { get; set; }

        public int? SP52BackgroundCharacteristicId { get; set; }
        public SP52Constants.SP52BackgroundCharacteristic SP52BackgroundCharacteristic { get; set; }

        public int? CombinedTotalIlluminanceId { get; set; }
        public SP52Constants.SP52Illuminance CombinedTotalIlluminance { get; set; }

        public int? CombinedCommonPartIlluminanceId { get; set; }
        public SP52Constants.SP52Illuminance CombinedCommonPartIlluminance { get; set; }

        public int? CommonIlluminanceId { get; set; }
        public SP52Constants.SP52Illuminance CommonIlluminance { get; set; }

        
        public int? UGR { get; set; } //UGR - unified glare rationg
        public double? FF { get; set; } //FF - flicker factor
        public double? NaturalTopOrCombinedDF { get; set; } //DF - Daylight factor
        public double? NaturalSideDF { get; set; }
        public double? NatArtifTopOrCombinedDF { get; set; }
        public double? NatArtifSideDF { get; set; }

        public int? UserId { get; set; }
        public UserInfrastructure.User User { get; set; }

        public int? LightReglamentId { get; set; }
        public LightReglament LightReglament { get; set; }
    }
}

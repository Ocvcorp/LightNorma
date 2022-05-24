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

        [Display(Name = "Характеристика зрительной работы")]
        [Required(ErrorMessage = "Не указана характеристика")]
        public string EyeAccuracy { get; set; }
        [Display(Name = "Нижняя граница наим(эквив) размера объекта различения")]
        public double? MinObjectSize0 { get; set; }
        [Display(Name = "Верхняя граница наим(эквив) размера объекта различения")]
        public double? MinObjectSizeN { get; set; }

        [Required(ErrorMessage = "Не указан разряд")]
        public int? SP52IndustrialWorkRankId { get; set; }
        [Display(Name = "Разряд зрительной работы")]        
        public SP52Constants.SP52IndustrialWorkRank SP52IndustrialWorkRank { get; set; }

        public int? SP52IndustrialWorkSubRankId { get; set; }
        [Display(Name = "Подразряд зрительной работы")]
        public SP52Constants.SP52IndustrialWorkSubRank SP52IndustrialWorkSubRank { get; set; }

        public int? SP52BackgroundContrastId { get; set; }
        [Display(Name = "Контраст объекта с фоном")]
        public SP52Constants.SP52BackgroundContrast SP52BackgroundContrast { get; set; }

        public int? SP52BackgroundCharacteristicId { get; set; }
        [Display(Name = "Характеристика фона")]
        public SP52Constants.SP52BackgroundCharacteristic SP52BackgroundCharacteristic { get; set; }

        public int? CombinedTotalIlluminanceId { get; set; }
        [Display(Name = "Освещенность при комб. режиме / Всего")]
        public SP52Constants.SP52Illuminance CombinedTotalIlluminance { get; set; }

        public int? CombinedCommonPartIlluminanceId { get; set; }
        [Display(Name = "Освещенность при комб. режиме / От общего")]
        public SP52Constants.SP52Illuminance CombinedCommonPartIlluminance { get; set; }

        [Required(ErrorMessage = "Не выбрана освещенность")]
        public int? CommonIlluminanceId { get; set; }
        [Display(Name = "Освещенность (общее освещение)")]
        public SP52Constants.SP52Illuminance CommonIlluminance { get; set; }

        [Display(Name = "Объединенный показатель UGR")]
        public int? UGR { get; set; } //UGR - unified glare ration
        [Display(Name = "Коэфф пульсации")]
        public double? FF { get; set; } //FF - flicker factor
        [Display(Name = "КЕО при верхнем или комбинир естественном освещении")]
        public double? NaturalTopOrCombinedDF { get; set; } //DF - Daylight factor
        [Display(Name = "КЕО при боковом естественном освещении")]
        public double? NaturalSideDF { get; set; }
        [Display(Name = "КЕО при верхнем или комбинир совмещенном освещении")]
        public double? NatArtifTopOrCombinedDF { get; set; }
        [Display(Name = "КЕО при боковом совмещенном освещении")]
        public double? NatArtifSideDF { get; set; }

        public int? UserId { get; set; }
        [Display(Name = "Пользователь")]
        public UserInfrastructure.User User { get; set; }

        public int? LightReglamentId { get; set; }
        [Display(Name = "Нормативный документ")]
        public LightReglament LightReglament { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LightNorma.Models
{
    public class IlluminanceNorma
    {
        public int Id { get; set; }
        [Display(Name = "Помещения, рабочие места")]
        [Required(ErrorMessage = "Место(помещение) не определено")]
        public List<AreaRoomPlace> AreaRoomPlaces { get; set; } = new List<AreaRoomPlace>();
        [Display(Name = "Плоскость нормирования")]
        public SP52Constants.SP52SemiSphIlluminancePlane SSphIlluminancePlane { get; set; }
        public string SphIlluminancePlaneId { get; set; }
        [Display(Name = "Высота")]
        public double PlaneHeight { get; set; } = 0;
        [Display(Name ="Доп инфо по плоскости")]
        public string AdditionalPlaneInfo { get; set; }
        [Display(Name = "Разряд зрительной работы")] 
        [Required(ErrorMessage = "Не указан разряд")]
        public string WorkRank { get; set; }                        
        [Display(Name = "Подразряд зрительной работы")]
        public string WorkSubRank { get; set; }
        [Display(Name = "Освещенность рабочей поверхности в комбинированном режиме от местного освещения")]
        public SP52Constants.SP52Illuminance CombinedLocalIlluminance { get; set; }
        public int? CombinedLocalIlluminanceId { get; set; }
        [Display(Name = "Освещенность рабочей поверхности в комбинированном режиме от общего освещения")]
        public SP52Constants.SP52Illuminance CombinedCommonIlluminance { get; set; }
        public int? CombinedCommonIlluminanceId { get; set; }
        [Display(Name = "Освещенность рабочей поверхности")]//for indoor/outdoor 
        [Required(ErrorMessage = "Не выбрана освещенность")]
        public SP52Constants.SP52Illuminance Illuminance { get; set; }        
        public int? IlluminanceId { get; set; }
        [Display(Name = "Цилиндрическая освещенность")]
        public SP52Constants.SP52Illuminance CylindricalIlluminance { get; set; }
        public int? CylindricalIlluminanceId { get; set; }
        [Display(Name = "Объединенный показатель UGR")]
        public int? UGR { get; set; } //UGR - unified glare ratio for indoor
        [Display(Name = "Объединенный показатель UGR")]
        public int? Rg { get; set; } //RG (GR) - glare for outdoor 
        [Display(Name = "Коэфф пульсации")]
        public double? FF { get; set; } //FF - flicker factor
        [Display(Name = "Индекс цветопередачи")]
        public double? Ra { get; set; } //Ra - CRI-color rendering index
        [Display(Name = "Естественное освещение. КЕО при верхнем или комбинир освещении")]
        public double? NaturalTopOrCombinedDF { get; set; } //DF - Daylight factor
        [Display(Name = "Естественное освещение. КЕО при боковом освещении")]
        public double? NaturalSideDF { get; set; }
        [Display(Name = "Совмещенное освещение. КЕО при верхнем или комбинир освещении")]
        public double? NatArtifTopOrCombinedDF { get; set; }
        [Display(Name = "Совмещенное освещение. КЕО при боковом освещении")]
        public double? NatArtifSideDF { get; set; }
        [Display(Name = "Примечание")]
        [NotMapped]
        public string Notes { get; set; } //for selecting in listbox
        [Display(Name = "Пользователь")]
        public UserInfrastructure.User User { get; set; }
        public int? UserId { get; set; }      
        [Display(Name = "Нормативный документ")]
        public LightReglament LightReglament { get; set; }
        public int? LightReglamentId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LightNorma.Models
{
    public class PublicLightNormaSet
    {
        public int Id { get; set; }

        [Display (Name = "Характеристика зрительной работы")]
        [Required(ErrorMessage = "Не указана хар-ка зрительной работы")]
        public string EyeAccuracy { get; set; }
        [Display(Name = "Нижняя граница наим(эквив) размера объекта различения")]
        public double? MinObjectSize0 { get; set; }
        [Display(Name = "Верхняя граница наим(эквив) размера объекта различения")]
        public double? MinObjectSizeN { get; set; }
        
        [Display(Name = "Разряд зрительной работы")]       
        public SP52Constants.SP52PublicWorkRank SP52PublicWorkRank { get; set; }
        [Required(ErrorMessage = "Не указан разряд")]
        public int? SP52PublicWorkRankId { get; set; }
                        
        [Display(Name = "Подразряд зрительной работы")]
        public SP52Constants.SP52PublicWorkSubRank SP52PublicWorkSubRank { get; set; }
        public int? SP52PublicWorkSubRankId { get; set; }

        [Display(Name = "Относ продолжительность зрит работы")]
        public double? RelativeWatchDuration { get; set; }
        [Display(Name = "Не менее")]
        public bool IsIntervalStartsFromRWDValue { get; set; }//RWD - RelativeWatchDuration

        [Display(Name = "Горизонтальная освещенность")]
        public SP52Constants.SP52Illuminance HorizontalIlluminance { get; set; }
        [Required(ErrorMessage = "Не выбрана освещенность")]
        public int? HorizontalIlluminanceId { get; set; }

        [Display(Name = "Цилиндрическая освещенность")]
        public SP52Constants.SP52Illuminance CylindricalIlluminance { get; set; }
        public int? CylindricalIlluminanceId { get; set; }      

        [Display(Name = "Объединенный показатель UGR")]
        public int? UGR { get; set; } //UGR - unified glare rationg        
        [Display(Name = "Коэфф пульсации")]
        public double? FF { get; set; } //FF - flicker factor
        [Display(Name = "КЕО при верхнем или комбинир освещении")]
        public double? NaturalTopOrCombinedDF { get; set; } //DF - Daylight factor
        [Display(Name = "КЕО при боковом освещении")]
        public double? NaturalSideDF { get; set; }

        [Display(Name = "Примечание")]
        public List<SP52Constants.SP52PublicLightNormaNote> SP52PublicLightNormaNotes { get; set; } = new();
        [NotMapped]
        public int[] SP52PNSelectedNotes { get; set; } //for selecting in listbox

        [Display(Name = "Пользователь")]
        public UserInfrastructure.User User { get; set; }
        public int? UserId { get; set; }
        

        [Display(Name = "Нормативный документ")]
        public LightReglament LightReglament { get; set; }
        public int? LightReglamentId { get; set; }
        

    }
}

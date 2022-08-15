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
        [Display(Name = "Разряд зрительной работы")] 
        [Required(ErrorMessage = "Не указан разряд")]
        public string WorkRank { get; set; }                        
        [Display(Name = "Подразряд зрительной работы")]
        public string WorkSubRank { get; set; }       
        public List<IlluminanceSet> illuminanceSets { get; set; } = new List<IlluminanceSet>();
        public int? UGR { get; set; } //UGR - unified glare ratio for indoor
        [Display(Name = "Объединенный показатель UGR")]
        public int? Rg { get; set; } //RG (GR) - glare for outdoor 
        [Display(Name = "Коэфф пульсации")]
        public double? FF { get; set; } //FF - flicker factor
        [Display(Name = "Индекс цветопередачи")]
        public double? Ra { get; set; } //Ra - CRI-color rendering index
        public List<SP52Constants.SP52DaylightFactor> DaylightFactors { get; set; } = new List<SP52Constants.SP52DaylightFactor>();
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

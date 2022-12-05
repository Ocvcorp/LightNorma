using LightNorma.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightNorma.ViewModels
{
    public class CategoriesViewModel
    {
        [Display(Name = "Базовый уровень")]
        public BaseAppilcationCategory BaseAppilcationCategory{ get; set; }
        [Display(Name = "Уровень -1")]
        public AreaPlaceCategory1 AreaPlaceCategory1 { get; set; }
        [Display(Name = "Уровень 0")]
        public List<AreaPlaceCategory0> AreaPlaceCategories0 { get; set; }= new List<AreaPlaceCategory0>();
        [Display(Name = "Помещение / Площадь")]
        public List<AreaRoomPlace> AreaRoomPlaces { get; set; } = new List<AreaRoomPlace>();
    }
}

using System.Collections.Generic;
namespace LightNorma.Models
{
    public class AreaRoomPlace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? IlluminanceNormaId { get; set; }       
        public IlluminanceNorma IlluminanceNorma { get; set; }
        public List<AreaPlaceCategory0> AreaPlaceCategories0 { get; set; } = new List<AreaPlaceCategory0>();
        public int AreaPlaceCategory1Id { get; set; }
        public int BaseAppilcationCategoryId { get; set; }
    }
}

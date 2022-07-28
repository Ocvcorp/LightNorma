using System.Collections.Generic;
namespace LightNorma.Models
{
    public class AreaPlaceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<AreaRoomPlace> AreaRoomPlaces { get; set; } = new List<AreaRoomPlace>();
    }
}

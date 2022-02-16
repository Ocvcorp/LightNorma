using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LightNorma.Models
{
    public class LightNormaDBContext:DbContext
    {
        public DbSet<SP52Constants.SP52Illuminance> sp52Illuminances { get; set; }
        public DbSet<SP52Constants.SP52Luminance> sp52Luminances { get; set; }
        public DbSet<SP52Constants.SP52BackgroundCharacteristic> sp52BackgroundCharacteristics  { get; set; }
        public DbSet<SP52Constants.SP52BackgroundContrast> sp52backgroundContrasts  { get; set; }
        public DbSet<SP52Constants.SP52CityAreaCategory> sp52cityAreaCategories { get; set; }
        public DbSet<SP52Constants.SP52IndustrialWorkRank> sp52industrialWorkRanks  { get; set; }
        public DbSet<SP52Constants.SP52IndustrialWorkSubRank> sp52industrialWorkSubRanks  { get; set; }
        public DbSet<SP52Constants.SP52MaxPowerRoomIndex> sp52maxPowerRoomIndices  { get; set; }
        public DbSet<SP52Constants.SP52PedestrianObjectClass> sp52pedestrianObjectClasses { get; set; }
        public DbSet<SP52Constants.SP52PublicWorkRank> sp52publicWorkRanks { get; set; }
        public DbSet<SP52Constants.SP52PublicWorkSubRank> sp52publicWorkSubRanks { get; set; }
        public DbSet<SP52Constants.SP52RoadObjectClass> sp52roadObjectClasses { get; set; }
        public DbSet<SP52Constants.SP52TonnelClass> sp52tonnelClasses { get; set; }
        public DbSet<IndustrialLightNormaSet> IndustrialLightNormaSets { get; set; }

        public LightNormaDBContext(DbContextOptions<LightNormaDBContext> options)
            :base(options)
        {

        }
    }
}

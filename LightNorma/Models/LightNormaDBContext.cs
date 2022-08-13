using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LightNorma.Models
{
    public class LightNormaDBContext:DbContext
    {
        public DbSet<LightReglament> LightReglaments { get; set; }
        public DbSet<UserInfrastructure.User> Users { get; set; }
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
        public DbSet<SP52Constants.SP52PublicLightNormaNote> sP52PublicLightNormaNotes { get; set; } 
        public DbSet<SP52Constants.SP52PublicLightRequirementSP52PublicLightNormaNote> sP52PublicLightRequirementSP52PublicLightNormaNotes { get; set; }
        public DbSet<SP52IndustrialLightRequirement> SP52IndustrialLightRequirements { get; set; }
        public DbSet<SP52PublicLightRequirement> SP52PublicLightRequirements { get; set; }
        public DbSet<IlluminanceNorma> IlluminanceNormas { get; set; }
        public DbSet<IlluminanceSet> illuminanceSets { get; set; }
        public DbSet<SP52Constants.SP52DaylightFactor> sP52DaylightFactors { get; set; }
        public DbSet<AreaPlaceCategory0> AreaPlaceCategories0 { get; set; }
        public DbSet<AreaRoomPlace> AreaRoomPlaces { get; set; }

        public LightNormaDBContext(DbContextOptions<LightNormaDBContext> options)
            :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SP52PublicLightRequirement>().HasMany(x => x.SP52PublicLightNormaNotes)
                .WithMany(x => x.sp52PublicLightRequirements)
                .UsingEntity<SP52Constants.SP52PublicLightRequirementSP52PublicLightNormaNote>(
                x => x.HasOne(x => x.SP52PublicLightNormaNote).WithMany().HasForeignKey(x => x.SP52PublicLightNormaNotesId),
                x => x.HasOne(x => x.SP52PublicLightRequirement)
                .WithMany().HasForeignKey(x => x.publicLightNormaSetsId));
        }



    }
}

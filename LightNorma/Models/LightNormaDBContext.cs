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
        public DbSet<SP52Constants.SP52Illuminance> SP52Illuminances { get; set; }
        public DbSet<SP52Constants.SP52Luminance> SP52Luminances { get; set; }
        public DbSet<SP52Constants.SP52BackgroundCharacteristic> SP52BackgroundCharacteristics  { get; set; }
        public DbSet<SP52Constants.SP52BackgroundContrast> SP52BackgroundContrasts  { get; set; }
        public DbSet<SP52Constants.SP52CityAreaCategory> SP52CityAreaCategories { get; set; }
        public DbSet<SP52Constants.SP52WorkRank> SP52WorkRanks  { get; set; }
        public DbSet<SP52Constants.SP52WorkSubRank> SP52WorkSubRanks  { get; set; }
        public DbSet<SP52Constants.SP52MaxPowerRoomIndex> SP52MaxPowerRoomIndices  { get; set; }
        public DbSet<SP52Constants.SP52PedestrianObjectClass> SP52PedestrianObjectClasses { get; set; }
        public DbSet<SP52Constants.SP52RoadObjectClass> SP52RoadObjectClasses { get; set; }
        public DbSet<SP52Constants.SP52TonnelClass> SP52TonnelClasses { get; set; }
        public DbSet<SP52Constants.SP52PublicLightNormaNote> SP52PublicLightNormaNotes { get; set; }
        public DbSet<SP52IndustrialLightRequirement> SP52IndustrialLightRequirements { get; set; }
        public DbSet<SP52PublicLightRequirement> SP52PublicLightRequirements { get; set; }
        public DbSet<IlluminanceNorma> IlluminanceNormas { get; set; }
        public DbSet<IlluminanceSet> IlluminanceSets { get; set; }
        public DbSet<SP52Constants.SP52DaylightFactor> SP52DaylightFactors { get; set; }
        public DbSet<AreaPlaceCategory0> AreaPlaceCategories0 { get; set; }
        public DbSet<AreaRoomPlace> AreaRoomPlaces { get; set; }

        public LightNormaDBContext(DbContextOptions<LightNormaDBContext> options)
            :base(options)
        {
            
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SP52PublicLightRequirement>().HasMany(x => x.SP52PublicLightNormaNotes)
                .WithMany(x => x.sp52PublicLightRequirements)
                .UsingEntity<SP52Constants.SP52PublicLightRequirementSP52PublicLightNormaNote>(
                x => x.HasOne(x => x.SP52PublicLightNormaNote).WithMany().HasForeignKey(x => x.SP52PublicLightNormaNotesId),
                x => x.HasOne(x => x.SP52PublicLightRequirement)
                .WithMany().HasForeignKey(x => x.SP52PublicLightRequirementsId));
        }*/



    }
}

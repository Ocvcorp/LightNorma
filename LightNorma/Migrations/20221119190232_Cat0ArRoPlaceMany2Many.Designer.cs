﻿// <auto-generated />
using System;
using LightNorma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LightNorma.Migrations
{
    [DbContext(typeof(LightNormaDBContext))]
    [Migration("20221119190232_Cat0ArRoPlaceMany2Many")]
    partial class Cat0ArRoPlaceMany2Many
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AreaPlaceCategory0AreaRoomPlace", b =>
                {
                    b.Property<int>("AreaPlaceCategories0Id")
                        .HasColumnType("int");

                    b.Property<int>("AreaRoomPlacesId")
                        .HasColumnType("int");

                    b.HasKey("AreaPlaceCategories0Id", "AreaRoomPlacesId");

                    b.HasIndex("AreaRoomPlacesId");

                    b.ToTable("AreaPlaceCategory0AreaRoomPlace");
                });

            modelBuilder.Entity("LightNorma.Models.AreaPlaceCategory0", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AreaPlaceCategories0");
                });

            modelBuilder.Entity("LightNorma.Models.AreaPlaceCategory1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AreaPlaceCategories1");
                });

            modelBuilder.Entity("LightNorma.Models.AreaRoomPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AreaPlaceCategory1Id")
                        .HasColumnType("int");

                    b.Property<int>("BaseAppilcationCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IlluminanceNormaId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlluminanceNormaId");

                    b.ToTable("AreaRoomPlaces");
                });

            modelBuilder.Entity("LightNorma.Models.BaseAppilcationCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BaseAppilcationCategories");
                });

            modelBuilder.Entity("LightNorma.Models.IlluminanceNorma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("FF")
                        .HasColumnType("float");

                    b.Property<int?>("LightReglamentId")
                        .HasColumnType("int");

                    b.Property<double?>("NatArtifSideDF")
                        .HasColumnType("float");

                    b.Property<double?>("NatArtifTopOrCombinedDF")
                        .HasColumnType("float");

                    b.Property<double?>("NaturalSideDF")
                        .HasColumnType("float");

                    b.Property<double?>("NaturalTopOrCombinedDF")
                        .HasColumnType("float");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Ra")
                        .HasColumnType("float");

                    b.Property<int?>("Rg")
                        .HasColumnType("int");

                    b.Property<int?>("UGR")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkRank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkSubRank")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LightReglamentId");

                    b.HasIndex("UserId");

                    b.ToTable("IlluminanceNormas");
                });

            modelBuilder.Entity("LightNorma.Models.IlluminanceSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdditionalPlaneInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("IllumHeight")
                        .HasColumnType("float");

                    b.Property<int?>("IlluminanceNormaId")
                        .HasColumnType("int");

                    b.Property<double?>("OXAngleNormal")
                        .HasColumnType("float");

                    b.Property<double?>("OYAngleNormal")
                        .HasColumnType("float");

                    b.Property<double?>("OZAngleNormal")
                        .HasColumnType("float");

                    b.Property<string>("PlaneDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SP52IlluminanceId")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlluminanceNormaId");

                    b.HasIndex("SP52IlluminanceId");

                    b.ToTable("IlluminanceSets");
                });

            modelBuilder.Entity("LightNorma.Models.LightReglament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LightReglaments");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52BackgroundCharacteristic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52BackgroundCharacteristics");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52BackgroundContrast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52BackgroundContrasts");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52CityAreaCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52CityAreaCategories");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52Illuminance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SP52Illuminances");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52Luminance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SP52Luminances");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52MaxPowerRoomIndex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52MaxPowerRoomIndices");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52PedestrianObjectClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52PedestrianObjectClasses");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52PublicLightNormaNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52PublicLightNormaNotes");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52RoadObjectClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52RoadObjectClasses");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52TonnelClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52TonnelClasses");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52WorkRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52WorkRanks");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52WorkSubRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SP52WorkSubRanks");
                });

            modelBuilder.Entity("LightNorma.Models.SP52IndustrialLightRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CombinedCommonPartIlluminanceId")
                        .HasColumnType("int");

                    b.Property<int?>("CombinedTotalIlluminanceId")
                        .HasColumnType("int");

                    b.Property<int?>("CommonIlluminanceId")
                        .HasColumnType("int");

                    b.Property<string>("EyeAccuracy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("FF")
                        .HasColumnType("float");

                    b.Property<int?>("LightReglamentId")
                        .HasColumnType("int");

                    b.Property<double?>("MinObjectSize0")
                        .HasColumnType("float");

                    b.Property<double?>("MinObjectSizeN")
                        .HasColumnType("float");

                    b.Property<double?>("NatArtifSideDF")
                        .HasColumnType("float");

                    b.Property<double?>("NatArtifTopOrCombinedDF")
                        .HasColumnType("float");

                    b.Property<double?>("NaturalSideDF")
                        .HasColumnType("float");

                    b.Property<double?>("NaturalTopOrCombinedDF")
                        .HasColumnType("float");

                    b.Property<int?>("SP52BackgroundCharacteristicId")
                        .HasColumnType("int");

                    b.Property<int?>("SP52BackgroundContrastId")
                        .HasColumnType("int");

                    b.Property<int?>("SP52IndustrialWorkRankId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SP52IndustrialWorkSubRankId")
                        .HasColumnType("int");

                    b.Property<int?>("UGR")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CombinedCommonPartIlluminanceId");

                    b.HasIndex("CombinedTotalIlluminanceId");

                    b.HasIndex("CommonIlluminanceId");

                    b.HasIndex("LightReglamentId");

                    b.HasIndex("SP52BackgroundCharacteristicId");

                    b.HasIndex("SP52BackgroundContrastId");

                    b.HasIndex("SP52IndustrialWorkRankId");

                    b.HasIndex("SP52IndustrialWorkSubRankId");

                    b.HasIndex("UserId");

                    b.ToTable("SP52IndustrialLightRequirements");
                });

            modelBuilder.Entity("LightNorma.Models.SP52PublicLightRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CylindricalIlluminanceId")
                        .HasColumnType("int");

                    b.Property<string>("EyeAccuracy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("FF")
                        .HasColumnType("float");

                    b.Property<int?>("HorizontalIlluminanceId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsIntervalStartsFromRWDValue")
                        .HasColumnType("bit");

                    b.Property<int?>("LightReglamentId")
                        .HasColumnType("int");

                    b.Property<double?>("MinObjectSize0")
                        .HasColumnType("float");

                    b.Property<double?>("MinObjectSizeN")
                        .HasColumnType("float");

                    b.Property<double?>("NaturalSideDF")
                        .HasColumnType("float");

                    b.Property<double?>("NaturalTopOrCombinedDF")
                        .HasColumnType("float");

                    b.Property<double?>("RelativeWatchDuration")
                        .HasColumnType("float");

                    b.Property<int?>("SP52PublicWorkRankId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SP52PublicWorkSubRankId")
                        .HasColumnType("int");

                    b.Property<int?>("UGR")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CylindricalIlluminanceId");

                    b.HasIndex("HorizontalIlluminanceId");

                    b.HasIndex("LightReglamentId");

                    b.HasIndex("SP52PublicWorkRankId");

                    b.HasIndex("SP52PublicWorkSubRankId");

                    b.HasIndex("UserId");

                    b.ToTable("SP52PublicLightRequirements");
                });

            modelBuilder.Entity("LightNorma.Models.UserInfrastructure.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SP52PublicLightNormaNoteSP52PublicLightRequirement", b =>
                {
                    b.Property<int>("SP52PublicLightNormaNotesId")
                        .HasColumnType("int");

                    b.Property<int>("sp52PublicLightRequirementsId")
                        .HasColumnType("int");

                    b.HasKey("SP52PublicLightNormaNotesId", "sp52PublicLightRequirementsId");

                    b.HasIndex("sp52PublicLightRequirementsId");

                    b.ToTable("SP52PublicLightNormaNoteSP52PublicLightRequirement");
                });

            modelBuilder.Entity("AreaPlaceCategory0AreaRoomPlace", b =>
                {
                    b.HasOne("LightNorma.Models.AreaPlaceCategory0", null)
                        .WithMany()
                        .HasForeignKey("AreaPlaceCategories0Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightNorma.Models.AreaRoomPlace", null)
                        .WithMany()
                        .HasForeignKey("AreaRoomPlacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LightNorma.Models.AreaRoomPlace", b =>
                {
                    b.HasOne("LightNorma.Models.IlluminanceNorma", "IlluminanceNorma")
                        .WithMany("AreaRoomPlaces")
                        .HasForeignKey("IlluminanceNormaId");

                    b.Navigation("IlluminanceNorma");
                });

            modelBuilder.Entity("LightNorma.Models.IlluminanceNorma", b =>
                {
                    b.HasOne("LightNorma.Models.LightReglament", "LightReglament")
                        .WithMany()
                        .HasForeignKey("LightReglamentId");

                    b.HasOne("LightNorma.Models.UserInfrastructure.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("LightReglament");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LightNorma.Models.IlluminanceSet", b =>
                {
                    b.HasOne("LightNorma.Models.IlluminanceNorma", "IlluminanceNorma")
                        .WithMany("IlluminanceSets")
                        .HasForeignKey("IlluminanceNormaId");

                    b.HasOne("LightNorma.Models.SP52Constants.SP52Illuminance", "SP52Illuminance")
                        .WithMany()
                        .HasForeignKey("SP52IlluminanceId");

                    b.Navigation("IlluminanceNorma");

                    b.Navigation("SP52Illuminance");
                });

            modelBuilder.Entity("LightNorma.Models.SP52IndustrialLightRequirement", b =>
                {
                    b.HasOne("LightNorma.Models.SP52Constants.SP52Illuminance", "CombinedCommonPartIlluminance")
                        .WithMany()
                        .HasForeignKey("CombinedCommonPartIlluminanceId");

                    b.HasOne("LightNorma.Models.SP52Constants.SP52Illuminance", "CombinedTotalIlluminance")
                        .WithMany()
                        .HasForeignKey("CombinedTotalIlluminanceId");

                    b.HasOne("LightNorma.Models.SP52Constants.SP52Illuminance", "CommonIlluminance")
                        .WithMany()
                        .HasForeignKey("CommonIlluminanceId");

                    b.HasOne("LightNorma.Models.LightReglament", "LightReglament")
                        .WithMany()
                        .HasForeignKey("LightReglamentId");

                    b.HasOne("LightNorma.Models.SP52Constants.SP52BackgroundCharacteristic", "SP52BackgroundCharacteristic")
                        .WithMany()
                        .HasForeignKey("SP52BackgroundCharacteristicId");

                    b.HasOne("LightNorma.Models.SP52Constants.SP52BackgroundContrast", "SP52BackgroundContrast")
                        .WithMany()
                        .HasForeignKey("SP52BackgroundContrastId");

                    b.HasOne("LightNorma.Models.SP52Constants.SP52WorkRank", "SP52IndustrialWorkRank")
                        .WithMany()
                        .HasForeignKey("SP52IndustrialWorkRankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightNorma.Models.SP52Constants.SP52WorkSubRank", "SP52IndustrialWorkSubRank")
                        .WithMany()
                        .HasForeignKey("SP52IndustrialWorkSubRankId");

                    b.HasOne("LightNorma.Models.UserInfrastructure.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("CombinedCommonPartIlluminance");

                    b.Navigation("CombinedTotalIlluminance");

                    b.Navigation("CommonIlluminance");

                    b.Navigation("LightReglament");

                    b.Navigation("SP52BackgroundCharacteristic");

                    b.Navigation("SP52BackgroundContrast");

                    b.Navigation("SP52IndustrialWorkRank");

                    b.Navigation("SP52IndustrialWorkSubRank");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LightNorma.Models.SP52PublicLightRequirement", b =>
                {
                    b.HasOne("LightNorma.Models.SP52Constants.SP52Illuminance", "CylindricalIlluminance")
                        .WithMany()
                        .HasForeignKey("CylindricalIlluminanceId");

                    b.HasOne("LightNorma.Models.SP52Constants.SP52Illuminance", "HorizontalIlluminance")
                        .WithMany()
                        .HasForeignKey("HorizontalIlluminanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightNorma.Models.LightReglament", "LightReglament")
                        .WithMany()
                        .HasForeignKey("LightReglamentId");

                    b.HasOne("LightNorma.Models.SP52Constants.SP52WorkRank", "SP52PublicWorkRank")
                        .WithMany()
                        .HasForeignKey("SP52PublicWorkRankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightNorma.Models.SP52Constants.SP52WorkSubRank", "SP52PublicWorkSubRank")
                        .WithMany()
                        .HasForeignKey("SP52PublicWorkSubRankId");

                    b.HasOne("LightNorma.Models.UserInfrastructure.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("CylindricalIlluminance");

                    b.Navigation("HorizontalIlluminance");

                    b.Navigation("LightReglament");

                    b.Navigation("SP52PublicWorkRank");

                    b.Navigation("SP52PublicWorkSubRank");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SP52PublicLightNormaNoteSP52PublicLightRequirement", b =>
                {
                    b.HasOne("LightNorma.Models.SP52Constants.SP52PublicLightNormaNote", null)
                        .WithMany()
                        .HasForeignKey("SP52PublicLightNormaNotesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightNorma.Models.SP52PublicLightRequirement", null)
                        .WithMany()
                        .HasForeignKey("sp52PublicLightRequirementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LightNorma.Models.IlluminanceNorma", b =>
                {
                    b.Navigation("AreaRoomPlaces");

                    b.Navigation("IlluminanceSets");
                });
#pragma warning restore 612, 618
        }
    }
}

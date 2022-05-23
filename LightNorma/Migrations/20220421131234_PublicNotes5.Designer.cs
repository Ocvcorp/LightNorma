﻿// <auto-generated />
using System;
using LightNorma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LightNorma.Migrations
{
    [DbContext(typeof(LightNormaDBContext))]
    [Migration("20220421131234_PublicNotes5")]
    partial class PublicNotes5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LightNorma.Models.IndustrialLightNormaSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("IndustrialLightNormaSets");
                });

            modelBuilder.Entity("LightNorma.Models.LightReglament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LightReglaments");
                });

            modelBuilder.Entity("LightNorma.Models.PublicLightNormaSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("PublicLightNormaSets");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52BackgroundCharacteristic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52BackgroundCharacteristics");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52BackgroundContrast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52backgroundContrasts");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52CityAreaCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52cityAreaCategories");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52Illuminance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("sp52Illuminances");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52IndustrialWorkRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52industrialWorkRanks");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52IndustrialWorkSubRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52industrialWorkSubRanks");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52Luminance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("sp52Luminances");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52MaxPowerRoomIndex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52maxPowerRoomIndices");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52PedestrianObjectClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52pedestrianObjectClasses");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52PublicLightNormaNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sP52PublicLightNormaNotes");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52PublicWorkRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52publicWorkRanks");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52PublicWorkSubRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52publicWorkSubRanks");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52RoadObjectClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52roadObjectClasses");
                });

            modelBuilder.Entity("LightNorma.Models.SP52Constants.SP52TonnelClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sp52tonnelClasses");
                });

            modelBuilder.Entity("LightNorma.Models.UserInfrastructure.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PublicLightNormaSetSP52PublicLightNormaNote", b =>
                {
                    b.Property<int>("SP52PublicLightNormaNotesId")
                        .HasColumnType("int");

                    b.Property<int>("publicLightNormaSetsId")
                        .HasColumnType("int");

                    b.HasKey("SP52PublicLightNormaNotesId", "publicLightNormaSetsId");

                    b.HasIndex("publicLightNormaSetsId");

                    b.ToTable("PublicLightNormaSetSP52PublicLightNormaNote");
                });

            modelBuilder.Entity("LightNorma.Models.IndustrialLightNormaSet", b =>
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

                    b.HasOne("LightNorma.Models.SP52Constants.SP52IndustrialWorkRank", "SP52IndustrialWorkRank")
                        .WithMany()
                        .HasForeignKey("SP52IndustrialWorkRankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightNorma.Models.SP52Constants.SP52IndustrialWorkSubRank", "SP52IndustrialWorkSubRank")
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

            modelBuilder.Entity("LightNorma.Models.PublicLightNormaSet", b =>
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

                    b.HasOne("LightNorma.Models.SP52Constants.SP52PublicWorkRank", "SP52PublicWorkRank")
                        .WithMany()
                        .HasForeignKey("SP52PublicWorkRankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightNorma.Models.SP52Constants.SP52PublicWorkSubRank", "SP52PublicWorkSubRank")
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

            modelBuilder.Entity("PublicLightNormaSetSP52PublicLightNormaNote", b =>
                {
                    b.HasOne("LightNorma.Models.SP52Constants.SP52PublicLightNormaNote", null)
                        .WithMany()
                        .HasForeignKey("SP52PublicLightNormaNotesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightNorma.Models.PublicLightNormaSet", null)
                        .WithMany()
                        .HasForeignKey("publicLightNormaSetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class CreateLightNormaV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaPlaceCategories0",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPlaceCategories0", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LightReglaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightReglaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52BackgroundCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52BackgroundCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52BackgroundContrasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52BackgroundContrasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52CityAreaCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52CityAreaCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52Illuminances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52Illuminances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52Luminances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52Luminances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52MaxPowerRoomIndices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52MaxPowerRoomIndices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52PedestrianObjectClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52PedestrianObjectClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52PublicLightNormaNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52PublicLightNormaNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52RoadObjectClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52RoadObjectClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52TonnelClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52TonnelClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52WorkRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52WorkRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP52WorkSubRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52WorkSubRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IlluminanceNormas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkSubRank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UGR = table.Column<int>(type: "int", nullable: true),
                    Rg = table.Column<int>(type: "int", nullable: true),
                    FF = table.Column<double>(type: "float", nullable: true),
                    Ra = table.Column<double>(type: "float", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    LightReglamentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlluminanceNormas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IlluminanceNormas_LightReglaments_LightReglamentId",
                        column: x => x.LightReglamentId,
                        principalTable: "LightReglaments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IlluminanceNormas_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP52IndustrialLightRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EyeAccuracy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinObjectSize0 = table.Column<double>(type: "float", nullable: true),
                    MinObjectSizeN = table.Column<double>(type: "float", nullable: true),
                    SP52IndustrialWorkRankId = table.Column<int>(type: "int", nullable: false),
                    SP52IndustrialWorkSubRankId = table.Column<int>(type: "int", nullable: true),
                    SP52BackgroundContrastId = table.Column<int>(type: "int", nullable: true),
                    SP52BackgroundCharacteristicId = table.Column<int>(type: "int", nullable: true),
                    CombinedTotalIlluminanceId = table.Column<int>(type: "int", nullable: true),
                    CombinedCommonPartIlluminanceId = table.Column<int>(type: "int", nullable: true),
                    CommonIlluminanceId = table.Column<int>(type: "int", nullable: false),
                    UGR = table.Column<int>(type: "int", nullable: true),
                    FF = table.Column<double>(type: "float", nullable: true),
                    NaturalTopOrCombinedDF = table.Column<double>(type: "float", nullable: true),
                    NaturalSideDF = table.Column<double>(type: "float", nullable: true),
                    NatArtifTopOrCombinedDF = table.Column<double>(type: "float", nullable: true),
                    NatArtifSideDF = table.Column<double>(type: "float", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    LightReglamentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52IndustrialLightRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_LightReglaments_LightReglamentId",
                        column: x => x.LightReglamentId,
                        principalTable: "LightReglaments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_SP52BackgroundCharacteristics_SP52BackgroundCharacteristicId",
                        column: x => x.SP52BackgroundCharacteristicId,
                        principalTable: "SP52BackgroundCharacteristics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_SP52BackgroundContrasts_SP52BackgroundContrastId",
                        column: x => x.SP52BackgroundContrastId,
                        principalTable: "SP52BackgroundContrasts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_SP52Illuminances_CombinedCommonPartIlluminanceId",
                        column: x => x.CombinedCommonPartIlluminanceId,
                        principalTable: "SP52Illuminances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_SP52Illuminances_CombinedTotalIlluminanceId",
                        column: x => x.CombinedTotalIlluminanceId,
                        principalTable: "SP52Illuminances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_SP52Illuminances_CommonIlluminanceId",
                        column: x => x.CommonIlluminanceId,
                        principalTable: "SP52Illuminances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_SP52WorkRanks_SP52IndustrialWorkRankId",
                        column: x => x.SP52IndustrialWorkRankId,
                        principalTable: "SP52WorkRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_SP52WorkSubRanks_SP52IndustrialWorkSubRankId",
                        column: x => x.SP52IndustrialWorkSubRankId,
                        principalTable: "SP52WorkSubRanks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52IndustrialLightRequirements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP52PublicLightRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EyeAccuracy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinObjectSize0 = table.Column<double>(type: "float", nullable: true),
                    MinObjectSizeN = table.Column<double>(type: "float", nullable: true),
                    SP52PublicWorkRankId = table.Column<int>(type: "int", nullable: false),
                    SP52PublicWorkSubRankId = table.Column<int>(type: "int", nullable: true),
                    RelativeWatchDuration = table.Column<double>(type: "float", nullable: true),
                    IsIntervalStartsFromRWDValue = table.Column<bool>(type: "bit", nullable: false),
                    HorizontalIlluminanceId = table.Column<int>(type: "int", nullable: false),
                    CylindricalIlluminanceId = table.Column<int>(type: "int", nullable: true),
                    UGR = table.Column<int>(type: "int", nullable: true),
                    FF = table.Column<double>(type: "float", nullable: true),
                    NaturalTopOrCombinedDF = table.Column<double>(type: "float", nullable: true),
                    NaturalSideDF = table.Column<double>(type: "float", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    LightReglamentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52PublicLightRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP52PublicLightRequirements_LightReglaments_LightReglamentId",
                        column: x => x.LightReglamentId,
                        principalTable: "LightReglaments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52PublicLightRequirements_SP52Illuminances_CylindricalIlluminanceId",
                        column: x => x.CylindricalIlluminanceId,
                        principalTable: "SP52Illuminances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52PublicLightRequirements_SP52Illuminances_HorizontalIlluminanceId",
                        column: x => x.HorizontalIlluminanceId,
                        principalTable: "SP52Illuminances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP52PublicLightRequirements_SP52WorkRanks_SP52PublicWorkRankId",
                        column: x => x.SP52PublicWorkRankId,
                        principalTable: "SP52WorkRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP52PublicLightRequirements_SP52WorkSubRanks_SP52PublicWorkSubRankId",
                        column: x => x.SP52PublicWorkSubRankId,
                        principalTable: "SP52WorkSubRanks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP52PublicLightRequirements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AreaRoomPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlluminanceNormaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaRoomPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreaRoomPlaces_IlluminanceNormas_IlluminanceNormaId",
                        column: x => x.IlluminanceNormaId,
                        principalTable: "IlluminanceNormas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IlluminanceSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SP52IlluminanceId = table.Column<int>(type: "int", nullable: true),
                    TypeShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OXAngleNormal = table.Column<double>(type: "float", nullable: true),
                    OYAngleNormal = table.Column<double>(type: "float", nullable: true),
                    OZAngleNormal = table.Column<double>(type: "float", nullable: true),
                    IllumHeight = table.Column<double>(type: "float", nullable: true),
                    AdditionalPlaneInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlluminanceNormaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlluminanceSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IlluminanceSets_IlluminanceNormas_IlluminanceNormaId",
                        column: x => x.IlluminanceNormaId,
                        principalTable: "IlluminanceNormas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IlluminanceSets_SP52Illuminances_SP52IlluminanceId",
                        column: x => x.SP52IlluminanceId,
                        principalTable: "SP52Illuminances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP52DaylightFactors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: true),
                    Conditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlluminanceNormaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52DaylightFactors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP52DaylightFactors_IlluminanceNormas_IlluminanceNormaId",
                        column: x => x.IlluminanceNormaId,
                        principalTable: "IlluminanceNormas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP52PublicLightNormaNoteSP52PublicLightRequirement",
                columns: table => new
                {
                    SP52PublicLightNormaNotesId = table.Column<int>(type: "int", nullable: false),
                    sp52PublicLightRequirementsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP52PublicLightNormaNoteSP52PublicLightRequirement", x => new { x.SP52PublicLightNormaNotesId, x.sp52PublicLightRequirementsId });
                    table.ForeignKey(
                        name: "FK_SP52PublicLightNormaNoteSP52PublicLightRequirement_SP52PublicLightNormaNotes_SP52PublicLightNormaNotesId",
                        column: x => x.SP52PublicLightNormaNotesId,
                        principalTable: "SP52PublicLightNormaNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP52PublicLightNormaNoteSP52PublicLightRequirement_SP52PublicLightRequirements_sp52PublicLightRequirementsId",
                        column: x => x.sp52PublicLightRequirementsId,
                        principalTable: "SP52PublicLightRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AreaPlaceCategory0AreaRoomPlace",
                columns: table => new
                {
                    AreaPlaceCategoriesId = table.Column<int>(type: "int", nullable: false),
                    AreaRoomPlacesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPlaceCategory0AreaRoomPlace", x => new { x.AreaPlaceCategoriesId, x.AreaRoomPlacesId });
                    table.ForeignKey(
                        name: "FK_AreaPlaceCategory0AreaRoomPlace_AreaPlaceCategories0_AreaPlaceCategoriesId",
                        column: x => x.AreaPlaceCategoriesId,
                        principalTable: "AreaPlaceCategories0",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaPlaceCategory0AreaRoomPlace_AreaRoomPlaces_AreaRoomPlacesId",
                        column: x => x.AreaRoomPlacesId,
                        principalTable: "AreaRoomPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaPlaceCategory0AreaRoomPlace_AreaRoomPlacesId",
                table: "AreaPlaceCategory0AreaRoomPlace",
                column: "AreaRoomPlacesId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaRoomPlaces_IlluminanceNormaId",
                table: "AreaRoomPlaces",
                column: "IlluminanceNormaId");

            migrationBuilder.CreateIndex(
                name: "IX_IlluminanceNormas_LightReglamentId",
                table: "IlluminanceNormas",
                column: "LightReglamentId");

            migrationBuilder.CreateIndex(
                name: "IX_IlluminanceNormas_UserId",
                table: "IlluminanceNormas",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IlluminanceSets_IlluminanceNormaId",
                table: "IlluminanceSets",
                column: "IlluminanceNormaId");

            migrationBuilder.CreateIndex(
                name: "IX_IlluminanceSets_SP52IlluminanceId",
                table: "IlluminanceSets",
                column: "SP52IlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52DaylightFactors_IlluminanceNormaId",
                table: "SP52DaylightFactors",
                column: "IlluminanceNormaId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_CombinedCommonPartIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                column: "CombinedCommonPartIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_CombinedTotalIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                column: "CombinedTotalIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_CommonIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                column: "CommonIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_LightReglamentId",
                table: "SP52IndustrialLightRequirements",
                column: "LightReglamentId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_SP52BackgroundCharacteristicId",
                table: "SP52IndustrialLightRequirements",
                column: "SP52BackgroundCharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_SP52BackgroundContrastId",
                table: "SP52IndustrialLightRequirements",
                column: "SP52BackgroundContrastId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_SP52IndustrialWorkRankId",
                table: "SP52IndustrialLightRequirements",
                column: "SP52IndustrialWorkRankId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_SP52IndustrialWorkSubRankId",
                table: "SP52IndustrialLightRequirements",
                column: "SP52IndustrialWorkSubRankId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52IndustrialLightRequirements_UserId",
                table: "SP52IndustrialLightRequirements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52PublicLightNormaNoteSP52PublicLightRequirement_sp52PublicLightRequirementsId",
                table: "SP52PublicLightNormaNoteSP52PublicLightRequirement",
                column: "sp52PublicLightRequirementsId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52PublicLightRequirements_CylindricalIlluminanceId",
                table: "SP52PublicLightRequirements",
                column: "CylindricalIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52PublicLightRequirements_HorizontalIlluminanceId",
                table: "SP52PublicLightRequirements",
                column: "HorizontalIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52PublicLightRequirements_LightReglamentId",
                table: "SP52PublicLightRequirements",
                column: "LightReglamentId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52PublicLightRequirements_SP52PublicWorkRankId",
                table: "SP52PublicLightRequirements",
                column: "SP52PublicWorkRankId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52PublicLightRequirements_SP52PublicWorkSubRankId",
                table: "SP52PublicLightRequirements",
                column: "SP52PublicWorkSubRankId");

            migrationBuilder.CreateIndex(
                name: "IX_SP52PublicLightRequirements_UserId",
                table: "SP52PublicLightRequirements",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaPlaceCategory0AreaRoomPlace");

            migrationBuilder.DropTable(
                name: "IlluminanceSets");

            migrationBuilder.DropTable(
                name: "SP52CityAreaCategories");

            migrationBuilder.DropTable(
                name: "SP52DaylightFactors");

            migrationBuilder.DropTable(
                name: "SP52IndustrialLightRequirements");

            migrationBuilder.DropTable(
                name: "SP52Luminances");

            migrationBuilder.DropTable(
                name: "SP52MaxPowerRoomIndices");

            migrationBuilder.DropTable(
                name: "SP52PedestrianObjectClasses");

            migrationBuilder.DropTable(
                name: "SP52PublicLightNormaNoteSP52PublicLightRequirement");

            migrationBuilder.DropTable(
                name: "SP52RoadObjectClasses");

            migrationBuilder.DropTable(
                name: "SP52TonnelClasses");

            migrationBuilder.DropTable(
                name: "AreaPlaceCategories0");

            migrationBuilder.DropTable(
                name: "AreaRoomPlaces");

            migrationBuilder.DropTable(
                name: "SP52BackgroundCharacteristics");

            migrationBuilder.DropTable(
                name: "SP52BackgroundContrasts");

            migrationBuilder.DropTable(
                name: "SP52PublicLightNormaNotes");

            migrationBuilder.DropTable(
                name: "SP52PublicLightRequirements");

            migrationBuilder.DropTable(
                name: "IlluminanceNormas");

            migrationBuilder.DropTable(
                name: "SP52Illuminances");

            migrationBuilder.DropTable(
                name: "SP52WorkRanks");

            migrationBuilder.DropTable(
                name: "SP52WorkSubRanks");

            migrationBuilder.DropTable(
                name: "LightReglaments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LightNorma.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.CreateTable(
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
                name: "sp52BackgroundCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52BackgroundCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52backgroundContrasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52backgroundContrasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52cityAreaCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52cityAreaCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52Illuminances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52Illuminances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52industrialWorkRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52industrialWorkRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52industrialWorkSubRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52industrialWorkSubRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52Luminances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52Luminances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52maxPowerRoomIndices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52maxPowerRoomIndices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52pedestrianObjectClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52pedestrianObjectClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sP52PublicLightNormaNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sP52PublicLightNormaNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52publicWorkRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52publicWorkRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52publicWorkSubRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52publicWorkSubRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52roadObjectClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52roadObjectClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sp52tonnelClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sp52tonnelClasses", x => x.Id);
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
                    CommonIlluminanceId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_IndustrialLightNormaSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_LightReglaments_LightReglamentId",
                        column: x => x.LightReglamentId,
                        principalTable: "LightReglaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_sp52BackgroundCharacteristics_SP52BackgroundCharacteristicId",
                        column: x => x.SP52BackgroundCharacteristicId,
                        principalTable: "sp52BackgroundCharacteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_sp52backgroundContrasts_SP52BackgroundContrastId",
                        column: x => x.SP52BackgroundContrastId,
                        principalTable: "sp52backgroundContrasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_sp52Illuminances_CombinedCommonPartIlluminanceId",
                        column: x => x.CombinedCommonPartIlluminanceId,
                        principalTable: "sp52Illuminances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_sp52Illuminances_CombinedTotalIlluminanceId",
                        column: x => x.CombinedTotalIlluminanceId,
                        principalTable: "sp52Illuminances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_sp52Illuminances_CommonIlluminanceId",
                        column: x => x.CommonIlluminanceId,
                        principalTable: "sp52Illuminances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_sp52industrialWorkRanks_SP52IndustrialWorkRankId",
                        column: x => x.SP52IndustrialWorkRankId,
                        principalTable: "sp52industrialWorkRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_sp52industrialWorkSubRanks_SP52IndustrialWorkSubRankId",
                        column: x => x.SP52IndustrialWorkSubRankId,
                        principalTable: "sp52industrialWorkSubRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialLightNormaSets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    SP52PublicLightNormaNoteId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    LightReglamentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicLightNormaSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublicLightNormaSets_LightReglaments_LightReglamentId",
                        column: x => x.LightReglamentId,
                        principalTable: "LightReglaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublicLightNormaSets_sp52Illuminances_CylindricalIlluminanceId",
                        column: x => x.CylindricalIlluminanceId,
                        principalTable: "sp52Illuminances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublicLightNormaSets_sp52Illuminances_HorizontalIlluminanceId",
                        column: x => x.HorizontalIlluminanceId,
                        principalTable: "sp52Illuminances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicLightNormaSets_sp52publicWorkRanks_SP52PublicWorkRankId",
                        column: x => x.SP52PublicWorkRankId,
                        principalTable: "sp52publicWorkRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicLightNormaSets_sp52publicWorkSubRanks_SP52PublicWorkSubRankId",
                        column: x => x.SP52PublicWorkSubRankId,
                        principalTable: "sp52publicWorkSubRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublicLightNormaSets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_CombinedCommonPartIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                column: "CombinedCommonPartIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_CombinedTotalIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                column: "CombinedTotalIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_CommonIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                column: "CommonIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_LightReglamentId",
                table: "SP52IndustrialLightRequirements",
                column: "LightReglamentId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_SP52BackgroundCharacteristicId",
                table: "SP52IndustrialLightRequirements",
                column: "SP52BackgroundCharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_SP52BackgroundContrastId",
                table: "SP52IndustrialLightRequirements",
                column: "SP52BackgroundContrastId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_SP52IndustrialWorkRankId",
                table: "SP52IndustrialLightRequirements",
                column: "SP52IndustrialWorkRankId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_SP52IndustrialWorkSubRankId",
                table: "SP52IndustrialLightRequirements",
                column: "SP52IndustrialWorkSubRankId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialLightNormaSets_UserId",
                table: "SP52IndustrialLightRequirements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_CylindricalIlluminanceId",
                table: "SP52PublicLightRequirements",
                column: "CylindricalIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_HorizontalIlluminanceId",
                table: "SP52PublicLightRequirements",
                column: "HorizontalIlluminanceId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_LightReglamentId",
                table: "SP52PublicLightRequirements",
                column: "LightReglamentId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_SP52PublicWorkRankId",
                table: "SP52PublicLightRequirements",
                column: "SP52PublicWorkRankId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_SP52PublicWorkSubRankId",
                table: "SP52PublicLightRequirements",
                column: "SP52PublicWorkSubRankId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_UserId",
                table: "SP52PublicLightRequirements",
                column: "UserId");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SP52IndustrialLightRequirements");

            migrationBuilder.DropTable(
                name: "SP52PublicLightRequirements");

            migrationBuilder.DropTable(
                name: "sp52cityAreaCategories");

            migrationBuilder.DropTable(
                name: "sp52Luminances");

            migrationBuilder.DropTable(
                name: "sp52maxPowerRoomIndices");

            migrationBuilder.DropTable(
                name: "sp52pedestrianObjectClasses");

            migrationBuilder.DropTable(
                name: "sP52PublicLightNormaNotes");

            migrationBuilder.DropTable(
                name: "sp52roadObjectClasses");

            migrationBuilder.DropTable(
                name: "sp52tonnelClasses");

            migrationBuilder.DropTable(
                name: "sp52BackgroundCharacteristics");

            migrationBuilder.DropTable(
                name: "sp52backgroundContrasts");

            migrationBuilder.DropTable(
                name: "sp52industrialWorkRanks");

            migrationBuilder.DropTable(
                name: "sp52industrialWorkSubRanks");

            migrationBuilder.DropTable(
                name: "LightReglaments");

            migrationBuilder.DropTable(
                name: "sp52Illuminances");

            migrationBuilder.DropTable(
                name: "sp52publicWorkRanks");

            migrationBuilder.DropTable(
                name: "sp52publicWorkSubRanks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class DFOff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SP52DaylightFactors");

            migrationBuilder.AddColumn<double>(
                name: "NatArtifSideDF",
                table: "IlluminanceNormas",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NatArtifTopOrCombinedDF",
                table: "IlluminanceNormas",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NaturalSideDF",
                table: "IlluminanceNormas",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NaturalTopOrCombinedDF",
                table: "IlluminanceNormas",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NatArtifSideDF",
                table: "IlluminanceNormas");

            migrationBuilder.DropColumn(
                name: "NatArtifTopOrCombinedDF",
                table: "IlluminanceNormas");

            migrationBuilder.DropColumn(
                name: "NaturalSideDF",
                table: "IlluminanceNormas");

            migrationBuilder.DropColumn(
                name: "NaturalTopOrCombinedDF",
                table: "IlluminanceNormas");

            migrationBuilder.CreateTable(
                name: "SP52DaylightFactors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlluminanceNormaId = table.Column<int>(type: "int", nullable: true),
                    Conditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_SP52DaylightFactors_IlluminanceNormaId",
                table: "SP52DaylightFactors",
                column: "IlluminanceNormaId");
        }
    }
}

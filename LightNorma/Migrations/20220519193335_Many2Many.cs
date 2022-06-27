using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class Many2Many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublicLightNormaSetSP52PublicLightNormaNote");

            migrationBuilder.CreateTable(
                name: "sP52PublicLightRequirementSP52PublicLightNormaNotes",
                columns: table => new
                {
                    SP52PublicLightNormaNotesId = table.Column<int>(type: "int", nullable: false),
                    publicLightNormaSetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publicLightNormaSetSP52PublicLightNormaNotes", x => new { x.SP52PublicLightNormaNotesId, x.publicLightNormaSetsId });
                    table.ForeignKey(
                        name: "FK_publicLightNormaSetSP52PublicLightNormaNotes_PublicLightNormaSets_publicLightNormaSetsId",
                        column: x => x.publicLightNormaSetsId,
                        principalTable: "SP52PublicLightRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_publicLightNormaSetSP52PublicLightNormaNotes_sP52PublicLightNormaNotes_SP52PublicLightNormaNotesId",
                        column: x => x.SP52PublicLightNormaNotesId,
                        principalTable: "sP52PublicLightNormaNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_publicLightNormaSetSP52PublicLightNormaNotes_publicLightNormaSetsId",
                table: "sP52PublicLightRequirementSP52PublicLightNormaNotes",
                column: "publicLightNormaSetsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sP52PublicLightRequirementSP52PublicLightNormaNotes");

            migrationBuilder.CreateTable(
                name: "PublicLightNormaSetSP52PublicLightNormaNote",
                columns: table => new
                {
                    SP52PublicLightNormaNotesId = table.Column<int>(type: "int", nullable: false),
                    publicLightNormaSetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicLightNormaSetSP52PublicLightNormaNote", x => new { x.SP52PublicLightNormaNotesId, x.publicLightNormaSetsId });
                    table.ForeignKey(
                        name: "FK_PublicLightNormaSetSP52PublicLightNormaNote_PublicLightNormaSets_publicLightNormaSetsId",
                        column: x => x.publicLightNormaSetsId,
                        principalTable: "SP52PublicLightRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicLightNormaSetSP52PublicLightNormaNote_sP52PublicLightNormaNotes_SP52PublicLightNormaNotesId",
                        column: x => x.SP52PublicLightNormaNotesId,
                        principalTable: "sP52PublicLightNormaNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSetSP52PublicLightNormaNote_publicLightNormaSetsId",
                table: "PublicLightNormaSetSP52PublicLightNormaNote",
                column: "publicLightNormaSetsId");
        }
    }
}

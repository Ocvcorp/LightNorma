using Microsoft.EntityFrameworkCore.Migrations;

namespace LightNorma.Migrations
{
    public partial class PublicNotes5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pubLightNSetNotes");

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
                        principalTable: "PublicLightNormaSets",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublicLightNormaSetSP52PublicLightNormaNote");

            migrationBuilder.CreateTable(
                name: "pubLightNSetNotes",
                columns: table => new
                {
                    PublicLightNormaSetId = table.Column<int>(type: "int", nullable: false),
                    SP52PublicLightNormaNoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pubLightNSetNotes", x => new { x.PublicLightNormaSetId, x.SP52PublicLightNormaNoteId });
                    table.ForeignKey(
                        name: "FK_pubLightNSetNotes_PublicLightNormaSets_PublicLightNormaSetId",
                        column: x => x.PublicLightNormaSetId,
                        principalTable: "PublicLightNormaSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pubLightNSetNotes_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                        column: x => x.SP52PublicLightNormaNoteId,
                        principalTable: "sP52PublicLightNormaNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pubLightNSetNotes_SP52PublicLightNormaNoteId",
                table: "pubLightNSetNotes",
                column: "SP52PublicLightNormaNoteId");
        }
    }
}

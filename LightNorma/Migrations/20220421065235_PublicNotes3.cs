using Microsoft.EntityFrameworkCore.Migrations;

namespace LightNorma.Migrations
{
    public partial class PublicNotes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublicLightNormaSets_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements");

            migrationBuilder.DropIndex(
                name: "IX_PublicLightNormaSets_SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements");

            migrationBuilder.DropColumn(
                name: "SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements");

            migrationBuilder.CreateTable(
                name: "pubLightNSetNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicLightNormaSetId = table.Column<int>(type: "int", nullable: true),
                    SP52PublicLightNormaNoteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pubLightNSetNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pubLightNSetNotes_PublicLightNormaSets_PublicLightNormaSetId",
                        column: x => x.PublicLightNormaSetId,
                        principalTable: "SP52PublicLightRequirements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pubLightNSetNotes_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                        column: x => x.SP52PublicLightNormaNoteId,
                        principalTable: "sP52PublicLightNormaNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pubLightNSetNotes_PublicLightNormaSetId",
                table: "pubLightNSetNotes",
                column: "PublicLightNormaSetId");

            migrationBuilder.CreateIndex(
                name: "IX_pubLightNSetNotes_SP52PublicLightNormaNoteId",
                table: "pubLightNSetNotes",
                column: "SP52PublicLightNormaNoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pubLightNSetNotes");

            migrationBuilder.AddColumn<int>(
                name: "SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements",
                column: "SP52PublicLightNormaNoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_PublicLightNormaSets_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements",
                column: "SP52PublicLightNormaNoteId",
                principalTable: "sP52PublicLightNormaNotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

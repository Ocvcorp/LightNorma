using Microsoft.EntityFrameworkCore.Migrations;

namespace LightNorma.Migrations
{
    public partial class PublicNoteManyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SP52PublicLightNormaNoteId",
                table: "PublicLightNormaSets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_SP52PublicLightNormaNoteId",
                table: "PublicLightNormaSets",
                column: "SP52PublicLightNormaNoteId",
                unique: true,
                filter: "[SP52PublicLightNormaNoteId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_PublicLightNormaSets_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                table: "PublicLightNormaSets",
                column: "SP52PublicLightNormaNoteId",
                principalTable: "sP52PublicLightNormaNotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublicLightNormaSets_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                table: "PublicLightNormaSets");

            migrationBuilder.DropIndex(
                name: "IX_PublicLightNormaSets_SP52PublicLightNormaNoteId",
                table: "PublicLightNormaSets");

            migrationBuilder.DropColumn(
                name: "SP52PublicLightNormaNoteId",
                table: "PublicLightNormaSets");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LightNorma.Migrations
{
    public partial class PublicNoteManyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PublicLightNormaSets_SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements");

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements",
                column: "SP52PublicLightNormaNoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PublicLightNormaSets_SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements");

            migrationBuilder.CreateIndex(
                name: "IX_PublicLightNormaSets_SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements",
                column: "SP52PublicLightNormaNoteId",
                unique: true,
                filter: "[SP52PublicLightNormaNoteId] IS NOT NULL");
        }
    }
}

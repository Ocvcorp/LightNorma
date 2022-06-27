using Microsoft.EntityFrameworkCore.Migrations;

namespace LightNorma.Migrations
{
    public partial class NoteIdDelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SP52PublicLightNormaNoteId",
                table: "SP52PublicLightRequirements",
                type: "int",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class BaseCat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseApplicationCategoryId",
                table: "AreaPlaceCategories0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseApplicationCategoryId",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

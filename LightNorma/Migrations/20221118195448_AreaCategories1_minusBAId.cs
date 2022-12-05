using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class AreaCategories1_minusBAId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

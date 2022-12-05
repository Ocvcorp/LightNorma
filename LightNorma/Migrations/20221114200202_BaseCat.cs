using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class BaseCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseApplicationCategoryId",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BaseAppilcationCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseAppilcationCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaPlaceCategories0_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0",
                column: "BaseAppilcationCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AreaPlaceCategories0_BaseAppilcationCategories_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0",
                column: "BaseAppilcationCategoryId",
                principalTable: "BaseAppilcationCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreaPlaceCategories0_BaseAppilcationCategories_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropTable(
                name: "BaseAppilcationCategories");

            migrationBuilder.DropIndex(
                name: "IX_AreaPlaceCategories0_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropColumn(
                name: "BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropColumn(
                name: "BaseApplicationCategoryId",
                table: "AreaPlaceCategories0");
        }
    }
}

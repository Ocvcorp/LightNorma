using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class AreaCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreaPlaceCategories0_BaseAppilcationCategories_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropForeignKey(
                name: "FK_AreaPlaceCategory0AreaRoomPlace_AreaPlaceCategories0_AreaPlaceCategoriesId",
                table: "AreaPlaceCategory0AreaRoomPlace");

            migrationBuilder.DropIndex(
                name: "IX_AreaPlaceCategories0_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0");

            migrationBuilder.RenameColumn(
                name: "AreaPlaceCategoriesId",
                table: "AreaPlaceCategory0AreaRoomPlace",
                newName: "AreaPlaceCategories0Id");

            migrationBuilder.AddColumn<string>(
                name: "PlaneDescription",
                table: "IlluminanceSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AreaPlaceCategories1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseAppilcationCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPlaceCategories1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreaPlaceCategories1_BaseAppilcationCategories_BaseAppilcationCategoryId",
                        column: x => x.BaseAppilcationCategoryId,
                        principalTable: "BaseAppilcationCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaPlaceCategories0_AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0",
                column: "AreaPlaceCategory1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPlaceCategories1_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories1",
                column: "BaseAppilcationCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AreaPlaceCategories0_AreaPlaceCategories1_AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0",
                column: "AreaPlaceCategory1Id",
                principalTable: "AreaPlaceCategories1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AreaPlaceCategory0AreaRoomPlace_AreaPlaceCategories0_AreaPlaceCategories0Id",
                table: "AreaPlaceCategory0AreaRoomPlace",
                column: "AreaPlaceCategories0Id",
                principalTable: "AreaPlaceCategories0",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreaPlaceCategories0_AreaPlaceCategories1_AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropForeignKey(
                name: "FK_AreaPlaceCategory0AreaRoomPlace_AreaPlaceCategories0_AreaPlaceCategories0Id",
                table: "AreaPlaceCategory0AreaRoomPlace");

            migrationBuilder.DropTable(
                name: "AreaPlaceCategories1");

            migrationBuilder.DropIndex(
                name: "IX_AreaPlaceCategories0_AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropColumn(
                name: "PlaneDescription",
                table: "IlluminanceSets");

            migrationBuilder.DropColumn(
                name: "AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0");

            migrationBuilder.RenameColumn(
                name: "AreaPlaceCategories0Id",
                table: "AreaPlaceCategory0AreaRoomPlace",
                newName: "AreaPlaceCategoriesId");

            migrationBuilder.AlterColumn<int>(
                name: "BaseAppilcationCategoryId",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AreaPlaceCategory0AreaRoomPlace_AreaPlaceCategories0_AreaPlaceCategoriesId",
                table: "AreaPlaceCategory0AreaRoomPlace",
                column: "AreaPlaceCategoriesId",
                principalTable: "AreaPlaceCategories0",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

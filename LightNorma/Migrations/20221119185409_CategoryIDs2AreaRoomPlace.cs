﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class CategoryIDs2AreaRoomPlace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreaPlaceCategories0_AreaPlaceCategories1_AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropForeignKey(
                name: "FK_AreaPlaceCategories1_BaseAppilcationCategories_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories1");

            migrationBuilder.DropTable(
                name: "AreaPlaceCategory0AreaRoomPlace");

            migrationBuilder.DropIndex(
                name: "IX_AreaPlaceCategories1_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories1");

            migrationBuilder.DropIndex(
                name: "IX_AreaPlaceCategories0_AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropColumn(
                name: "BaseAppilcationCategoryId",
                table: "AreaPlaceCategories1");

            migrationBuilder.DropColumn(
                name: "AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0");

            migrationBuilder.AddColumn<int>(
                name: "AreaPlaceCategory1Id",
                table: "AreaRoomPlaces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseAppilcationCategoryId",
                table: "AreaRoomPlaces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaRoomPlaceId",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AreaPlaceCategories0_AreaRoomPlaceId",
                table: "AreaPlaceCategories0",
                column: "AreaRoomPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AreaPlaceCategories0_AreaRoomPlaces_AreaRoomPlaceId",
                table: "AreaPlaceCategories0",
                column: "AreaRoomPlaceId",
                principalTable: "AreaRoomPlaces",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreaPlaceCategories0_AreaRoomPlaces_AreaRoomPlaceId",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropIndex(
                name: "IX_AreaPlaceCategories0_AreaRoomPlaceId",
                table: "AreaPlaceCategories0");

            migrationBuilder.DropColumn(
                name: "AreaPlaceCategory1Id",
                table: "AreaRoomPlaces");

            migrationBuilder.DropColumn(
                name: "BaseAppilcationCategoryId",
                table: "AreaRoomPlaces");

            migrationBuilder.DropColumn(
                name: "AreaRoomPlaceId",
                table: "AreaPlaceCategories0");

            migrationBuilder.AddColumn<int>(
                name: "BaseAppilcationCategoryId",
                table: "AreaPlaceCategories1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AreaPlaceCategory0AreaRoomPlace",
                columns: table => new
                {
                    AreaPlaceCategories0Id = table.Column<int>(type: "int", nullable: false),
                    AreaRoomPlacesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaPlaceCategory0AreaRoomPlace", x => new { x.AreaPlaceCategories0Id, x.AreaRoomPlacesId });
                    table.ForeignKey(
                        name: "FK_AreaPlaceCategory0AreaRoomPlace_AreaPlaceCategories0_AreaPlaceCategories0Id",
                        column: x => x.AreaPlaceCategories0Id,
                        principalTable: "AreaPlaceCategories0",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaPlaceCategory0AreaRoomPlace_AreaRoomPlaces_AreaRoomPlacesId",
                        column: x => x.AreaRoomPlacesId,
                        principalTable: "AreaRoomPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaPlaceCategories1_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories1",
                column: "BaseAppilcationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPlaceCategories0_AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0",
                column: "AreaPlaceCategory1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AreaPlaceCategory0AreaRoomPlace_AreaRoomPlacesId",
                table: "AreaPlaceCategory0AreaRoomPlace",
                column: "AreaRoomPlacesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AreaPlaceCategories0_AreaPlaceCategories1_AreaPlaceCategory1Id",
                table: "AreaPlaceCategories0",
                column: "AreaPlaceCategory1Id",
                principalTable: "AreaPlaceCategories1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AreaPlaceCategories1_BaseAppilcationCategories_BaseAppilcationCategoryId",
                table: "AreaPlaceCategories1",
                column: "BaseAppilcationCategoryId",
                principalTable: "BaseAppilcationCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

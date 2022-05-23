using Microsoft.EntityFrameworkCore.Migrations;

namespace LightNorma.Migrations
{
    public partial class PublicNotes4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pubLightNSetNotes_PublicLightNormaSets_PublicLightNormaSetId",
                table: "pubLightNSetNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_pubLightNSetNotes_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                table: "pubLightNSetNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pubLightNSetNotes",
                table: "pubLightNSetNotes");

            migrationBuilder.DropIndex(
                name: "IX_pubLightNSetNotes_PublicLightNormaSetId",
                table: "pubLightNSetNotes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "pubLightNSetNotes");

            migrationBuilder.AlterColumn<int>(
                name: "SP52PublicLightNormaNoteId",
                table: "pubLightNSetNotes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PublicLightNormaSetId",
                table: "pubLightNSetNotes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_pubLightNSetNotes",
                table: "pubLightNSetNotes",
                columns: new[] { "PublicLightNormaSetId", "SP52PublicLightNormaNoteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_pubLightNSetNotes_PublicLightNormaSets_PublicLightNormaSetId",
                table: "pubLightNSetNotes",
                column: "PublicLightNormaSetId",
                principalTable: "PublicLightNormaSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pubLightNSetNotes_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                table: "pubLightNSetNotes",
                column: "SP52PublicLightNormaNoteId",
                principalTable: "sP52PublicLightNormaNotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pubLightNSetNotes_PublicLightNormaSets_PublicLightNormaSetId",
                table: "pubLightNSetNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_pubLightNSetNotes_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                table: "pubLightNSetNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pubLightNSetNotes",
                table: "pubLightNSetNotes");

            migrationBuilder.AlterColumn<int>(
                name: "SP52PublicLightNormaNoteId",
                table: "pubLightNSetNotes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PublicLightNormaSetId",
                table: "pubLightNSetNotes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "pubLightNSetNotes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pubLightNSetNotes",
                table: "pubLightNSetNotes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_pubLightNSetNotes_PublicLightNormaSetId",
                table: "pubLightNSetNotes",
                column: "PublicLightNormaSetId");

            migrationBuilder.AddForeignKey(
                name: "FK_pubLightNSetNotes_PublicLightNormaSets_PublicLightNormaSetId",
                table: "pubLightNSetNotes",
                column: "PublicLightNormaSetId",
                principalTable: "PublicLightNormaSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pubLightNSetNotes_sP52PublicLightNormaNotes_SP52PublicLightNormaNoteId",
                table: "pubLightNSetNotes",
                column: "SP52PublicLightNormaNoteId",
                principalTable: "sP52PublicLightNormaNotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

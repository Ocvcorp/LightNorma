using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LightNorma.Migrations
{
    public partial class IndustCommENULL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP52IndustrialLightRequirements_SP52Illuminances_CommonIlluminanceId",
                table: "SP52IndustrialLightRequirements");

            migrationBuilder.AlterColumn<int>(
                name: "CommonIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SP52IndustrialLightRequirements_SP52Illuminances_CommonIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                column: "CommonIlluminanceId",
                principalTable: "SP52Illuminances",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP52IndustrialLightRequirements_SP52Illuminances_CommonIlluminanceId",
                table: "SP52IndustrialLightRequirements");

            migrationBuilder.AlterColumn<int>(
                name: "CommonIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SP52IndustrialLightRequirements_SP52Illuminances_CommonIlluminanceId",
                table: "SP52IndustrialLightRequirements",
                column: "CommonIlluminanceId",
                principalTable: "SP52Illuminances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

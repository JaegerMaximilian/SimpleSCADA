using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSCADA_SharedResources.Migrations.DbCreation
{
    public partial class InitialCreate24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_ProductionCycles_ActiveProductionCycleId",
                table: "Plants");

            migrationBuilder.AlterColumn<int>(
                name: "ActiveProductionCycleId",
                table: "Plants",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_ProductionCycles_ActiveProductionCycleId",
                table: "Plants",
                column: "ActiveProductionCycleId",
                principalTable: "ProductionCycles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_ProductionCycles_ActiveProductionCycleId",
                table: "Plants");

            migrationBuilder.AlterColumn<int>(
                name: "ActiveProductionCycleId",
                table: "Plants",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_ProductionCycles_ActiveProductionCycleId",
                table: "Plants",
                column: "ActiveProductionCycleId",
                principalTable: "ProductionCycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

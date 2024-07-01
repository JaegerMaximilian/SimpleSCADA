using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSCADA_SharedResources.Migrations.DbCreation
{
    public partial class InitialCreate26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_ProductionCycles_ProductionCycleId",
                table: "Logs");

            migrationBuilder.AlterColumn<int>(
                name: "ProductionCycleId",
                table: "Logs",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_ProductionCycles_ProductionCycleId",
                table: "Logs",
                column: "ProductionCycleId",
                principalTable: "ProductionCycles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_ProductionCycles_ProductionCycleId",
                table: "Logs");

            migrationBuilder.AlterColumn<int>(
                name: "ProductionCycleId",
                table: "Logs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_ProductionCycles_ProductionCycleId",
                table: "Logs",
                column: "ProductionCycleId",
                principalTable: "ProductionCycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

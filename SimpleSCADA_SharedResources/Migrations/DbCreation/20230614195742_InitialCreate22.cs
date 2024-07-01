using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSCADA_SharedResources.Migrations.DbCreation
{
    public partial class InitialCreate22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "RecipesStations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "RecipesStations");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanyspieShop.Migrations
{
    public partial class FixedPieColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IPieOfTheWeek",
                table: "Pies",
                newName: "IsPieOfTheWeek");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPieOfTheWeek",
                table: "Pies",
                newName: "IPieOfTheWeek");
        }
    }
}

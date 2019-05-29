using Microsoft.EntityFrameworkCore.Migrations;

namespace kafer_house.Migrations
{
    public partial class something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "branch",
                table: "CartActual",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "shoppingMall",
                table: "CartActual",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "branch",
                table: "CartActual");

            migrationBuilder.DropColumn(
                name: "shoppingMall",
                table: "CartActual");
        }
    }
}

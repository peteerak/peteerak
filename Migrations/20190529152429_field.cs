using Microsoft.EntityFrameworkCore.Migrations;

namespace kafer_house.Migrations
{
    public partial class field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "shoppingMall",
                table: "CartActual",
                newName: "shoppingMallId");

            migrationBuilder.RenameColumn(
                name: "branch",
                table: "CartActual",
                newName: "branchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "shoppingMallId",
                table: "CartActual",
                newName: "shoppingMall");

            migrationBuilder.RenameColumn(
                name: "branchId",
                table: "CartActual",
                newName: "branch");
        }
    }
}

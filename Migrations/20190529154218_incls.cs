using Microsoft.EntityFrameworkCore.Migrations;

namespace kafer_house.Migrations
{
    public partial class incls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "shoppingMallId",
                table: "CartActual",
                newName: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_CartActual_shoppingmallID",
                table: "CartActual",
                column: "shoppingmallID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartActual_ShoppingMall_shoppingmallID",
                table: "CartActual",
                column: "shoppingmallID",
                principalTable: "ShoppingMall",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartActual_ShoppingMall_shoppingmallID",
                table: "CartActual");

            migrationBuilder.DropIndex(
                name: "IX_CartActual_shoppingmallID",
                table: "CartActual");

            migrationBuilder.RenameColumn(
                name: "shoppingmallID",
                table: "CartActual",
                newName: "shoppingMallId");
        }
    }
}

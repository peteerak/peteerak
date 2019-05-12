using Microsoft.EntityFrameworkCore.Migrations;

namespace kafer_house.Migrations
{
    public partial class deletemodelrestrictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "ShoppingMall",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "code",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "ShoppingMall",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Product",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "code",
                table: "Product",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

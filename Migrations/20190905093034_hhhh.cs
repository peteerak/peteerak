using Microsoft.EntityFrameworkCore.Migrations;

namespace kafer_house.Migrations
{
    public partial class hhhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "staffName",
                table: "Delivery",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "staffName",
                table: "Delivery");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kafer_house.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    code = table.Column<string>(nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrders",
                columns: table => new
                {
                    saleID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    zone = table.Column<int>(nullable: false),
                    saleAmount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrders", x => x.saleID);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingMall",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingMall", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ActualSold",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    productID = table.Column<int>(nullable: false),
                    shoppingmallID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActualSold", x => x.id);
                    table.ForeignKey(
                        name: "FK_ActualSold_Product_productID",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActualSold_ShoppingMall_shoppingmallID",
                        column: x => x.shoppingmallID,
                        principalTable: "ShoppingMall",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    shoppingmallID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.id);
                    table.ForeignKey(
                        name: "FK_Branch_ShoppingMall_shoppingmallID",
                        column: x => x.shoppingmallID,
                        principalTable: "ShoppingMall",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryReturn",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    lotdate = table.Column<DateTime>(nullable: false),
                    productID = table.Column<int>(nullable: false),
                    shoppingmallID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryReturn", x => x.id);
                    table.ForeignKey(
                        name: "FK_DeliveryReturn_Product_productID",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryReturn_ShoppingMall_shoppingmallID",
                        column: x => x.shoppingmallID,
                        principalTable: "ShoppingMall",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartActual",
                columns: table => new
                {
                    cartId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    createdDate = table.Column<DateTime>(nullable: false),
                    dateSold = table.Column<DateTime>(nullable: false),
                    totalRevenue = table.Column<double>(nullable: false),
                    branchId = table.Column<int>(nullable: false),
                    shoppingmallID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartActual", x => x.cartId);
                    table.ForeignKey(
                        name: "FK_CartActual_Branch_branchId",
                        column: x => x.branchId,
                        principalTable: "Branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartActual_ShoppingMall_shoppingmallID",
                        column: x => x.shoppingmallID,
                        principalTable: "ShoppingMall",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItemActual",
                columns: table => new
                {
                    cartItemId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    productId = table.Column<string>(nullable: true),
                    productName = table.Column<string>(nullable: true),
                    productQty = table.Column<int>(nullable: false),
                    productPrice = table.Column<double>(nullable: false),
                    cartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItemActual", x => x.cartItemId);
                    table.ForeignKey(
                        name: "FK_CartItemActual_CartActual_cartId",
                        column: x => x.cartId,
                        principalTable: "CartActual",
                        principalColumn: "cartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActualSold_productID",
                table: "ActualSold",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_ActualSold_shoppingmallID",
                table: "ActualSold",
                column: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_shoppingmallID",
                table: "Branch",
                column: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_CartActual_branchId",
                table: "CartActual",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_CartActual_shoppingmallID",
                table: "CartActual",
                column: "shoppingmallID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItemActual_cartId",
                table: "CartItemActual",
                column: "cartId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryReturn_productID",
                table: "DeliveryReturn",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryReturn_shoppingmallID",
                table: "DeliveryReturn",
                column: "shoppingmallID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActualSold");

            migrationBuilder.DropTable(
                name: "CartItemActual");

            migrationBuilder.DropTable(
                name: "DeliveryReturn");

            migrationBuilder.DropTable(
                name: "SaleOrders");

            migrationBuilder.DropTable(
                name: "CartActual");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "ShoppingMall");
        }
    }
}
